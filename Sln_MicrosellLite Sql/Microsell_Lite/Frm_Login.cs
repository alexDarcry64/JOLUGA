using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;
using Microsell_Lite.Utilitarios;


namespace Microsell_Lite
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();
            fil.Show();
            sino.Lbl_msm1.Text = "¿Quieres salir del sistema?";
            sino.ShowDialog();
            fil.Hide();

            if (sino.Tag.ToString() == "Si")
            {
                Application.Exit();
            }
        }

        private bool Validar_Texto()
        {
            Frm_Filtro fil = new Frm_Filtro();
            if (txtUsuario.Text.Trim().Length < 2) { fil.Show();MessageBox.Show("Ingresa tu usuario","Login",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); txtUsuario.Focus(); return false; }
            if (txtPass.Text.Trim().Length < 2) { fil.Show(); MessageBox.Show("Ingresa tu contraseña", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); txtPass.Focus(); return false; }

            return true;
        }
        int veces = 0;
        public void Login()
        {
            RN_Usuario obj = new RN_Usuario();
            DataTable dato = new DataTable();

            
            string usu = txtUsuario.Text;
            string pass = txtPass.Text;

            if (Validar_Texto() == false) return;

            if (obj.RN_Login(usu,pass) == true)
            {
                dato = obj.RN_Buscar_Usuario(usu);
                if (dato.Rows.Count > 0)
                {
                    DataRow dr = dato.Rows[0];
                    Cls_Libreria.IdRol = dr["Id_Rol"].ToString();
                    Cls_Libreria.Nombre = dr["Nombres"].ToString();
                    Cls_Libreria.Foto = dr["Ubicacion_Foto"].ToString();
                    Cls_Libreria.Rol = dr["Rol"].ToString();
                    Cls_Libreria.IdUsu = dr["id_Usu"].ToString();
                }
                this.Hide();
                Frm_Principal pri = new Frm_Principal();
                pri.Show();
                pri.CargarDatosUsuario();
            }
            else
            {
                veces += 1;
                txtPass.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
                MessageBox.Show("Usuario o contraseña incorrectos. Intentalo nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (veces == 3)
                {
                    MessageBox.Show("Se ha alcanzado el limite de intentos","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();
            fil.Show();
            sino.Lbl_msm1.Text = "¿Quieres salir del sistema?";
            sino.ShowDialog();
            fil.Hide();

            if (sino.Tag.ToString() == "Si")
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
