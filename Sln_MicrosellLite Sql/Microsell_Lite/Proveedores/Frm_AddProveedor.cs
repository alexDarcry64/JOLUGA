using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsell_Lite.Utilitarios;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;

namespace Microsell_Lite.Proveedores
{
    public partial class Frm_AddProveedor : Form
    {
        public Frm_AddProveedor()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {

        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string xFotoruta;
        private void lblAbrir_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            var FilePath = string.Empty;

            try
            {
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    xFotoruta = openFileDialog1.FileName;
                    piclogo.Load(xFotoruta);
                }
            }
            catch(Exception ex)
            {
                piclogo.Load(Application.StartupPath + @"\user.png");
                xFotoruta = Application.StartupPath + @"\user.png";
                fil.Show();
                adv.lbl_Msm1.Text = "Error al Guardar el Personal: "+ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }

        private bool Validar_Texbox()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if(txtIdProveedor.Text.Trim().Length < 2) {fil.Show(); ver.ShowDialog(); fil.Hide(); return false; }
            if(txtIdProveedor.Text.Trim().Length < 2) { fil.Show(); ver.ShowDialog(); fil.Hide();  txtnombrepro.Focus(); return false; }
            if(txtIdProveedor.Text.Trim().Length < 2) { fil.Show(); ver.ShowDialog(); fil.Hide(); txtrfc.Focus(); return false; }

            return true;
        }

        private void Registrar_Proveedor()
        {
            RN_Proveedor obj = new RN_Proveedor();
            EN_Proveedor pro = new EN_Proveedor();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            try
            {
                pro.Idproveedor = txtIdProveedor.Text;
                pro.Nombreproveedor = txtnombrepro.Text;
                pro.Direccion = txtdireccion.Text;
                pro.Telefono = txttelefono.Text;
                pro.Rubro = txtrubro.Text;
                pro.Rfc = txtrfc.Text;
                pro.Correo = txtcorreo.Text;
                pro.Contacto = txtContacto.Text;
                pro.Fotologo = xFotoruta;

                obj.RN_Registrar_Proveedor(pro);
                limpiar();

                this.Tag = "A";
                this.Close();

            }
            catch(Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al guardar:" + ex.Message;
                adv.ShowDialog();
                fil.Hide();
                
            }
        }


        private void limpiar()
        {
            txtIdProveedor.Text = "";
            txtnombrepro.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtrubro.Text = "";
            txtrfc.Text = "";
            txtcorreo.Text = "";
            txtContacto.Text = "";
            xFotoruta = "";
            
        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            if(Validar_Texbox()==true)
            {
                Registrar_Proveedor();
            }
        }
    }
}
