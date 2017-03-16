using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _3TCRAPP
{
    public partial class ModifyAct : MetroFramework.Forms.MetroForm
    {
        //Variable global in this form 
        SqlDbConnect ocon;
        public ModifyAct()
        {
            InitializeComponent();
        }

        private void ModifyAct_Load(object sender, EventArgs e)
        {

        }

        private void Tdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            clearall();
        }
        public void clearall()
        {
            {
                foreach (TextBox t in this.Controls.OfType<TextBox>())
                {

                    if (t.Text != "")
                    {
                        t.Text = "";
                    }

                }
                foreach (ComboBox C in this.Controls.OfType<ComboBox>())
                {
                    C.SelectedIndex = 0;
                }
            }
        }

        private void Bsearch_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(Tnum.Text=="" || Tdate.Text=="")
            {
                errorProvider1.SetError(Tnum, "المرجو تعبئة الخانتين");
            }
            else
            {
                search(Tnum.Text, Tdate.Text);
                filltext();
            }
        }
        //search fonction we give the num and date
        public void search(string num,string date)
        {
            if(date!="" && num !="")
            {
                ocon = new SqlDbConnect();
                ocon.SqlQuery("select * from personne where num=@num and anneeAct=@annee");
                ocon.Cmd.Parameters.Add("num", MySqlDbType.VarChar).Value = num;
                ocon.Cmd.Parameters.Add("annee", MySqlDbType.VarChar).Value = date;
            }
        }
        //to fill the textboxes with the connection values
        public void filltext()
        {
            if(ocon.QueryEx().Rows.Count!=0)
            {
                Tnom.Text=(string)ocon.QueryEx().Rows[0][2];
                //this are the new ones to test right now !!!! update: they work
                TnomAr.Text=(string)ocon.QueryEx().Rows[0][3];
                Tprn.Text=(string)ocon.QueryEx().Rows[0][4];
                Tprnar.Text=(string)ocon.QueryEx().Rows[0][5];
                Tnatio.Text=(string)ocon.QueryEx().Rows[0][6];
                TnatioAr.Text=(string)ocon.QueryEx().Rows[0][7];
                textBox2.Text=(string)ocon.QueryEx().Rows[0][8];
                textBox1.Text=(string)ocon.QueryEx().Rows[0][9];
                tjf.Text=(ocon.QueryEx().Rows[0][10]).ToString();
                tmf.Text= ocon.QueryEx().Rows[0][11].ToString();
                taf.Text= ocon.QueryEx().Rows[0][12].ToString();
                tperefr.Text=(string)ocon.QueryEx().Rows[0][13];
                Tperear.Text=(string)ocon.QueryEx().Rows[0][14];
                tmerefr.Text=(string)ocon.QueryEx().Rows[0][15];
                tmerear.Text=(string)ocon.QueryEx().Rows[0][16];
                decesfr.Text=(string)ocon.QueryEx().Rows[0][17];
                decesar.Text=(string)ocon.QueryEx().Rows[0][18];
                tja.Text=ocon.QueryEx().Rows[0][19].ToString();
                tma.Text=ocon.QueryEx().Rows[0][20].ToString();
                taa.Text=ocon.QueryEx().Rows[0][21].ToString();
                 
                 
            }
            else
            {
                MessageBox.Show("هذا الشخص لا يتواجد في قاعدة البياناة المرجو إضافاته من نافدة الإضافة", "خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Bupdate_Click(object sender, EventArgs e)
        {
            if(checkclearall()==true)
            {
                ocon = new SqlDbConnect();
                //100 mb ram needed
                    ocon.SqlQuery
                    ("update personne set nom=@nom,nomAr=@nomAr,prenom=@prenom,preAr=@preAr,nationnalite=@nationnalite,nationAr=@nationAr,lieuNaiss=@lieuNaiss,lieuNaissAr=@lieuNaissAr,jour=@jour,mois=@mois,annee=@annee,pere=@pere,pereAr=@pereAr,mere=@mere,mereAr=@mereAr,deces=@deces,decesAr=@decesAr,jourH=@jourH,moisH=@moisH,anneeH=@anneeH where num=@num and anneeAct=@anneeAct");
                #region ajout_des_parametres 
                ocon.Cmd.Parameters.Add("num", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tnum.Text.ToUpper();
                ocon.Cmd.Parameters.Add("anneeAct", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tdate.Text.ToUpper();
                ocon.Cmd.Parameters.Add("nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tnom.Text.ToUpper();
                ocon.Cmd.Parameters.Add("nomAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = TnomAr.Text;
                ocon.Cmd.Parameters.Add("prenom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tprn.Text.ToUpper();
                ocon.Cmd.Parameters.Add("preAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tprnar.Text;
                ocon.Cmd.Parameters.Add("nationnalite", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tnatio.Text;
                ocon.Cmd.Parameters.Add("nationAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = TnatioAr.Text;
                ocon.Cmd.Parameters.Add("lieuNaiss", MySql.Data.MySqlClient.MySqlDbType.VarString).Value = textBox2.Text;
                ocon.Cmd.Parameters.Add("lieuNaissAr", MySql.Data.MySqlClient.MySqlDbType.VarString).Value = textBox1.Text;
                ocon.Cmd.Parameters.Add("jour", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = int.Parse(tjf.Text);
                ocon.Cmd.Parameters.Add("mois", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = int.Parse(tmf.Text);
                ocon.Cmd.Parameters.Add("annee", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = int.Parse(taf.Text);
                ocon.Cmd.Parameters.Add("pere", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tperefr.Text;
                ocon.Cmd.Parameters.Add("pereAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tperear.Text;
                ocon.Cmd.Parameters.Add("mere", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tmerefr.Text;
                ocon.Cmd.Parameters.Add("mereAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tmerear.Text;
                ocon.Cmd.Parameters.Add("deces", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = decesfr.Text;
                ocon.Cmd.Parameters.Add("decesAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = decesar.Text;
                ocon.Cmd.Parameters.Add("jourH", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = int.Parse(tja.Text);
                ocon.Cmd.Parameters.Add("moisH", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = int.Parse(tma.Text);
                ocon.Cmd.Parameters.Add("anneeH", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = int.Parse(taa.Text);
                #endregion ajout_des_parametres
                ocon.NonQueryEx();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }
        public bool checkclearall()
        {
            errorProvider1.Clear();

            bool result = true;
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {

                if (t.Text == "")
                {
                    result = false;
                    errorProvider1.SetError(t, "المرجو ملء جميع الخانات");
                }

            }
            return result;
        }
    }
}
