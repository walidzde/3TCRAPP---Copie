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
    public partial class Copie_Integral_Form : MetroFramework.Forms.MetroForm
    {
        string numact;
        string year;
        public Copie_Integral_Form()
        {
            InitializeComponent();
        }
        SqlDbConnect ocon;
        SqlDbConnect majcon;
        public void filltext()
        {
            #region fillingtextboxesissoannoying !
            //remplit tous les champs avec ce qui corrependre de la abse !
            comboBox1.Text = ocon.QueryEx().Rows[0][23].ToString();
            //nationalite pere
            tnatiofrpr.Text = ocon.QueryEx().Rows[0][24].ToString();
            tnatioarpr.Text = ocon.QueryEx().Rows[0][25].ToString();
            //nationalité mere
            tnatiofrmr.Text = ocon.QueryEx().Rows[0][26].ToString();
            tnatioarmr.Text = ocon.QueryEx().Rows[0][27].ToString();
            //naissance pere
            tnaissperefr.Text = ocon.QueryEx().Rows[0][28].ToString();
            Tnaisperear.Text = ocon.QueryEx().Rows[0][29].ToString();
            //naissance mere
            tnaissmerefrr.Text = ocon.QueryEx().Rows[0][30].ToString();
            tnaismerear.Text = ocon.QueryEx().Rows[0][31].ToString();
            //date de naissance pere
            cbdayfrpr.Text = ocon.QueryEx().Rows[0][32].ToString();
            cpmonthprfr.Text = ocon.QueryEx().Rows[0][33].ToString();
            cbyearfrpr.Text = ocon.QueryEx().Rows[0][34].ToString();
            cbdayarpr.Text = ocon.QueryEx().Rows[0][35].ToString();
            cbmontharpr.Text = ocon.QueryEx().Rows[0][36].ToString();
            cbyeararpr.Text = ocon.QueryEx().Rows[0][37].ToString();
            //date de naissance mere
            //almost half way there
            cbdayfrmr.Text = ocon.QueryEx().Rows[0][38].ToString();
            cbmonthfrmr.Text = ocon.QueryEx().Rows[0][39].ToString();
            cbyearfrmr.Text = ocon.QueryEx().Rows[0][40].ToString();
            cbdayarmr.Text = ocon.QueryEx().Rows[0][41].ToString();
            cbmontharmr.Text = ocon.QueryEx().Rows[0][42].ToString();
            cbyeararmr.Text = ocon.QueryEx().Rows[0][43].ToString();
            //domicile
            residencefr.Text = ocon.QueryEx().Rows[0][44].ToString();
            residencear.Text = ocon.QueryEx().Rows[0][45].ToString();
            //dressé le 
            cbjour1.Text = ocon.QueryEx().Rows[0][46].ToString();
            cbmois1.Text = ocon.QueryEx().Rows[0][47].ToString();
            cbyear1.Text = ocon.QueryEx().Rows[0][48].ToString();
            cbdayhorira.Text = ocon.QueryEx().Rows[0][49].ToString();
            cbmonthhorira.Text = ocon.QueryEx().Rows[0][50].ToString();
            cbyearhorira.Text = ocon.QueryEx().Rows[0][51].ToString();
            //
            declarationparfr.Text = ocon.QueryEx().Rows[0][52].ToString();
            declarationparar.Text = ocon.QueryEx().Rows[0][53].ToString();
            //faite par
            parnousfr.Text = ocon.QueryEx().Rows[0][54].ToString();
            parnousar.Text = ocon.QueryEx().Rows[0][55].ToString();
            //etat civil
            officierfr.Text = ocon.QueryEx().Rows[0][56].ToString();
            officierar.Text = ocon.QueryEx().Rows[0][57].ToString();
            //
            professionfrpr.Text = ocon.QueryEx().Rows[0][62].ToString();
            professionarpr.Text = ocon.QueryEx().Rows[0][63].ToString();
            professionfrmr.Text = ocon.QueryEx().Rows[0][64].ToString();
            professionaarmr.Text = ocon.QueryEx().Rows[0][65].ToString();
            hamfr.Text = ocon.QueryEx().Rows[0][66].ToString();
            hamar.Text = ocon.QueryEx().Rows[0][67].ToString();

            #endregion
        }
        private void mbsearch_Click(object sender, EventArgs e)
        {
            CopieIntegral.list_ci.Clear();
            ocon = new SqlDbConnect();
            ocon.SqlQuery("select * from personne where num=@num and anneeAct=@aa");
            ocon.Cmd.Parameters.Add("num", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tnumact.Text;
            ocon.Cmd.Parameters.Add("aa", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = tyear.Text;
            numact= tnumact.Text;
            year= tyear.Text;
            CopieIntegral c = new CopieIntegral();
            c.AnneeAct = year;
            c.Num = numact;
            CopieIntegral.list_ci.Add(c);
            try
            {
                namewewanttosee.Text=ocon.QueryEx().Rows[0][2].ToString()+" "+ ocon.QueryEx().Rows[0][4].ToString();
                filltext();
                
                
            }
            catch
            {
                
                if(MessageBox.Show("Personne n'existe pas voulez-vous l'ajouter ?", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error)==DialogResult.Yes)
                { AjoutActe ac = new AjoutActe();
                    ac.Show();
                }
            }
            
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bajout_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
            if (comboBox1.Text == "") { errorProvider1.SetError(comboBox1, "a Remplir"); }
            else
            {
                try
                {
                    majcon = new SqlDbConnect();
                    majcon.SqlQuery("update personne set sexe=@sexe, sexeAr=@sexeAr, nationPere=@nationPere, nationPereAr=@nationPereAr, nationMere=@nationMere, nationMereAr=@nationMereAr, lieuPere=@lieuPere, lieuPereAr=@lieuPereAr, lieuMere=@lieuMere, lieuMereAr=@lieuMereAr, jourPere=@jourPere, moisPere=@moisPere, anneePere=@anneePere, jourHP=@jourHP, moisHP=@moisHP, anneeHP=@anneeHP, jourM=@jourM, moisM=@moisM, anneeM=@anneeM, jourHM=@jourHM, moisHM=@moisHM, anneeHM=@anneeHM, domicile=@domicile, domicileAr=@domicileAr, jourDr=@jourDr, moisDr=@moisDr, anneeDr=@anneeDr, jourHD=@jourHD, moisHD=@moisHD, anneeHD=@anneeHD, faitePar=@faitePar, faiteAr=@faiteAr, signe=@signe, signeAr=@signeAr, officier=@officier, officierAr=@officierAr, professionP=@professionP, professionPAr=@professionPAr, professionM=@professionM, professionMAr=@professionMAr, ham=@ham, hamAr=@hamAr where num=@num and anneeAct=@anneeAct");
                    
                    /**/
                    #region parametres_du_requetes!  
                    string sexe;
                    if (comboBox1.Text == "ذكر") { sexe = "masculin"; } else { sexe = "feminin"; }
                    majcon.Cmd.Parameters.Add("sexe", MySqlDbType.VarChar).Value =sexe;
                    majcon.Cmd.Parameters.Add("sexeAr", MySqlDbType.VarChar).Value =comboBox1.Text;
                    majcon.Cmd.Parameters.Add("nationPere", MySqlDbType.VarChar).Value =tnatiofrpr.Text;
                    majcon.Cmd.Parameters.Add("nationPereAr", MySqlDbType.VarChar).Value =tnatioarpr.Text;
                    majcon.Cmd.Parameters.Add("nationMere", MySqlDbType.VarChar).Value =tnatiofrmr.Text;
                    majcon.Cmd.Parameters.Add("nationMereAr", MySqlDbType.VarChar).Value =tnatioarmr.Text;
                    majcon.Cmd.Parameters.Add("lieuPere", MySqlDbType.VarChar).Value =tnaissperefr.Text;
                    majcon.Cmd.Parameters.Add("lieuPereAr", MySqlDbType.VarChar).Value =Tnaisperear.Text;
                    majcon.Cmd.Parameters.Add("lieuMere", MySqlDbType.VarChar).Value =tnaissmerefrr.Text;
                    majcon.Cmd.Parameters.Add("lieuMereAr", MySqlDbType.VarChar).Value = tnaismerear.Text;
                    majcon.Cmd.Parameters.Add("jourPere", MySqlDbType.VarChar).Value =cbdayfrpr.Text;
                    majcon.Cmd.Parameters.Add("moisPere", MySqlDbType.VarChar).Value =cpmonthprfr.Text;
                    majcon.Cmd.Parameters.Add("anneePere", MySqlDbType.VarChar).Value =cbyearfrpr.Text;
                    majcon.Cmd.Parameters.Add("jourHP", MySqlDbType.VarChar).Value =cbdayarpr.Text;
                    majcon.Cmd.Parameters.Add("moisHP", MySqlDbType.VarChar).Value =cbmontharpr.Text;
                    majcon.Cmd.Parameters.Add("anneeHP", MySqlDbType.VarChar).Value =cbyeararpr.Text;
                    //professionP = @professionP, professionPAr = @professionPAr, professionM = @professionM, professionMAr = @professionMAr, ham = @ham, hamAr = @hamAr where num = @num anneeAct = @anneeAct*/
                    majcon.Cmd.Parameters.Add("jourM", MySqlDbType.VarChar).Value =cbdayfrmr.Text;
                    majcon.Cmd.Parameters.Add("moisM", MySqlDbType.VarChar).Value =cbmonthfrmr.Text;
                    majcon.Cmd.Parameters.Add("anneeM", MySqlDbType.VarChar).Value =cbyearfrmr.Text;
                    majcon.Cmd.Parameters.Add("jourHM", MySqlDbType.VarChar).Value =cbdayarmr.Text;
                    majcon.Cmd.Parameters.Add("moisHM", MySqlDbType.VarChar).Value =cbmontharmr.Text;
                    majcon.Cmd.Parameters.Add("anneeHM", MySqlDbType.VarChar).Value =cbyearfrmr.Text;
                    majcon.Cmd.Parameters.Add("domicile", MySqlDbType.VarChar).Value =residencefr.Text;
                    majcon.Cmd.Parameters.Add("domicileAr", MySqlDbType.VarChar).Value =residencear.Text;
                    majcon.Cmd.Parameters.Add("jourDr", MySqlDbType.VarChar).Value =cbjour1.Text;
                    majcon.Cmd.Parameters.Add("moisDr", MySqlDbType.VarChar).Value =cbmois1.Text;
                    majcon.Cmd.Parameters.Add("anneeDr", MySqlDbType.VarChar).Value =cbyear1.Text;
                    majcon.Cmd.Parameters.Add("jourHD", MySqlDbType.VarChar).Value =cbdayhorira.Text;
                    majcon.Cmd.Parameters.Add("moisHD", MySqlDbType.VarChar).Value =cbmonthhorira.Text;
                    majcon.Cmd.Parameters.Add("anneeHD", MySqlDbType.VarChar).Value =cbyearhorira.Text;
                    majcon.Cmd.Parameters.Add("faitePar", MySqlDbType.VarChar).Value = declarationparfr.Text ;
                    majcon.Cmd.Parameters.Add("faiteAr", MySqlDbType.VarChar).Value =declarationparar.Text;
                    majcon.Cmd.Parameters.Add("signe", MySqlDbType.VarChar).Value =parnousfr.Text;
                    majcon.Cmd.Parameters.Add("signeAr", MySqlDbType.VarChar).Value =parnousar.Text;
                    majcon.Cmd.Parameters.Add("officier", MySqlDbType.VarChar).Value =officierfr.Text;
                    majcon.Cmd.Parameters.Add("officierAr", MySqlDbType.VarChar).Value =officierar.Text;
                    majcon.Cmd.Parameters.Add("professionP", MySqlDbType.VarChar).Value =professionfrpr.Text;
                    majcon.Cmd.Parameters.Add("professionPAr", MySqlDbType.VarChar).Value =professionarpr.Text;
                    majcon.Cmd.Parameters.Add("professionM", MySqlDbType.VarChar).Value =professionfrmr.Text;
                    majcon.Cmd.Parameters.Add("professionMAr", MySqlDbType.VarChar).Value =professionaarmr.Text;
                    majcon.Cmd.Parameters.Add("ham", MySqlDbType.VarChar).Value =hamfr.Text;
                    majcon.Cmd.Parameters.Add("hamAr", MySqlDbType.VarChar).Value =hamfr.Text;
                    majcon.Cmd.Parameters.Add("num", MySqlDbType.VarChar).Value =tnumact.Text;
                    majcon.Cmd.Parameters.Add("anneeAct", MySqlDbType.VarChar).Value =tyear.Text;
                    //fkn finally 1:11 morning 18/03
                    majcon.NonQueryEx();




                    #endregion
                    MessageBox.Show("لقد تم التعديل بنجاح !");
                    if ((MessageBox.Show("هل تريد طباعة النسخة الكاملة ؟", "نافدة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            //add code to the print form and variables so that when we open it it will contain this shiiiiiiiiiiiiiit :D
                        }


                }
                catch (Exception)
                {

                    MessageBox.Show("Erreur");
                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tnumact_TextChanged(object sender, EventArgs e)
        {

        }

        private void tyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copie_Integral_Form_Load(object sender, EventArgs e)
        {
            /**/
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (TextBox s in Controls.OfType<TextBox>())
            {
                s.Text = "";

            }
            foreach (var s in Controls.OfType<ComboBox>())
            {
                s.Text = "";
            }
        }
    }
}
