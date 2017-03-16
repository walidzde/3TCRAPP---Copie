using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _3TCRAPP
{
    public partial class RecherchActe : MetroFramework.Forms.MetroForm
    {
        SqlDbConnect ocon;
        SqlDbConnect ocon1;
        public RecherchActe()
        {
            InitializeComponent();
        }
        //to Hide all when you open the form
        private void RecherchActe_Load(object sender, EventArgs e)
        {
            
            Tname.Hide();
            Tyear.Hide();

        }
        //to make box appear for the name
        private void RBname_CheckedChanged(object sender, EventArgs e)
        {
            if (RBname.Checked)
            {
                Tyear.Hide();
                textBox1.Hide();
                Tname.Show();
            }
        }
        //to make textbox appear for Number and Date
        private void RBnum_CheckedChanged(object sender, EventArgs e)
        {
            if (RBnum.Checked)
            {
                Tname.Hide();
                textBox1.Show();
                Tyear.Show();
            }
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //we need to show an error if user keeps txt box empty
            //this one for the name
            ocon1 = new SqlDbConnect();
            ocon = new SqlDbConnect();
            if (RBname.Checked && Tname.Text != "")
            {
                errorProvider1.Clear();


                //continue the aliasses for tomorrow , 25/02/2017
                ocon1.SqlQuery("select num AS `رقم العقد`,anneeAct AS `السنة`,nom AS `Nom`,nomAr AS `الاسم العائلي`,prenom AS `Prenom`,preAr AS `الاسم الشخصي`,nationnalite AS `Nationalité`,nationAr AS `الجنسية`,lieuNaiss,lieuNaissAr,jour,mois,annee,pere,pereAr,mere,mereAr,deces,decesAr,jourH,moisH,anneeH from personne WHERE nom like @nom ");
                ocon1.Cmd.Parameters.Add("nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = '%' + Tname.Text.ToUpper() + '%';
                dataGridView1.DataSource = ocon1.QueryEx();
            }
            else
            {
                errorProvider1.SetError(Tname, "المرجوا ملء الإسم قبل البحث");
            }


            //this one for year and number , this one is specific so we use = instead of like
            if (RBnum.Checked && Tyear.Text != "" && textBox1.Text != "")
            {
                errorProvider1.Clear();


                //dont forget to add them here as well dude ! I LOVE YOU , You from the past 
                ocon.SqlQuery("select num,anneeAct,nom,nomAr,prenom,preAr,nationnalite,nationAr,lieuNaiss,lieuNaissAr,jour,mois,annee,pere,pereAr,mere,mereAr,deces,decesAr,jourH,moisH,anneeH from personne WHERE num=@num AND anneeAct=@anneeAct ");
                ocon.Cmd.Parameters.Add("num", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = textBox1.Text;
                ocon.Cmd.Parameters.Add("anneeAct", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Tyear.Text;
                dataGridView1.DataSource = ocon.QueryEx();
            }
            else
            {
                errorProvider1.SetError(Tyear, "المرجوا ملء الخانة قبل البحث");
                errorProvider1.SetError(textBox1, "المرجوا ملء الخانة قبل البحث");
            }

            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

