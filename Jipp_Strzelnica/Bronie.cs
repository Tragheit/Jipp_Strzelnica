using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jipp_Strzelnica
{
    public partial class Bronie : UserControl
    {
        public Bronie()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void panel1_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities()) {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 1);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }


        private void panel2_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 2);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }
        private void panel3_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 3);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }
        private void panel4_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 4);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }
        private void panel5_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 5);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }
        private void panel6_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 6);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }
        private void panel7_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 7);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }
        private void panel8_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 8);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };
        }
        private void panel9_click(object sender, EventArgs e)
        {
            Bron_popup bronPopup = new Bron_popup();
            bronPopup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Bron bron = jippProjEntities.Opis_Bron.Single(a => a.Id == 9);

                bronPopup.BPlab1.Text = bron.Producent;
                bronPopup.BPlab2.Text = bron.Model;
                bronPopup.BPlab3.Text = bron.Typ;
                bronPopup.BPlab4.Text = bron.Kaliber;
                bronPopup.BPlab5.Text = bron.Opis;
            };

        }





    }
}
