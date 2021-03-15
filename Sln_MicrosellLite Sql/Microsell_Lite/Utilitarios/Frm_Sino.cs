using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microsell_Lite.Utilitarios
{
    public partial class Frm_Sino : Form
    {
        public Frm_Sino()
        {
            InitializeComponent();
        }

        private void sino_Load(object sender, EventArgs e)
        {

        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            this.Tag = "Si";
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
    }
}
