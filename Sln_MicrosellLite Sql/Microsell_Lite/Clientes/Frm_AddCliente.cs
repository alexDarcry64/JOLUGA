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
using Prj_Capa_Datos;

namespace Microsell_Lite.Clientes
{
    public partial class Frm_AddCliente : Form
    {
        public Frm_AddCliente()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            txtIdCliente.Text = RN_TipoDoc.RN_Nro_id(8);
            Cargar_Distritos();
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
            this.Tag = "";
            this.Close();
        }
        
        private void lblAbrir_Click(object sender, EventArgs e)
        {
            
        }

        private bool Validar_Texbox()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if (txtIdCliente.Text.Trim().Length < 2) {fil.Show(); ver.lbl_Msm1.Text = "Ingrese un id del Cliente"; ver.ShowDialog(); fil.Hide(); return false; }
            if (txtRazonSocial.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese la razon social del Cliente"; ver.ShowDialog(); fil.Hide(); txtRazonSocial.Focus(); return false; }
            if (txtRfc.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el RFC del Cliente"; ver.ShowDialog(); fil.Hide(); txtRfc.Focus(); return false; }
            if (txtDireccion.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese un id del Cliente"; ver.ShowDialog(); fil.Hide(); txtDireccion.Focus(); return false; }
            if (txtTelefono.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese la razon social del Cliente"; ver.ShowDialog(); fil.Hide(); txtTelefono.Focus(); return false; }
            if (txtEmail.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el RFC del Cliente"; ver.ShowDialog(); fil.Hide(); txtRfc.Focus(); txtRazonSocial.Focus(); return false; }
            if (txtLimiteCredito.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese un id del Cliente"; ver.ShowDialog(); fil.Hide(); txtEmail.Focus(); return false; }
            if (txtNombreContacto.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese la razon social del Cliente"; ver.ShowDialog(); fil.Hide(); txtNombreContacto.Focus(); return false; }
            if (dtpFechaAniv.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el RFC del Cliente"; ver.ShowDialog(); fil.Hide(); dtpFechaAniv.Focus(); return false; }
            if (cbmDistrito.SelectedIndex == -1) { fil.Show(); ver.lbl_Msm1.Text = "Seleccione un Distrito"; ver.ShowDialog(); fil.Hide(); cbmDistrito.Focus(); return false; }

            return true;
        }

        private void Registrar_Cliente()
        {
            RN_Cliente obj = new RN_Cliente();
            EN_Cliente cli = new EN_Cliente();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Exito ex = new Frm_Exito();
            Frm_Advertencia adv = new Frm_Advertencia();
                
            try
            {
                cli.Idcliente = txtIdCliente.Text;
                cli.Razonsocial = txtRazonSocial.Text;
                cli.Rfc = txtRfc.Text;
                cli.Direccion = txtDireccion.Text;
                cli.Telefono = txtTelefono.Text;
                cli.Email = txtEmail.Text;
                cli.Contacto = txtNombreContacto.Text;
                cli.IdDis = Convert.ToInt32(cbmDistrito.SelectedValue);
                cli.FechaAniv = dtpFechaAniv.Value;
                cli.LimiteCred = Convert.ToDouble(txtLimiteCredito.Text);

                obj.RN_Insertar_Cliente(cli);

                if (BD_Cliente.guardado == true)
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(8);
                    limpiar();

                    this.Tag = "A";
                    this.Close();
                    fil.Show();
                    ex.lbl_Msm1.Text = "El cliente se ha guardado correctamente.";
                    ex.ShowDialog();
                    fil.Hide();
                }
            }
            catch(Exception e)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Ha ocurrido un error al guardar: "+e.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }


        private void limpiar()
        {
            txtIdCliente.Text = "";
            txtRazonSocial.Text = "";
            txtRfc.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombreContacto.Text = "";
            cbmDistrito.SelectedIndex = -1;

        }

        private void Cargar_Distritos()
        {
            RN_Distrito obj = new RN_Distrito();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todos_Distrito();
            if (dato.Rows.Count > 0)
            {
                cbmDistrito.DataSource = dato;
                cbmDistrito.ValueMember = "Id_Dis";
                cbmDistrito.DisplayMember = "Distrito";
                cbmDistrito.SelectedIndex = -1;
            }
        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            if(Validar_Texbox()==true)
            {
                Registrar_Cliente();
            }
        }
    }
}
