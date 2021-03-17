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
using Prj_Capa_Datos;

namespace Microsell_Lite.Productos
{
    public partial class Frm_EditProducto : Form
    {
        public Frm_EditProducto()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            double tipoCambio = 0;
            tipoCambio = RN_TipoDoc.RN_Leer_Tipo_Cambio(7);
            Buscar_Productopara_Editar(this.Tag.ToString());
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

        string xFotoruta = "";
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

            if (txtIdProducto.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el id del Producto"; ver.ShowDialog(); fil.Hide(); txtIdProducto.Focus(); return false; }
            if (txtdescripcion_producto.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese la descripcion del producto"; ver.ShowDialog(); fil.Hide();  txtdescripcion_producto.Focus(); return false; }
            if (txtPesoUnit.Text.Trim().Length < 2) { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el peso por unidad del producto"; ver.ShowDialog(); fil.Hide(); txtPesoUnit.Focus(); return false; }

            if (cmbTipoProducto.SelectedIndex == -1) { fil.Show(); ver.lbl_Msm1.Text = "Seleccione el tipo de Producto"; ver.ShowDialog(); fil.Hide(); cmbTipoProducto.Focus(); return false; }
            if (cmbUnidadMedida.SelectedIndex == -1) { fil.Show(); ver.lbl_Msm1.Text = "Seleccione la unidad de medida del producto"; ver.ShowDialog(); fil.Hide(); cmbUnidadMedida.Focus(); return false; }

            if (txtPrecioCompra.Text.Trim() == "") { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el precio de compra del producto"; ver.ShowDialog(); fil.Hide(); txtPrecioCompra.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioCompra.Text) == 0) { fil.Show(); ver.lbl_Msm1.Text = "El precio de compra del producto no puede ser 0"; ver.ShowDialog(); fil.Hide(); txtPrecioCompra.Focus(); return false; }

            if (txtPrecioVentaMenor.Text.Trim() == "") { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el precio de venta por menor del producto "; ver.ShowDialog(); fil.Hide(); txtPrecioVentaMenor.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioVentaMenor.Text) == 0) { fil.Show(); ver.lbl_Msm1.Text = "El precio de venta minorista no puede ser 0"; ver.ShowDialog(); fil.Hide(); txtPrecioVentaMenor.Focus(); return false; }

            if (txtPrecioVentaMayor.Text.Trim() == "") { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el precio de venta mayorista del producto"; ver.ShowDialog(); fil.Hide(); txtPrecioVentaMayor.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioVentaMayor.Text) == 0) { fil.Show(); ver.lbl_Msm1.Text = "El precio de venta mayorista no puede ser 0"; ver.ShowDialog(); fil.Hide(); txtPrecioVentaMayor.Focus(); return false; }

            if (txtPrecioVenta.Text.Trim() == "") { fil.Show(); ver.lbl_Msm1.Text = "Ingrese el precio de venta del producto"; ver.ShowDialog(); fil.Hide(); txtPrecioVenta.Focus(); return false; }
            if (Convert.ToDouble(txtPrecioVenta.Text) == 0) { fil.Show(); ver.lbl_Msm1.Text = "El precio de venta del producto no puede ser 0"; ver.ShowDialog(); fil.Hide(); txtPrecioVenta.Focus(); return false; }

            if (txtClaveSat.Text.Trim() == "") { fil.Show(); ver.lbl_Msm1.Text = "Ingrese la clave de Sat del producto"; ver.ShowDialog(); fil.Hide(); txtClaveSat.Focus(); return false; }
            if (Convert.ToDouble(txtClaveSat.Text) == 0) { fil.Show(); ver.lbl_Msm1.Text = "La clave sat del producto no puede ser 0"; ver.ShowDialog(); fil.Hide(); txtClaveSat.Focus(); return false; }

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
            if (Validar_Texbox() == true)
            {
                Editar();
            }
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

        private void txtUtilidad_TextChanged(object sender, EventArgs e)
        {
            txtUtilidad.Text = txtUtilidad.Text.Replace(",", ".");
            txtUtilidad.SelectionStart = txtUtilidad.Text.Length;

            try
            {
                if (txtUtilidad.Text.Trim() == "") { return; }
                if (txtPrecioCompra.Text.Trim() == "") { return; }

                double precio_compra = 0;

                precio_compra = Convert.ToDouble(txtPrecioCompra.Text) * Convert.ToDouble(txtUtilidad.Text);
                txtPrecioVentaMenor.Text = precio_compra.ToString("###0.00");
            }
            catch (Exception ex)
            {
                string sms = ex.Message;
            }
        }

        //private void txtMargenUtilidad_TextChanged(object sender, EventArgs e)
        //{
        //txtMargenUtilidad.Text = txtMargenUtilidad.Text.Replace(",", ".");
        //txtMargenUtilidad.SelectionStart = txtMargenUtilidad.Text.Length;

            //try
            //{
            //    if (txtMargenUtilidad.Text.Trim() == "") { return; }
            //    if (txtPrecioCompra.Text.Trim() == "") { return; }

            //    double precio_compra = 0;
            //    double utilidad = 0;

            //    precio_compra = Convert.ToDouble(txtPrecioCompra.Text) * Convert.ToDouble(txtMargenUtilidad.Text);
            //    txtPrecioVentaMenor.Text = precio_compra.ToString("##.00");

            //    utilidad = Convert.ToDouble(txtPrecioVentaMenor.Text) - Convert.ToDouble(txtPrecioCompra.Text);
            //    txtUtilidad.Text = utilidad.ToString("##.00");
            //}
            //catch(Exception ex)
            //{
            //    string sms = ex.Message;
            //}
            //}

            private void Editar()
        {
            RN_Productos obj = new RN_Productos();
            EN_Producto producto = new EN_Producto();

            try
            {
                producto.Idpro = txtIdProducto.Text;
                producto.Idprove = lblidproveedor.Text;
                producto.Descripcion = txtdescripcion_producto.Text;
                producto.Utilidad = Convert.ToDouble(txtUtilidad.Text);
                producto.Pre_compra = Convert.ToDouble(txtPrecioCompra.Text);
                producto.IdCat = Convert.ToInt32(lblidcat.Text);
                producto.IdMar = Convert.ToInt32(lblidmarca.Text);
                if (xFotoruta.Trim().Length < 5)
                {
                    producto.Foto = ".";
                }
                else
                {
                    producto.Foto = xFotoruta;
                }
                producto.Pre_Venta_Menor = Convert.ToDouble(txtPrecioVentaMenor.Text);
                producto.Pre_Venta_Mayor = Convert.ToDouble(txtPrecioVentaMayor.Text);
                producto.UndMdida = cmbUnidadMedida.Text;
                producto.PesoUnit = Convert.ToDouble(txtPesoUnit.Text);
                producto.Utilidad = Convert.ToDouble(txtUtilidad.Text);
                producto.TipoProd = cmbTipoProducto.Text;
                producto.ClaveSAT = txtClaveSat.Text;

                obj.RN_Editar_Producoto(producto);

                if (BD_Productos.seedito == true)
                {

                    Frm_Filtro fil = new Frm_Filtro();
                    fil.Show();
                    MessageBox.Show("Producto guardado exitosamente");
                    fil.Hide();

                    this.Tag = "A";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:" + ex.Message);
            }

        }

        private void txtMargenUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ut = new Utilitario();
            e.KeyChar = Convert.ToChar(ut.Solo_Numeros(e.KeyChar));
        }

        private void txtClaveSat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ut = new Utilitario();
            e.KeyChar = Convert.ToChar(ut.Solo_Numeros(e.KeyChar));
        }

        private void Buscar_Productopara_Editar(string idproducto)
        {
            RN_Productos obj = new RN_Productos();
            DataTable data = new DataTable();
            try
            {
                data = obj.RN_Buscar_Productos(idproducto);
                if (data.Rows.Count > 0)
                {
                    txtIdProducto.Text = Convert.ToString(data.Rows[0]["Id_Pro"]);
                    txtdescripcion_producto.Text = Convert.ToString(data.Rows[0]["Descripcion_Larga"]);
                    cmbTipoProducto.Text = Convert.ToString(data.Rows[0]["TipoProdcto"]);
                    cmbUnidadMedida.Text = Convert.ToString(data.Rows[0]["UndMedida"]);
                    txtPrecioCompra.Text = Convert.ToString(data.Rows[0]["Pre_Compra"]);
                    txtPrecioVentaMenor.Text = Convert.ToString(data.Rows[0]["Pre_vntaxMenor"]);
                    txtPrecioVentaMayor.Text = Convert.ToString(data.Rows[0]["Pre_vntaxMayor"]);
                    txtPrecioVenta.Text = Convert.ToString(data.Rows[0]["Pre_Venta"]);
                    txtPesoUnit.Text = Convert.ToString(data.Rows[0]["PesoUnit"]);
                    txtUtilidad.Text = Convert.ToString(data.Rows[0]["UtilidadUnit"]);
                    txtClaveSat.Text = Convert.ToString(data.Rows[0]["ClaveSAT"]);
                    xFotoruta = Convert.ToString(data.Rows[0]["Foto"]);

                    lblidcat.Text = Convert.ToString(data.Rows[0]["Id_Cat"]);
                    lblidmarca.Text = Convert.ToString(data.Rows[0]["Id_Marca"]);
                    lblidproveedor.Text = Convert.ToString(data.Rows[0]["IDPROVEE"]);

                    txtproveedor.Text = Convert.ToString(data.Rows[0]["NOMBRE"]);
                    txtmarca.Text = Convert.ToString(data.Rows[0]["Marca"]);
                    txtcategoria.Text = Convert.ToString(data.Rows[0]["Categoria"]);

                    piclogo.Load(xFotoruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:" + ex.Message, "Form Add Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
