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
    public partial class Stanowiska : UserControl
    {
        public Stanowiska()
        {
            InitializeComponent();
        }

        private void panel1_click(object sender, EventArgs e)
        {
            Stanowiska_popup stanowiska_Popup = new Stanowiska_popup();
            stanowiska_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Stanowiska stanowiska = jippProjEntities.Opis_Stanowiska.Single(a => a.ID == 1);

                stanowiska_Popup.SPlab1.Text = stanowiska.Kulochwyt;
                stanowiska_Popup.SPlab2.Text = stanowiska.Odleglosc_tarcz.ToString();
                stanowiska_Popup.SPlab3.Text = stanowiska.Opis;
            };
        }

        private void panel2_click(object sender, EventArgs e)
        {
            Stanowiska_popup stanowiska_Popup = new Stanowiska_popup();
            stanowiska_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Stanowiska stanowiska = jippProjEntities.Opis_Stanowiska.Single(a => a.ID == 2);

                stanowiska_Popup.SPlab1.Text = stanowiska.Kulochwyt;
                stanowiska_Popup.SPlab2.Text = stanowiska.Odleglosc_tarcz.ToString();
                stanowiska_Popup.SPlab3.Text = stanowiska.Opis;
            };
        }

        private void panel3_click(object sender, EventArgs e)
        {
            Stanowiska_popup stanowiska_Popup = new Stanowiska_popup();
            stanowiska_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Stanowiska stanowiska = jippProjEntities.Opis_Stanowiska.Single(a => a.ID == 3);

                stanowiska_Popup.SPlab1.Text = stanowiska.Kulochwyt;
                stanowiska_Popup.SPlab2.Text = stanowiska.Odleglosc_tarcz.ToString();
                stanowiska_Popup.SPlab3.Text = stanowiska.Opis;
            };
        }

        private void panel4_click(object sender, EventArgs e)
        {
            Stanowiska_popup stanowiska_Popup = new Stanowiska_popup();
            stanowiska_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Stanowiska stanowiska = jippProjEntities.Opis_Stanowiska.Single(a => a.ID == 4);

                stanowiska_Popup.SPlab1.Text = stanowiska.Kulochwyt;
                stanowiska_Popup.SPlab2.Text = stanowiska.Odleglosc_tarcz.ToString();
                stanowiska_Popup.SPlab3.Text = stanowiska.Opis;
            };
        }

        private void panel5_click(object sender, EventArgs e)
        {
            Stanowiska_popup stanowiska_Popup = new Stanowiska_popup();
            stanowiska_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Stanowiska stanowiska = jippProjEntities.Opis_Stanowiska.Single(a => a.ID == 5);

                stanowiska_Popup.SPlab1.Text = stanowiska.Kulochwyt;
                stanowiska_Popup.SPlab2.Text = stanowiska.Odleglosc_tarcz.ToString();
                stanowiska_Popup.SPlab3.Text = stanowiska.Opis;
            };
        }

    }
}
