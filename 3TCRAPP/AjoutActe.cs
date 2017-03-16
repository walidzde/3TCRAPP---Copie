using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace _3TCRAPP
{
    public partial class AjoutActe : MetroFramework.Forms.MetroForm
    {
        Acte acte_u;
        SqlDbConnect ocon ;
        public AjoutActe()
        {
            InitializeComponent();
        }
        public bool Checkcombos()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            #region Les_comboboxs
            //combo box charge with hijri dates
            int i;
            CBA.Items.Add(0);
            CBAA.Items.Add(0);
            for (i=1918;i<=2000;i++)
            {
                CBA.Items.Add(i);
            }
            for (i=1330; i<1440; i++)
            {
                CBAA.Items.Add(i);
            }
            //add days to both combo boxes !
            for(i=0;i<=31;i++)
            {
                CBJ.Items.Add(i);
                if(i<=30)
                {
                    CBAJ.Items.Add(i);
                }
                if(i<=12)
                {
                    CBM.Items.Add(i);
                    CBAM.Items.Add(i);
                }
            }
            
            //Me.ComboBox1.SelectedIndex = 0
            //to show the first hijri 
            CBAA.SelectedIndex = 0;
            CBM.SelectedIndex = 0;
            CBA.SelectedIndex = 0;
            CBAM.SelectedIndex = 0;
            CBAJ.SelectedIndex = 0;
            CBJ.SelectedIndex = 0;
            #endregion Les_comboboxs
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            acte_u = new Acte();
            if (Checkcombos() == true)
            {

                ocon = new SqlDbConnect();
                ocon.SqlQuery
                    ("insert into personne(num,anneeAct,nom,nomAr,prenom,preAr,nationnalite,nationAr,lieuNaiss,lieuNaissAr,jour,mois,annee,pere,pereAr,mere,mereAr,deces,decesAr,jourh,moish,anneeh) values(@num,@anneeAct,@nom,@nomAr,@prenom,@preAr,@nationnalite,@nationAr,@lieuNaiss,@lieuNaissAr,@jour,@mois,@annee,@pere,@pereAr,@mere,@mereAr,@deces,@decesAr,@jourH,@moisH,@anneeH)");
                #region ajout_des_parametres 
                ocon.Cmd.Parameters.Add("num", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tnum.Text.ToUpper();
                ocon.Cmd.Parameters.Add("anneeAct", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tdate.Text.ToUpper();
                ocon.Cmd.Parameters.Add("nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tnom.Text.ToUpper();
                ocon.Cmd.Parameters.Add("nomAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = TnomAr.Text;
                ocon.Cmd.Parameters.Add("prenom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tprn.Text.ToUpper();
                ocon.Cmd.Parameters.Add("preAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tprnar.Text;
                ocon.Cmd.Parameters.Add("nationnalite", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tnatio.Text.ToUpper();
                ocon.Cmd.Parameters.Add("nationAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = TnatioAr.Text;
                ocon.Cmd.Parameters.Add("lieuNaiss", MySql.Data.MySqlClient.MySqlDbType.VarString).Value = textBox2.Text.ToUpper();
                ocon.Cmd.Parameters.Add("lieuNaissAr", MySql.Data.MySqlClient.MySqlDbType.VarString).Value = textBox1.Text;
                ocon.Cmd.Parameters.Add("jour", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = (int)CBJ.SelectedItem;
                ocon.Cmd.Parameters.Add("mois", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = (int)CBM.SelectedItem;
                ocon.Cmd.Parameters.Add("annee", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = (int)CBA.SelectedItem;
                ocon.Cmd.Parameters.Add("pere", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tperefr.Text.ToUpper();
                ocon.Cmd.Parameters.Add("pereAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tperear.Text.ToUpper();
                ocon.Cmd.Parameters.Add("mere", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tmerefr.Text.ToUpper();
                ocon.Cmd.Parameters.Add("mereAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tmerear.Text.ToUpper();
                ocon.Cmd.Parameters.Add("deces", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = decesfr.Text.ToUpper();
                ocon.Cmd.Parameters.Add("decesAr", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = decesar.Text.ToUpper();
                ocon.Cmd.Parameters.Add("jourH", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = (int)CBAJ.SelectedItem;
                ocon.Cmd.Parameters.Add("moisH", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = (int)CBAM.SelectedItem;
                ocon.Cmd.Parameters.Add("anneeH", MySql.Data.MySqlClient.MySqlDbType.UInt64).Value = (int)CBAA.SelectedItem;
                #endregion ajout_des_parametres
            /*    acte_u.Num = Tnum.Text.ToUpper();
                acte_u.AnneeAct = Tdate.Text.ToUpper();
                acte_u.Nom = Tnom.Text.ToUpper();
                acte_u.NomAr = TnomAr.Text;
                acte_u.Prenom = Tprn.Text.ToUpper();
                acte_u.PreAr = Tprnar.Text;
                acte_u.Nationnalite = Tnatio.Text.ToUpper();
                acte_u.NationAr = TnatioAr.Text;
                acte_u.LieuNaiss = textBox2.Text.ToUpper();
                acte_u.LieuNaissAr = textBox1.Text;
                acte_u.Jour = CBJ.SelectedItem.ToString();
                acte_u.Mois = CBM.SelectedItem.ToString();
                acte_u.Annee =CBA.SelectedItem.ToString();
                acte_u.Pere = tperefr.Text.ToUpper();
                acte_u.PereAr = Tperear.Text.ToUpper();
                acte_u.Mere =tmerefr.Text.ToUpper();
                acte_u.MereAr = tmerear.Text.ToUpper();
                acte_u.Deces =decesfr.Text.ToUpper();
                acte_u.DecesAr = decesar.Text.ToUpper();
                acte_u.JourH = CBAJ.SelectedItem.ToString();
                acte_u.MoisH = CBAM.SelectedItem.ToString();
                acte_u.AnneeH = CBAA.SelectedItem.ToString();
                Acte.list_act.Add(acte_u);
       
                //ajout des parametres pour echaper sql injection!*/
                ocon.NonQueryEx();
                MessageBox.Show("لقد تمت الإضافة بنجاح ");
                clearall();

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {

                if (t.Text != "")
                {
                    t.Text = "";
                }

            }
            foreach(ComboBox C in this.Controls.OfType<ComboBox>())
            {
               C.SelectedIndex=0 ;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + CBJ.SelectedValue.ToString());
        }

        private void txtfocus(object sender, EventArgs e)
        {
          /*  System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("fr-FR");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void TnatioAr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tnatio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void CBAA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBAJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void decesar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmerear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tperear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tprnar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TnomAr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void decesfr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmerefr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tperefr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tprn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
