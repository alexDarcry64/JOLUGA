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
    public partial class Frm_EditCliente : Form
    {
        public Frm_EditCliente()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            txtIdCliente.Text = RN_TipoDoc.RN_Nro_id(8);
            Buscar_Cliente_Editar(this.Tag.ToString());
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
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            var FilePath = string.Empty;

            try
            {
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                }
            }
            catch(Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al Guardar el cliente: "+ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
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

        private void Editar_Cliente()
        {
            RN_Cliente obj = new RN_Cliente();
            EN_Cliente cli = new EN_Cliente();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Exito exit = new Frm_Exito();

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

                obj.RN_Editar_Cliente(cli);

                if (BD_Cliente.editado == true)
                {
                    limpiar();

                    this.Tag = "A";
                    this.Close();
                    fil.Show();
                    exit.lbl_Msm1.Text = "El cliente se ha guardado correctamente";
                    adv.ShowDialog();
                    fil.Hide();
                }
            }
            catch(Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al Guardar el cliente: " + ex.Message;
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
                Editar_Cliente();
            }
        }

        private void Buscar_Cliente_Editar(string idCliente)
        {
            RN_Cliente obj = new RN_Cliente();
            DataTable data = new DataTable();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            try
            {
                data = obj.RN_Buscar_Cliente_Valor(idCliente,"Activo");
                if (data.Rows.Count > 0)
                {
                    txtIdCliente.Text = Convert.ToString(data.Rows[0]["Id_Cliente"]);
                    txtRazonSocial.Text = Convert.ToString(data.Rows[0]["Razon_Social_Nombres"]);
                    txtRfc.Text = Convert.ToString(data.Rows[0]["RFC"]);
                    txtDireccion.Text = Convert.ToString(data.Rows[0]["Direccion"]);
                    txtTelefono.Text = Convert.ToString(data.Rows[0]["Telefono"]);
                    txtEmail.Text = Convert.ToString(data.Rows[0]["E_Mail"]);
                    txtLimiteCredito.Text = Convert.ToString(data.Rows[0]["Limit_Credit"]);
                    txtNombreContacto.Text = Convert.ToString(data.Rows[0]["Contacto"]);
                    cbmDistrito.Text = Convert.ToString(data.Rows[0]["Distrito"]);
                    dtpFechaAniv.Text = Convert.ToString(data.Rows[0]["Fcha_Ncmnto_Anivsrio"]);
                }
            }
            catch (Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al Guardar el cliente: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }
    }
}
