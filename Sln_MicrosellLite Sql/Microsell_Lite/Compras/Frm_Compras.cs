﻿using System;
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

            lis.Columns.Add("Id Producto", 40, HorizontalAlignment.Left);//0
            lis.Columns.Add("Descripcion Producto", 240, HorizontalAlignment.Left);//0
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

        private void Agregar_Productos_carro()
        {
            try
            {
                if (lsv_Det.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(xidProducto);
                    item.SubItems.Add(xnombreProducto.Trim());
                    item.SubItems.Add(xcant.ToString());
                    item.SubItems.Add(xprecio.ToString("###0.00"));
                    item.SubItems.Add(ximporte.ToString("###0.00"));


                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;
                    pnl_sinProd.Visible = false;
                }
                else
                {
                    for (int i = 0; i < lsv_Det.Items.Count; i++)
                    {
                        if (lsv_Det.Items[i].Text.Trim() == xidProducto.Trim())
                        {
                            MessageBox.Show("El producto ya fue agregado al carrito de compras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(xidProducto);
                    item.SubItems.Add(xidProducto.Trim());
                    item.SubItems.Add(xcant.ToString());
                    item.SubItems.Add(xprecio.ToString("###0.00"));
                    item.SubItems.Add(ximporte.ToString("###0.00"));

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
            Frm_ListadoProducto pro = new Frm_ListadoProducto();
            fil.Show();
            pro.txtbuscar.Focus();
            pro.ShowDialog();
            fil.Hide();

            if (pro.Tag.ToString() == "A")
            {
                Agregar_Productos_carro();
                txt_IdComp.Text = RN_TipoDoc.RN_Nro_id(9);
            }

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProducto pro = new Frm_ListadoProducto();
            fil.Show();
            pro.txtbuscar.Focus();
            pro.ShowDialog();
            fil.Hide();

            if (pro.Tag.ToString() == "A")
            {
                Agregar_Productos_carro();
            }
        }

        private void bt_editPre_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_SoloPrecio solo = new Frm_SoloPrecio();
            if (lsv_Det.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para editar su precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double precio_ingresado = 0;
                double precio_editado = 0;
                precio_ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[3].Text);
                fil.Show();
                solo.txtPrecio.Text = precio_ingresado.ToString();
                solo.ShowDialog();
                fil.Hide();

                if (solo.Tag.ToString() == "A")
                {
                    precio_editado = Convert.ToDouble(solo.txtPrecio.Text);
                    lsv_Det.SelectedItems[0].SubItems[3].Text = precio_editado.ToString("###0.00");
                    Calcular();
                }
            }
        }

        private void bt_editCant_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Cantidad solo = new Frm_Solo_Cantidad();
            if (lsv_Det.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para editar su cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double cantidad_ingresado = 0;
                double cantidad_editado = 0;
                cantidad_ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[2].Text);
                fil.Show();
                solo.txtCantidad.Text = cantidad_ingresado.ToString();
                solo.ShowDialog();
                fil.Hide();

                if (solo.Tag.ToString() == "A")
                {
                    cantidad_editado = Convert.ToDouble(solo.txtCantidad.Text);
                    lsv_Det.SelectedItems[0].SubItems[2].Text = cantidad_editado.ToString("###0.00");
                    Calcular();
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();
            if (lsv_Det.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecciona un producto a quitar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    btn_procesar_Click(sender, e);
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
                    MessageBox.Show("La compra se ha registrado correctamente","Copletado",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

                throw;
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
                        kar.Total_in = xcant * xprecioCompra;
                        kar.Cantidad_out = 0;
                        kar.Precio_out = 0;
                        kar.Importe_total_out = 0;

                        kar.Cantidad_saldo = stockProd + xcant;
                        kar.Promedio = xprecioCompra;
                        kar.Total_saldo = xprecioCompra * kar.Cantidad_saldo;

                        obj.RN_Registrar_Detalle_Kardex(kar);

                        pro.RN_Sumar_Stock_Producto(idProd.Trim(),xcant);


                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            if (Validar_Compra() == true)
            {
                Registrar_Compra();
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
    }
}