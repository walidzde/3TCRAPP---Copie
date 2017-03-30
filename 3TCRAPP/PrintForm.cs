using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace _3TCRAPP
{
    public partial class PrintForm : MetroFramework.Forms.MetroForm
    {
        SqlDbConnect ocon;
        Acte acte=new Acte();
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            
            string curDir = Directory.GetCurrentDirectory();
            ActeView.Url = new Uri(string.Format($"file:///{curDir}/ok.html"));
            
        }
        //to create the HTML file so we can print it 
        public void CreateActHtml()
        {
            if (File.Exists("ok.html"))
            {
                File.Delete("ok.html");
            }
            StreamWriter sw = new StreamWriter("ok.html");
            /*StreamReader sr = new StreamReader("page acte.htm");
            string content = sr.ReadToEnd();
            sr.Close();
            content = Regex.Replace(content, "ACTENUMBER", Acte.list_act[0].AnneeAct);
            sw.Write(content);*/
            var xl = new StringBuilder(File.ReadAllText(@"page acte.htm"));
            xl.Replace("ACTENUMBER", Acte.list_act[0].AnneeAct);
            xl.Replace("ACTENUMBER", Acte.list_act[0].Num);
            xl.Replace("ACTEYEAR", Acte.list_act[0].Num);
            xl.Replace("LNFR", Acte.list_act[0].Nom);
            xl.Replace("LNAR", Acte.list_act[0].NomAr);
            xl.Replace("FNFR", Acte.list_act[0].Prenom);
            xl.Replace("FNAR", Acte.list_act[0].PreAr);
            xl.Replace("NATIOFR", Acte.list_act[0].Nationnalite);
            xl.Replace("NATIOAR", Acte.list_act[0].NationAr);
            xl.Replace("LIEUFR", Acte.list_act[0].LieuNaiss);
            xl.Replace("LIEUAR", Acte.list_act[0].LieuNaissAr);
            xl.Replace("JOURFR", Acte.list_act[0].Jour);
            xl.Replace("MONTHFR", Acte.list_act[0].Mois);
            xl.Replace("YEARFR", Acte.list_act[0].Annee);
            xl.Replace("PEREFR", Acte.list_act[0].Pere);
            xl.Replace("PEREAR", Acte.list_act[0].PereAr);
            xl.Replace("MEREFR", Acte.list_act[0].Mere);
            xl.Replace("MEREAR", Acte.list_act[0].MereAr);
            xl.Replace("DECESAR", Acte.list_act[0].Deces);
            xl.Replace("DECESFR", Acte.list_act[0].DecesAr);
            xl.Replace("JOURAR", Acte.list_act[0].JourH);
            xl.Replace("MONTHAR", Acte.list_act[0].MoisH);
            xl.Replace("YEARAR", Acte.list_act[0].AnneeH);
            xl.Replace("GETDATE", DateTime.Now.ToShortDateString());
            sw.AutoFlush = true;
            sw.Write(xl);
            
            string curDir = Directory.GetCurrentDirectory();
            ActeView.Url = new Uri(string.Format($"file:///{curDir}/ok.html"));
            curDir = Regex.Replace(curDir, " ", "%20");
            try
            {
               System.Diagnostics.Process.Start("Chrome", String.Format($"file:///{curDir}/ok.html"));

            }
            catch (Exception)
            {
                System.Diagnostics.Process.Start($"file:///{curDir}/ok.html");
            }
            
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            ActeView.ShowPrintDialog();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        public bool checkall()
        {
            {

                foreach (TextBox t in this.Controls.OfType<TextBox>())
                {
                    if(t.Text=="")
                    errorProvider1.SetError(t, "STP ne laisse pas les champs vide");
                    return false;
                }            }
            return true;
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Acte.list_act.Clear();
            errorProvider1.Clear();
            if(checkall()==true)
            {
                ocon = new SqlDbConnect();
                ocon.SqlQuery("select num,anneeAct,nom,nomAr,prenom,preAr,nationnalite,nationAr,lieuNaiss,lieuNaissAr,jour,mois,annee,pere,pereAr,mere,mereAr,deces,decesAr,jourAr,moisAr,anneeAr from acte1 where  num=@num and anneeAct=@anneeAct");
                ocon.Cmd.Parameters.Add("num", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = YEAR.Text;
                ocon.Cmd.Parameters.Add("anneeAct", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = NUMACT.Text;
              //dataGridView1.DataSource = ocon.QueryEx();
                try
                {
                    
                    acte.AnneeAct=(string)ocon.QueryEx().Rows[0][0];
                    acte.Num = (string)ocon.QueryEx().Rows[0][1];
                    acte.Nom = (string)ocon.QueryEx().Rows[0][2];
                    acte.NomAr = (string)ocon.QueryEx().Rows[0][3];
                    acte.Prenom = (string)ocon.QueryEx().Rows[0][4];
                    acte.PreAr = (string)ocon.QueryEx().Rows[0][5];
                    acte.Nationnalite = (string)ocon.QueryEx().Rows[0][6];
                    acte.NationAr = (string)ocon.QueryEx().Rows[0][7];
                    acte.LieuNaiss = (string)ocon.QueryEx().Rows[0][8];
                    acte.LieuNaissAr = (string)ocon.QueryEx().Rows[0][9];
                    acte.Jour = (string)ocon.QueryEx().Rows[0][10];
                    acte.Mois = (string)ocon.QueryEx().Rows[0][11];
                    acte.Annee = (string)ocon.QueryEx().Rows[0][12];
                    acte.Pere = (string)ocon.QueryEx().Rows[0][13];
                    acte.PereAr = (string)ocon.QueryEx().Rows[0][14];
                    acte.Mere = (string)ocon.QueryEx().Rows[0][15];
                    acte.MereAr = (string)ocon.QueryEx().Rows[0][16];
                    acte.Deces = (string)ocon.QueryEx().Rows[0][17];
                    acte.DecesAr = (string)ocon.QueryEx().Rows[0][18];
                    acte.JourH = (string)ocon.QueryEx().Rows[0][19];
                    acte.MoisH = (string)ocon.QueryEx().Rows[0][20];
                    acte.AnneeH = (string)ocon.QueryEx().Rows[0][21];
                    Acte.list_act.Add(acte);
                    MessageBox.Show("Personne Trouvé");
                    CreateActHtml();
                }
                catch (Exception )
                {
                    errorProvider1.SetError(NUMACT, "هذا الشخص لا يتواجد في قاعدة البيانات المرجو إضافته");
                }
            }
            
            

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
