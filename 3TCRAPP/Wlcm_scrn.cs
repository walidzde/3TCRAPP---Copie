using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Media;

namespace _3TCRAPP
{
    public partial class Wlcm_scrn : MetroForm
    {
        SqlDbConnect ocon=new SqlDbConnect();
        public Wlcm_scrn()
        {
            InitializeComponent();
        }

        private void Wlcm_scrn_Load(object sender, EventArgs e)
        {

            if (ocon.connectionstateftw() == true)
            {
                metroLabel1.Text = $"{ DateTime.Now.Date.ToShortDateString()} Online";
            }
            else
            {
                metroLabel1.Text = $"{DateTime.Now.Date.ToShortDateString()} Offline please start the MySql server!";
            }
            
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
            AjoutActe add = new AjoutActe();
            add.Show();
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            PrintForm pf = new PrintForm();
            pf.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            RecherchActe search = new RecherchActe();
            search.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            ModifyAct MC = new ModifyAct();
            MC.Show();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            Copie_Integral_Form cif = new Copie_Integral_Form();
            cif.Show();
        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            printformCI pci = new printformCI();
            pci.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {

        }
    }
}
