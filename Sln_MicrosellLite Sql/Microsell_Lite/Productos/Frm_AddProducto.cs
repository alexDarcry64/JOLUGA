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
using Microsell_Lite.Proveedores;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;


namespace Microsell_Lite.Productos
{
    public partial class Frm_AddProducto : Form
    {
        public Frm_AddProducto()
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
            this.Tag = "";
            this.Close();
        }

        string xFotoruta;
        private void lblAbrir_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Error al Guardar el Personal" + ex.Message);
            }
        }

        private bool Validar_Texbox()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if (txtIdProducto.Text.Trim().Length < 2) { fil.Show(); ver.ShowDialog(); fil.Hide(); txtIdProducto.Focus(); return false; }
            if (txtdescripcion_producto.Text.Trim().Length < 2) { fil.Show(); ver.ShowDialog(); fil.Hide();  txtdescripcion_producto.Focus(); return false; }
            if (txtPesoUnit.Text.Trim().Length < 2) { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPesoUnit.Focus(); return false; }

            if (cmbTipoProducto.SelectedIndex == -1) { fil.Show(); ver.ShowDialog(); fil.Hide(); cmbTipoProducto.Focus(); return false; }
            if (cmbUnidadMedida.SelectedIndex == -1) { fil.Show(); ver.ShowDialog(); fil.Hide(); cmbUnidadMedida.Focus(); return false; }

            if (txtPrecioCompra.Text.Trim() == "") { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioCompra.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioCompra.Text) == 0) { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioCompra.Focus(); return false; }

            if (txtPrecioVentaMenor.Text.Trim() == "") { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioVentaMenor.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioVentaMenor.Text) == 0) { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioVentaMenor.Focus(); return false; }

            if (txtPrecioVentaMayor.Text.Trim() == "") { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioVentaMayor.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioVentaMayor.Text) == 0) { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioVentaMayor.Focus(); return false; }

            if (txtPrecioVenta.Text.Trim() == "") { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioVenta.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioVenta.Text) == 0) { fil.Show(); ver.ShowDialog(); fil.Hide(); txtPrecioVenta.Focus(); return false; }

            return true;
        }

        


        private void limpiar()
        {
            txtIdProducto.Text = "";
            txtdescripcion_producto.Text = "";
            txtproveedor.Text = "";
            txtmarca.Text = "";
            txtcategoria.Text = "";
          
            txtPrecioCompra.Text = "";
            xFotoruta = "";
            
        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            
        }

        private void picbuscarProveedor_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProveedores lis = new Frm_ListadoProveedores();
       

            fil.Show();
            lis.ShowDialog();

            fil.Hide();

            if(lis.Tag.ToString()=="A")
            {
                txtproveedor.Text = lis.lblNombre.Text;
                lblidproveedor.Text = lis.lblId.Text;

         

            }
        }

        private void picbuscarCategoria_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Categoria cat = new Frm_Categoria();
            fil.Show();
            cat.ShowDialog();
            fil.Hide();

            if(cat.Tag.ToString()=="A")
            {
                txtcategoria.Text = cat.txtnombre.Text;
                lblidcat.Text = cat.txtid.Text;
            }

        }

        private void picbuscarMarca_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Marcas mar = new Frm_Marcas();
            fil.Show();
            mar.ShowDialog();
            fil.Hide();

            if (mar.Tag.ToString() == "A")
            {
                txtmarca.Text = mar.txtnombre.Text;
                lblidmarca.Text = mar.txtid.Text;
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            txtPrecioCompra.Text = txtPrecioCompra.Text.Replace(",",".");
            txtPrecioCompra.SelectionStart = txtPrecioCompra.Text.Length;
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ut = new Utilitario();
            e.KeyChar = Convert.ToChar(ut.Solo_Numeros(e.KeyChar));
        }

        private void txtPrecioVentaMenor_TextChanged(object sender, EventArgs e)
        {
            txtPrecioVentaMenor.Text = txtPrecioVentaMenor.Text.Replace(",", ".");
            txtPrecioVentaMenor.SelectionStart = txtPrecioVentaMenor.Text.Length;
        }

        private void txtPrecioVentaMayor_TextChanged(object sender, EventArgs e)
        {
            txtPrecioVentaMayor.Text = txtPrecioVentaMayor.Text.Replace(",", ".");
            txtPrecioVentaMayor.SelectionStart = txtPrecioVentaMayor.Text.Length;
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            txtPrecioVenta.Text = txtPrecioVenta.Text.Replace(",", ".");
            txtPrecioVenta.SelectionStart = txtPrecioVenta.Text.Length;
        }

        private void txtPrecioVentaMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ut = new Utilitario();
            e.KeyChar = Convert.ToChar(ut.Solo_Numeros(e.KeyChar));
        }

        private void txtPrecioVentaMayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ut = new Utilitario();
            e.KeyChar = Convert.ToChar(ut.Solo_Numeros(e.KeyChar));
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ut = new Utilitario();
            e.KeyChar = Convert.ToChar(ut.Solo_Numeros(e.KeyChar));
        }
    }
}
