using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using System.IO;
using Microsell_Lite.Utilitarios;
using Microsell_Lite.Productos;
using Prj_Capa_Negocio;
using Microsell_Lite.Ventas;

namespace Microsell_Lite.Compras
{
    public partial class Frm_Compras : Form
    {
        public Frm_Compras()
        {
            InitializeComponent();
        }

        private void Frm_Ventana_Ventas_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            
            Llenar_Combo_Proveedores();
        }

        private void Configurar_listView()
        {
            var lis = lsv_Det;

            lsv_Det.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("Id Producto", 109, HorizontalAlignment.Left);//0
            lis.Columns.Add("Descripcion Producto", 351, HorizontalAlignment.Left);//0
            lis.Columns.Add("Cantidad", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Pre Unitario", 90, HorizontalAlignment.Right);//0
            lis.Columns.Add("Importe", 90, HorizontalAlignment.Right);//0
        }

        private void Llenar_Combo_Proveedores()
        {
            RN_Proveedor obj = new RN_Proveedor();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todos_Proveedores();

            if (dato.Rows.Count > 0)
            {
                var cbo = cbo_provee;
                cbo.DataSource = dato;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "IDPROVEE";
                cbo.SelectedIndex = 0; 
            }
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {

            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }

        }

        private void pnl_sinProd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public static string xidProducto;
        public static string xnombreProducto;
        public static double xcant;
        public static double xprecio;
        public static double ximporte;

        private void Calcular()
        {
            double xtotal = 0;
            double xcant = 0;
            double xprecio = 0;
            double ximporte = 0;
            double xsubtotal = 0;
            double xigv = 0;

            for (int i = 0; i < lsv_Det.Items.Count; i++)
            {
                xcant = Convert.ToDouble(lsv_Det.Items[i].SubItems[2].Text);
                xprecio = Convert.ToDouble(lsv_Det.Items[i].SubItems[3].Text);

                ximporte = xprecio * xcant;
                lsv_Det.Items[i].SubItems[4].Text = ximporte.ToString("###0.00");
                xtotal = xtotal + Convert.ToDouble(lsv_Det.Items[i].SubItems[4].Text);
            }
            xsubtotal = xtotal / 1.16;

            xigv = xsubtotal * 0.16;

            lbl_subtotal.Text = xsubtotal.ToString("###0.00");
            lbl_igv.Text = xigv.ToString("###0.00");
            lbl_TotalPagar.Text = xtotal.ToString("###0.00");
        }

        private void Agregar_Productos_carro(string xxidProd, string xxnomprod, double xxcant, double xxprecio, double xximporte)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            try
            {
                if (lsv_Det.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(xxidProd);
                    item.SubItems.Add(xxnomprod.Trim());
                    item.SubItems.Add(xxcant.ToString());
                    item.SubItems.Add(xxprecio.ToString("###0.00"));
                    item.SubItems.Add(xximporte.ToString("###0.00"));


                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;
                    pnl_sinProd.Visible = false;
                }
                else
                {
                    for (int i = 0; i < lsv_Det.Items.Count; i++)
                    {
                        if (lsv_Det.Items[i].Text.Trim() == xxidProd.Trim())
                        {
                            fil.Show();
                            adv.lbl_Msm1.Text = "El producto ya fue agregado al carrito.";
                            adv.ShowDialog();
                            fil.Hide();
                        }
                    }

                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(xxidProd);
                    item.SubItems.Add(xxnomprod.Trim());
                    item.SubItems.Add(xxcant.ToString());
                    item.SubItems.Add(xxprecio.ToString("###0.00"));
                    item.SubItems.Add(xximporte.ToString("###0.00"));

                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Nuevo_buscarProd_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProd_Compra pro = new Frm_ListadoProd_Compra();
            fil.Show();
            Frm_ListadoProd_Compra.tipoVenta = "compra";
            pro.cbxCotizacion.Checked = true;
            pro.txtbuscar.Focus();
            pro.ShowDialog();
            fil.Hide();
            try
            {
                if (pro.Tag.ToString() == "A")
                {
                    string _idProd = pro.lblIdProducto.Text;
                    string _nomprod = pro.lblNomProd.Text;
                    double _cant = Convert.ToDouble(pro.lblCant.Text);
                    double _precio = Convert.ToDouble(pro.lblPreUnid.Text);
                    double _importe = Convert.ToDouble(pro.lblImport.Text);

                    Agregar_Productos_carro(_idProd,_nomprod,_cant,_precio,_importe);
                    txt_IdComp.Text = RN_TipoDoc.RN_Nro_id(9);
                    this.pnl_sinProd.Hide();
                }
            }
            catch (Exception)
            {
                pro.Tag = "";
                pro.Close();
            }

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProd_Compra pro = new Frm_ListadoProd_Compra();
            fil.Show();
            Frm_ListadoProd_Compra.tipoVenta = "compra";
            pro.cbxCotizacion.Checked = true;
            pro.txtbuscar.Focus();
            pro.ShowDialog();
            fil.Hide();
            try
            {
                if (pro.Tag.ToString() == "A")
                {
                    string _idProd = pro.lblIdProducto.Text;
                    string _nomprod = pro.lblNomProd.Text;
                    double _cant = Convert.ToDouble(pro.lblCant.Text);
                    double _precio = Convert.ToDouble(pro.lblPreUnid.Text);
                    double _importe = Convert.ToDouble(pro.lblImport.Text);

                    Agregar_Productos_carro(_idProd, _nomprod, _cant, _precio, _importe);
                    txt_IdComp.Text = RN_TipoDoc.RN_Nro_id(9);
                    this.pnl_sinProd.Hide();
                }
            }
            catch (Exception)
            {
                pro.Tag = "";
                pro.Close();
            }
        }

        private void bt_editPre_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Precio solo = new Frm_Solo_Precio();
            Frm_Advertencia adv = new Frm_Advertencia();
            if (lsv_Det.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Seleccione un producto para editar";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {
                double precio_ingresado = 0;
                double precio_editado = 0;
                precio_ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[3].Text);
                fil.Show();
                solo.txt_cant.Text = precio_ingresado.ToString();
                solo.ShowDialog();
                fil.Hide();
                try {
                    if (solo.Tag.ToString() == "A")
                    {
                        precio_editado = Convert.ToDouble(solo.txt_cant.Text);
                        lsv_Det.SelectedItems[0].SubItems[3].Text = precio_editado.ToString("###0.00");
                        Calcular();
                    }

                } catch(Exception io)
                {

                }
                
            }
        }

        private void bt_editCant_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Cantidad solo = new Frm_Solo_Cantidad();
            Frm_Advertencia adv = new Frm_Advertencia();
            if (lsv_Det.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Selecciona un producto para editar su cantidad";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {
                double cantidad_ingresado = 0;
                double cantidad_editado = 0;
                cantidad_ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[2].Text);
                fil.Show();
                solo.txt_cant.Text = cantidad_ingresado.ToString();
                solo.ShowDialog();
                fil.Hide();
                try
                {
                    if (solo.Tag.ToString() == "A")
                    {
                        cantidad_editado = Convert.ToDouble(solo.txt_cant.Text);
                        lsv_Det.SelectedItems[0].SubItems[2].Text = cantidad_editado.ToString("###0.00");
                        Calcular();
                    }
                }
                catch (Exception io)
                {

                    try
                    {
                        if (solo.Tag.ToString() == "A")
                        {
                            cantidad_editado = Convert.ToDouble(solo.txt_cant.Text);
                            lsv_Det.SelectedItems[0].SubItems[2].Text = cantidad_editado.ToString("###0.00");
                            Calcular();
                        }
                    }
                    catch (Exception)
                    {

                        solo.Tag = "";
                        solo.Close();
                    }
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();
            Frm_Advertencia adv = new Frm_Advertencia();
            if (lsv_Det.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Selecciona un producto a quitar";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {
                fil.Show();
                sino.Lbl_msm1.Text = "¿Seguro que deseas eliminar este producto?";
                sino.ShowDialog();
                fil.Hide();

                if (sino.Tag.ToString()=="Si")
                {
                    int i;
                    var lis = lsv_Det.SelectedItems[0];
                    for (i = lsv_Det.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        lsv_Det.Items.Remove(lsv_Det.SelectedItems[i]);
                    }
                    Calcular();
                }

                
            }
        }

        private void Frm_Compras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (pnl_sinProd.Visible == true)
                {
                    btn_Nuevo_buscarProd_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                if (pnl_sinProd.Visible == false)
                {
                    bt_add_Click(sender, e);
                }
            }

            if (e.KeyCode == Keys.F5)
            {
                if (pnl_sinProd.Visible == false)
                {
                    btn_procesar_Click_1(sender, e);
                }
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control)+Convert.ToInt32(Keys.A))
            {
                if (pnl_sinProd.Visible == false)
                {
                    cbo_provee.Focus();
                }
            }
        }

        private bool Validar_Compra()
        {
            Frm_Filtro fil = new Frm_Filtro();
            if(lsv_Det.Items.Count == 0) { fil.Show(); MessageBox.Show("Ingresa al menos un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); return false; }
            if (cbo_provee.SelectedIndex == -1) { fil.Show(); MessageBox.Show("Selecciona un proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); cbo_provee.Focus(); return false; }
            if (txt_NroFisico.Text.Trim().Length < 2) { fil.Show(); MessageBox.Show("Ingrese el numero de factura fisica", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); txt_NroFisico.Focus(); return false; }
            if (cbo_tipoPago.SelectedIndex == -1) { fil.Show(); MessageBox.Show("Selecciona el tipo de pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); cbo_tipoPago.Focus(); return false; }
            if (cbo_tipoDoc.SelectedIndex == -1) { fil.Show(); MessageBox.Show("Selecciona el tipo de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); cbo_tipoDoc.Focus(); return false; }

            return true;
        }

        private double BuscarUtilidad_Producto(string idProd)
        {
            RN_Productos obj = new RN_Productos();
            DataTable dato = new DataTable();

            double utilidad = 0;

            dato = obj.RN_Buscar_Productos(idProd);
            if (dato.Rows.Count > 0)
            {
                utilidad = Convert.ToDouble(dato.Rows[0]["UtilidadUnit"]);
                return utilidad;
            }

            return 0;
        }

        private void Registrar_Compra()
        {
            EN_IngresoCompra com = new EN_IngresoCompra();
            EN_Det_IngresoCompra det = new EN_Det_IngresoCompra();
            RN_IngresoCompra obj = new RN_IngresoCompra();
            RN_Productos pro = new RN_Productos();

            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Exito exit = new Frm_Exito();

            try
            {
                com.IdCom = txt_IdComp.Text;
                com.Nro_Fac_Fisico1 = txt_NroFisico.Text;
                com.IdProvee1 = cbo_provee.SelectedValue.ToString();
                com.SubTotal_Com1 = Convert.ToDouble(lbl_subtotal.Text);
                com.FechaIngre1 = dtp_FechaCom.Value;
                com.IdUsu1 = Convert.ToInt32(Cls_Libreria.IdUsu);
                com.ModalidadPago1 = cbo_tipoPago.Text;
                com.TiempoEspera1 = 0;
                com.FechaVence1 = dtp_FechaVenc.Value;
                com.EstadoIngre1 = "Activo";
                com.RecibiConforme1 = conforme;
                com.Datos_Adicional1 = txt_obser.Text;
                com.Tipo_Doc_Compra1 = cbo_tipoDoc.Text;

                obj.RN_Ingresar_RegistroCompra(com);

                if (BD_IngresoCompra.guardado == true)
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(9);

                    for (int i = 0; i < lsv_Det.Items.Count; i++)
                    {
                        var item = lsv_Det.Items[i];
                        det.Id_ingreso1 = txt_IdComp.Text;
                        det.Id_Pro1 = item.SubItems[0].Text;
                        det.Cantidad1 = Convert.ToDouble(item.SubItems[2].Text);
                        det.Precio1 = Convert.ToDouble(item.SubItems[3].Text);
                        det.Importe1 = Convert.ToDouble(item.SubItems[4].Text);

                        obj.RN_Insertar_Detalle_RegistroCompra(det);
                        Registrar_Movimiento_Kardex(det.Id_Pro1.Trim(),det.Cantidad1, det.Precio1);

                        double utilidad = 0;
                        double valorAlmacen = 0;
                        double preCompra = det.Precio1;
                        double PreVenta = 0;
                        double xUtilidad = 0;

                        xUtilidad = BuscarUtilidad_Producto(det.Id_Pro1.Trim());
                        PreVenta = xUtilidad * preCompra;
                        utilidad = PreVenta - preCompra;
                        valorAlmacen = det.Cantidad1 * preCompra;
                        pro.RN_Actualizar_PrecioCompra_Producto(det.Id_Pro1.Trim(),preCompra,
                            PreVenta,utilidad,valorAlmacen);
                    }
                    fil.Show();
                    exit.lbl_Msm1.Text = "La compra se ha registrado correctamente";
                    exit.ShowDialog();
                    fil.Hide();
                    lsv_Det.Items.Clear();
                    cbo_provee.SelectedIndex = -1;
                    txt_NroFisico.Text = "";
                    cbo_tipoPago.Text = "";
                    this.Tag = "A";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al Guardar la compra: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }

        bool conforme = false;

        private void Registrar_Movimiento_Kardex(string idProd, double xcantidad, double xprecioCompra)
        {
            RN_Kardex obj = new RN_Kardex();
            EN_Kardexcs kar = new EN_Kardexcs();
            RN_Productos pro = new RN_Productos();
            DataTable dato = new DataTable();
            DataTable datopro = new DataTable();

            string xidKardex = "";
            int xItem = 0;
            double stockProd = 0;
            double precioCompraPro = 0;

            try
            {
                if (obj.RN_VerificarProducto_Cardex(idProd) == true)
                {
                    dato = obj.RN_KardexDetalle_Producto(idProd.Trim());
                    if (dato.Rows.Count > 0)
                    {
                        xidKardex = Convert.ToString(dato.Rows[0]["Id_krdx"]);
                        xItem = dato.Rows.Count;

                        datopro = pro.RN_Buscar_Productos(idProd.Trim());
                        stockProd = Convert.ToDouble(datopro.Rows[0]["Stock_Actual"]);
                        precioCompraPro = Convert.ToDouble(datopro.Rows[0]["Pre_Compra"]);

                        kar.Idkardex = xidKardex;
                        kar.Item = xItem + 1;
                        kar.Doc_soporte = txt_NroFisico.Text;
                        kar.Det_operacion = "Compra de Mercaderia";
                        kar.Cantidad_in = xcantidad;
                        kar.Precio_in = xprecioCompra;
                        kar.Total_in = xcantidad * xprecioCompra;
                        kar.Cantidad_out = 0;
                        kar.Precio_out = 0;
                        kar.Importe_total_out = 0;

                        kar.Cantidad_saldo = stockProd + xcantidad;
                        kar.Promedio = xprecioCompra;
                        kar.Total_saldo = xprecioCompra * kar.Cantidad_saldo;

                        obj.RN_Registrar_Detalle_Kardex(kar);

                        pro.RN_Sumar_Stock_Producto(idProd.Trim(), xcantidad);


                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                conforme = true;
            }
            else
            {
                conforme = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_procesar_Click_1(object sender, EventArgs e)
        {
            if (Validar_Compra() == true)
            {
                Registrar_Compra();
            }
        }
    }
}