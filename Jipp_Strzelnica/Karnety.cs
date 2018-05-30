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
    public partial class Karnety : UserControl
    {
        public Karnety()
        {
            InitializeComponent();
        }

        private void panel1_click(object sender, EventArgs e)
        {
            Karnet_popup karnet_Popup = new Karnet_popup();
            karnet_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Karnety karnet = jippProjEntities.Opis_Karnety.Single(a => a.ID == 1);

                karnet_Popup.KPlab2.Text = karnet.Ulga;
                karnet_Popup.KPlab3.Text = karnet.Opis;
            };
        }

        private void panel2_click(object sender, EventArgs e)
        {
            Karnet_popup karnet_Popup = new Karnet_popup();
            karnet_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Karnety karnet = jippProjEntities.Opis_Karnety.Single(a => a.ID == 2);

                karnet_Popup.KPlab2.Text = karnet.Ulga;
                karnet_Popup.KPlab3.Text = karnet.Opis;
            };
        }

        private void panel3_click(object sender, EventArgs e)
        {
            Karnet_popup karnet_Popup = new Karnet_popup();
            karnet_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Karnety karnet = jippProjEntities.Opis_Karnety.Single(a => a.ID == 3);

                karnet_Popup.KPlab2.Text = karnet.Ulga;
                karnet_Popup.KPlab3.Text = karnet.Opis;
            };
        }

        private void panel4_click(object sender, EventArgs e)
        {
            Karnet_popup karnet_Popup = new Karnet_popup();
            karnet_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Karnety karnet = jippProjEntities.Opis_Karnety.Single(a => a.ID == 4);

                karnet_Popup.KPlab2.Text = karnet.Ulga;
                karnet_Popup.KPlab3.Text = karnet.Opis;
            };
        }
    }
}
