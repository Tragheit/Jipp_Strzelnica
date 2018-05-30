using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jipp_Strzelnica
{
    public partial class Trener_popup : Form
    {
        public Trener_popup()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Exit_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
