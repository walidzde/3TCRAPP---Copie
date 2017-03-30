using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3TCRAPP
{
    public partial class printformCI : MetroFramework.Forms.MetroForm
    {
        SqlDbConnect ocon;
        public printformCI()
        {
            InitializeComponent();
        }
        
        private void mbsearch_Click(object sender, EventArgs e)
        {
            
            DoSearch(tnumact.Text,tyear.Text);
            if (namewewanttosee.Text != "")
            {
                if(MessageBox.Show("هل تريد طباعة النسخة الكاملة ؟", $"{ocon.QueryEx().Rows[0][2].ToString() + ocon.QueryEx().Rows[0][4].ToString()}",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                    CreateIntegralCopie();
                }
            }
        }

        private void printformCI_Load(object sender, EventArgs e)
        {
            try
            {
                if (CopieIntegral.list_ci.Count != 0)
                { 
                if (CopieIntegral.list_ci[0].Annee != null || CopieIntegral.list_ci[0].Annee != "")
                {
                    DoSearch(CopieIntegral.list_ci[0].Num, CopieIntegral.list_ci[0].Annee);
                        CreateIntegralCopie();
                }
                }
            }
            catch(Exception)
            {

            }
        }
        #region Fontions
        public void DoSearch(string num,string year)
        {
            ocon = new SqlDbConnect();
            ocon.SqlQuery("select * from personne where num=@num and anneeAct=@aa");
            ocon.Cmd.Parameters.Add("num", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = num;
            ocon.Cmd.Parameters.Add("aa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = year;

            try
            {
                namewewanttosee.Text = ocon.QueryEx().Rows[0][2].ToString() + " " + ocon.QueryEx().Rows[0][4].ToString();

                


            }
            catch
            {

                if (MessageBox.Show("Personne n'existe pas voulez-vous l'ajouter ?", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    AjoutActe ac = new AjoutActe();
                    ac.Show();
                }
            }

        }

        /**********************************************************************************************/
        public void CreateIntegralCopie()
        {
            if (File.Exists("CI.html"))
            {
                File.Delete("CI.html");
            }
            string jamfr = $"{ocon.QueryEx().Rows[0][12].ToString()}/{ocon.QueryEx().Rows[0][11].ToString()}/{ocon.QueryEx().Rows[0][10].ToString()}";
            string jamar = $"{ocon.QueryEx().Rows[0][21].ToString()}/{ocon.QueryEx().Rows[0][20].ToString()}/{ocon.QueryEx().Rows[0][19].ToString()}";
            string jamarpere = $"{ocon.QueryEx().Rows[0][37].ToString()}/{ocon.QueryEx().Rows[0][36].ToString()}/{ocon.QueryEx().Rows[0][35].ToString()}";
            string jamfrpere = $"{ocon.QueryEx().Rows[0][34].ToString()}/{ocon.QueryEx().Rows[0][33].ToString()}/{ocon.QueryEx().Rows[0][32].ToString()}";
            string jamarMERE = $"{ocon.QueryEx().Rows[0][40].ToString()}/{ocon.QueryEx().Rows[0][39].ToString()}/{ocon.QueryEx().Rows[0][38].ToString()}";
            string jamFRMERE = $"{ocon.QueryEx().Rows[0][43].ToString()}/{ocon.QueryEx().Rows[0][42].ToString()}/{ocon.QueryEx().Rows[0][41].ToString()}";
            string horira= $"{ocon.QueryEx().Rows[0][48].ToString()}/{ocon.QueryEx().Rows[0][47].ToString()}/{ocon.QueryEx().Rows[0][46].ToString()}";
            string horirami= $"{ocon.QueryEx().Rows[0][51].ToString()}/{ocon.QueryEx().Rows[0][50].ToString()}/{ocon.QueryEx().Rows[0][49].ToString()}";

            StreamWriter sw = new StreamWriter("CI.html");
            var x1= new StringBuilder(File.ReadAllText(@"pressCopie.php.htm"));
            #region copieintegral vars
            //variables to make the integrated copy arabic !
            x1.Replace("Var1",ocon.QueryEx().Rows[0][0].ToString() );
            x1.Replace("Var2fr", ocon.QueryEx().Rows[0][2].ToString());
            x1.Replace("Var2ar", ocon.QueryEx().Rows[0][3].ToString());
            x1.Replace("Var3fr", ocon.QueryEx().Rows[0][4].ToString());
            x1.Replace("Var3ar", ocon.QueryEx().Rows[0][5].ToString());
            x1.Replace("varmoisjouranne",jamar );
            x1.Replace("varmoisjourane", jamfr);
            x1.Replace("varcity", ocon.QueryEx().Rows[0][9].ToString());
            x1.Replace("prenomarvar", ocon.QueryEx().Rows[0][5].ToString());
            x1.Replace("prenomfrvar", ocon.QueryEx().Rows[0][4].ToString());
            x1.Replace("sexeAR", ocon.QueryEx().Rows[0][23].ToString());
            x1.Replace("NOMARVAR", ocon.QueryEx().Rows[0][3].ToString());
            x1.Replace("NOMFRVAR", ocon.QueryEx().Rows[0][2].ToString());
            x1.Replace("VARNOMPEREAR", ocon.QueryEx().Rows[0][14].ToString());
            x1.Replace("VARNATIONAAR", ocon.QueryEx().Rows[0][13].ToString());
            x1.Replace("VARBORNAR", ocon.QueryEx().Rows[0][29].ToString());
            x1.Replace("VARHIJRIYAAR", jamarpere);
            x1.Replace("VARMILADIYAAR", jamfrpere);
            x1.Replace("PROFESSIONVARAR", ocon.QueryEx().Rows[0][63].ToString());
            x1.Replace("VARNOMMEREAR", ocon.QueryEx().Rows[0][16].ToString());
            x1.Replace("VARNATIONARMERE", ocon.QueryEx().Rows[0][27].ToString());
            x1.Replace("VRAM", ocon.QueryEx().Rows[0][31].ToString());
            x1.Replace("vmware", jamarMERE);
            x1.Replace("vmawre", jamFRMERE);
            x1.Replace("VARPROFESSION", ocon.QueryEx().Rows[0][65].ToString());
            x1.Replace("VARLIVINGAR", ocon.QueryEx().Rows[0][45].ToString());
            x1.Replace("VARSARAHAAR", ocon.QueryEx().Rows[0][53].ToString());
            x1.Replace("VARHORIRAAR", horirami);
            x1.Replace("VARHORIRAMILADIAR", horira);
            x1.Replace("VAROFFICIERAR", ocon.QueryEx().Rows[0][54].ToString());
            x1.Replace("VAROK", ocon.QueryEx().Rows[0][57].ToString());
            x1.Replace("VARYEARACT", ocon.QueryEx().Rows[0][1].ToString());
            x1.Replace("VARGETDATE", DateTime.Now.ToShortDateString());
            #endregion

            sw.AutoFlush = true;
            sw.Write(x1);
            string curDir = Directory.GetCurrentDirectory();
            curDir = Regex.Replace(curDir, " ", "%20");
            try
            {
               System.Diagnostics.Process.Start("Chrome", String.Format($"file:///{curDir}/CI.html"));

            }
            catch (Exception)
            {
                System.Diagnostics.Process.Start($"file:///{curDir}/CI.html");
            }
             
            /*********************************************************************************************/



        }
        #endregion
    }
}
