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
    public partial class Trenerzy : UserControl
    {
        public Trenerzy()
        {
            InitializeComponent();
        }

        private void panel1_click(object sender, EventArgs e)
        {
            Trener_popup trener_Popup = new Trener_popup();
            trener_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Trenerzy trener = jippProjEntities.Opis_Trenerzy.Single(a => a.ID == 1);

                trener_Popup.TPlab1.Text = trener.Imie;
                trener_Popup.TPlab2.Text = trener.Nazwisko;
                trener_Popup.TPlab3.Text = trener.Opis;
            };
        }

        private void panel2_click(object sender, EventArgs e)
        {
            Trener_popup trener_Popup = new Trener_popup();
            trener_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Trenerzy trener = jippProjEntities.Opis_Trenerzy.Single(a => a.ID == 2);

                trener_Popup.TPlab1.Text = trener.Imie;
                trener_Popup.TPlab2.Text = trener.Nazwisko;
                trener_Popup.TPlab3.Text = trener.Opis;
            };
        }

        private void panel3_click(object sender, EventArgs e)
        {
            Trener_popup trener_Popup = new Trener_popup();
            trener_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Trenerzy trener = jippProjEntities.Opis_Trenerzy.Single(a => a.ID == 3);

                trener_Popup.TPlab1.Text = trener.Imie;
                trener_Popup.TPlab2.Text = trener.Nazwisko;
                trener_Popup.TPlab3.Text = trener.Opis;
            };
        }

        private void panel4_click(object sender, EventArgs e)
        {
            Trener_popup trener_Popup = new Trener_popup();
            trener_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Trenerzy trener = jippProjEntities.Opis_Trenerzy.Single(a => a.ID == 4);

                trener_Popup.TPlab1.Text = trener.Imie;
                trener_Popup.TPlab2.Text = trener.Nazwisko;
                trener_Popup.TPlab3.Text = trener.Opis;
            };
        }

        private void panel5_click(object sender, EventArgs e)
        {
            Trener_popup trener_Popup = new Trener_popup();
            trener_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Trenerzy trener = jippProjEntities.Opis_Trenerzy.Single(a => a.ID == 5);

                trener_Popup.TPlab1.Text = trener.Imie;
                trener_Popup.TPlab2.Text = trener.Nazwisko;
                trener_Popup.TPlab3.Text = trener.Opis;
            };
        }

        private void panel6_click(object sender, EventArgs e)
        {
            Trener_popup trener_Popup = new Trener_popup();
            trener_Popup.Show();

            using (JippProjEntities jippProjEntities = new JippProjEntities())
            {

                Opis_Trenerzy trener = jippProjEntities.Opis_Trenerzy.Single(a => a.ID == 6);

                trener_Popup.TPlab1.Text = trener.Imie;
                trener_Popup.TPlab2.Text = trener.Nazwisko;
                trener_Popup.TPlab3.Text = trener.Opis;
            };
        }
    }
}
