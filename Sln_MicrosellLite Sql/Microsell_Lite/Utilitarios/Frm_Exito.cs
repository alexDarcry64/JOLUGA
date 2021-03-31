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
    public partial class Frm_Exito : Form
    {
        public Frm_Exito()
        {
            InitializeComponent();
        }

        //private void tocar_timbre()
        //{
        //    string ruta;
        //    ruta = Application.StartupPath;
        //    System.Media.SoundPlayer son;
        //    son = new System.Media.SoundPlayer(ruta + @"\Gotaagua.wav");
        //    son.Play();

        //}

        private void Frm_Advertencia_Load(object sender, EventArgs e)
        {
            //tocar_timbre();
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitario obj = new Utilitario();
                obj.Mover_formulario(this);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuButton1_Click(sender, e);
            }
        }
    }
}
