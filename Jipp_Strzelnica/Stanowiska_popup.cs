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
    public partial class Stanowiska_popup : Form
    {
        public Stanowiska_popup()
        {
            InitializeComponent();
        }

        private void Exit_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
