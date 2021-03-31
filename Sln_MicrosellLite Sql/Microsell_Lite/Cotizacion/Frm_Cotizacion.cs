using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//importar:
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using System.IO;
using Microsell_Lite.Utilitarios;
using Microsell_Lite.Productos;
using Microsell_Lite.Ventas;
using Microsell_Lite.Compras;
using Microsell_Lite.Clientes;
using Microsell_Lite.Informe;

namespace Microsell_Lite.Cotizacion
{
    public partial class Frm_Cotizacion : Form
    {
        public Frm_Cotizacion()
        {
            InitializeComponent();
        }

        private void Frm_Ventana_Ventas_Load(object sender, EventArgs e)
        {
            Configurar_listView();         


        }

        private void Configurar_listView()
        {
            var lis = lsv_Det;

            lis.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            //configurar las columnas:
            lis.Columns.Add("ID producto", 80, HorizontalAlignment.Left); //0
            lis.Columns.Add("Descripcion producto", 400, HorizontalAlignment.Left);  //1
            lis.Columns.Add("cantidad", 80, HorizontalAlignment.Left);  //2
            lis.Columns.Add("precio Unit", 90, HorizontalAlignment.Right);  //3
            lis.Columns.Add("Importe", 90, HorizontalAlignment.Right );  //4
            lis.Columns.Add("Tipo Producto", 0, HorizontalAlignment.Right);  //5
            lis.Columns.Add("Und", 0, HorizontalAlignment.Right);  //6
            lis.Columns.Add("Utilidad Unit", 0, HorizontalAlignment.Right);  //7
            lis.Columns.Add("Total Utilidad", 0, HorizontalAlignment.Right);  //8

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

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


       


        private bool Validar_Cotizacion()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();

            if (lsv_Det.Items.Count == 0) { fil.Show(); adv.lbl_Msm1.Text = "Ingresa al menos un proucto"; adv.ShowDialog(); fil.Hide(); lsv_Det.Focus(); return false; }
            //if (cbo_provee.SelectedIndex ==-1) { fil.Show(); MessageBox.Show("INgresa Almenos un Proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); cbo_provee.Focus(); return false; }
            //if (txt_NroFisico.Text.Trim().Length < 2) { fil.Show(); MessageBox.Show("INgresa el Nro de FActura Fisica", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); txt_NroFisico.Focus(); return false; }
            //if (cbo_tipoPago.SelectedIndex == -1) { fil.Show(); MessageBox.Show("Selecciona el Tipo de Pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); cbo_tipoPago.Focus(); return false; }
            //if (cbo_tipoDoc .SelectedIndex == -1) { fil.Show(); MessageBox.Show("Selecciona el Tipo de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); cbo_tipoDoc.Focus(); return false; }

            return true;
        }

        private void Frm_Cotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape )
            {
                this.Close();
            }


        }

        private void pnl_subtitu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }

        private void Agregar_Productos_carro(string xxidProd, string xxnomprod, double xxcant, double xxprecio, double xximporte, string xunid, string xtipoProd, double xutilidadUnit)
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
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
                    item.SubItems.Add(xtipoProd.ToString());
                    item.SubItems.Add(xunid.ToString());
                    item.SubItems.Add(xutilidadUnit.ToString("###0.00"));
                    item.SubItems.Add(xutilidadUnit.ToString("###0.00"));

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
                            adv.lbl_Msm1.Text = "El producto ya fue agregado al carrito de compras";
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
                    item.SubItems.Add(xtipoProd.ToString());
                    item.SubItems.Add(xunid.ToString());
                    item.SubItems.Add(xutilidadUnit.ToString("###0.00"));
                    item.SubItems.Add(xutilidadUnit.ToString("###0.00"));

                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;
                }
            }
            catch (Exception ex)
            {

                fil.Show();
                adv.lbl_Msm1.Text = "Ha ocurrido un error al guardar: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }

        private void Calcular()
        {
            double xtotal = 0;
            double xcant = 0;
            double xprecio = 0;
            double ximporte = 0;
            double xsubtotal = 0;
            double xigv = 0;
            double xutili = 0;
            double ximport_Utili = 0;
            double xtotalGanancia = 0;

            for (int i = 0; i < lsv_Det.Items.Count; i++)
            {
                xcant = Convert.ToDouble(lsv_Det.Items[i].SubItems[2].Text);
                xprecio = Convert.ToDouble(lsv_Det.Items[i].SubItems[3].Text);

                ximporte = xprecio * xcant;
                lsv_Det.Items[i].SubItems[4].Text = ximporte.ToString("###0.00");

                xutili = Convert.ToDouble(lsv_Det.Items[i].SubItems[7].Text);
                ximport_Utili = xutili * xcant;

                xtotal = xtotal + Convert.ToDouble(lsv_Det.Items[i].SubItems[4].Text);

                xtotalGanancia = xtotalGanancia + Convert.ToDouble(lsv_Det.Items[i].SubItems[8].Text);
            }
            xsubtotal = xtotal / 1.16;

            xigv = xsubtotal * 0.16;

            lbl_subtotal.Text = xsubtotal.ToString("###0.00");
            lbl_igv.Text = xigv.ToString("###0.00");
            lbl_TotalPagar.Text = xtotal.ToString("###0.00");
            lbl_totalGanancia.Text = xtotalGanancia.ToString("###0.00");
            lbl_son.Text = Numalet.ToString(lbl_TotalPagar.Text);

            let.LetraCapital = chkCapital.Checked;

            if (!actualizaco)
            {
                ActualizarConfig();
            }
        }

        Numalet let = new Numalet();
        bool actualizaco = false;

        private void ActualizarConfig()
        {
            actualizaco = true;
            chkCapital.Checked = let.LetraCapital;

            if (lbl_son.Text.Length > 0)
            {
                lbl_son.Text = let.ToCustomString(lbl_TotalPagar.Text);
                actualizaco = false;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProd_Compra xpro = new Frm_ListadoProd_Compra();

            fil.Show();
            Frm_ListadoProd_Compra.tipoVenta = "coti";
            xpro.cbxCotizacion.Checked = true;
            xpro.ShowDialog();
            fil.Hide();

            if (xpro.Tag.ToString() == "A")
            {
                string _idProd = xpro.lblIdProducto.Text;
                string _nomprod = xpro.lblNomProd.Text;
                double _cant = Convert.ToDouble(xpro.lblCant.Text);
                double _precio = Convert.ToDouble(xpro.lblPreUnid.Text);
                double _importe = Convert.ToDouble(xpro.lblImport.Text);
                string _und = xpro.lblUnid.Text;
                string _tipoProd = xpro.lblTipoProd.Text;
                double _utilidad = Convert.ToDouble(xpro.lblUtiUnit.Text);

                Agregar_Productos_carro(_idProd, _nomprod, _cant, _precio, _importe, _und, _tipoProd, _utilidad);
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
                adv.lbl_Msm1.Text = "Seleccione un producto";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {
                double precio_Ingresado = 0;
                double precio_Editado = 0;
                precio_Ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[3].Text);

                fil.Show();
                solo.txt_cant.Text = precio_Ingresado.ToString();
                solo.ShowDialog();
                fil.Hide();

                if (solo.Tag.ToString() == "A")
                {
                    precio_Editado = Convert.ToDouble(solo.txt_cant.Text);
                    lsv_Det.SelectedItems[0].SubItems[3].Text = precio_Editado.ToString("###0.00");
                    Calcular();
                }
            }
        }

        private void bt_editCant_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Precio solo = new Frm_Solo_Precio();
            Frm_Advertencia adv = new Frm_Advertencia();

            if (lsv_Det.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Seleccione un producto";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {
                double precio_Ingresado = 0;
                double precio_Editado = 0;
                precio_Ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[2].Text);

                fil.Show();
                solo.txt_cant.Text = precio_Ingresado.ToString();
                solo.ShowDialog();
                fil.Hide();

                if (solo.Tag.ToString() == "A")
                {
                    precio_Editado = Convert.ToDouble(solo.txt_cant.Text);
                    lsv_Det.SelectedItems[0].SubItems[2].Text = precio_Editado.ToString("###0.00");
                    Calcular();
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

                if (sino.Tag.ToString() == "Si")
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

        private void GuardarPedido()
        {
            RN_Pedido obj = new RN_Pedido();
            EN_Pedido ped = new EN_Pedido();
            EN_Det_Pedido det = new EN_Det_Pedido();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            try
            {
                txtIdPedido.Text = RN_TipoDoc.RN_Nro_id(10);
                ped.Id_pedido = txtIdPedido.Text;
                ped.IdCliente = lblIdCliente.Text;
                ped.SubTotal = Convert.ToDouble(lbl_subtotal.Text);
                ped.Igv = Convert.ToDouble(lbl_igv.Text);
                ped.TotalPedido = Convert.ToDouble(lbl_TotalPagar.Text);
                ped.IdUsuario = Convert.ToInt32(Cls_Libreria.IdUsu);
                ped.TotalGanancia = Convert.ToDouble(lbl_totalGanancia.Text);

                obj.RN_Insertar_Pedido(ped);

                if (BD_Pedido.guarda == true)
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(10);
                    det.IdPed = txtIdPedido.Text;
                    for (int i = 0; i < lsv_Det.Items.Count; i++)
                    {
                        var lis = lsv_Det.Items[i];
                        det.IdPro = lis.SubItems[0].Text;
                        det.Precio = Convert.ToDouble(lis.SubItems[3].Text);
                        det.Cantidad = Convert.ToDouble(lis.SubItems[2].Text);
                        det.Importe = Convert.ToDouble(lis.SubItems[4].Text);
                        det.TipoProd = lis.SubItems[5].Text;
                        det.UnidadMedida = lis.SubItems[6].Text;
                        det.UtilidadUnit = Convert.ToDouble(lis.SubItems[7].Text);
                        det.TotalUtilidad = Convert.ToDouble(lis.SubItems[8].Text);

                        obj.RN_Insertar_Detalle_Pedido(det);
                    }

                }
            }
            catch (Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al guardar: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }

        private void Guardar_Cotizacion()
        {
            RN_Cotizacion obj = new RN_Cotizacion();
            EN_Cotizacion coti = new EN_Cotizacion();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Exito ex = new Frm_Exito();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Print_Cotizaciones informeCot = new Frm_Print_Cotizaciones();
            try
            {

                GuardarPedido();
                if (BD_Pedido.guarda == true && BD_Pedido.detalleguarda == true)
                {
                    txtNroCotiza.Text = RN_TipoDoc.RN_Nro_id(11);
                    coti.IdCotizacion = txtNroCotiza.Text;
                    coti.IdPedido = txtIdPedido.Text;
                    coti.FechaCotizacion = dtp_FechaEmi.Value;
                    coti.Vigencia = Convert.ToInt32(nud_vigencia.Value);
                    coti.TotalCoti = Convert.ToDouble(lbl_TotalPagar.Text);
                    coti.Condiciones = txt_condicion.Text;
                    if (chk_sinIgv.Checked == true)
                    {
                        coti.PrecioConIgv = "No";
                    }
                    else
                    {
                        coti.PrecioConIgv = "Si";
                    }
                    coti.EstadoCoti = "Pendiente";

                    obj.RN_Registrar_Cotizacion(coti);

                    if (BD_Cotizacion.guardo == true)
                    {

                        //Mandar a imprimir cotizacion
                        fil.Show();
                        informeCot.Tag = txtNroCotiza.Text;
                        informeCot.Crear_Impresion_Cotizacion();
                        informeCot.ShowDialog();
                        fil.Hide();

                                
                        RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(11);
                        fil.Show();
                        ex.lbl_Msm1.Text = "Cotizacion Guardada Exitosamente.";
                        ex.ShowDialog();
                        fil.Hide();

                        pnl_sinProd.Visible = true;
                        lsv_Det.Items.Clear();
                        txt_cliente.Text = "";
                        txtNroCotiza.Text = "";
                        txtIdPedido.Text = "";
                        lblIdCliente.Text = "-";
                        txt_condicion.Text = ""; chk_sinIgv.Checked = false;
                        nud_vigencia.Value = 1;
                    }
                }
            }
            catch (Exception e)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error al guardar la cotización: " + e.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();

            fil.Hide();
            if (lsv_Det.Items.Count == 0){ fil.Show(); adv.lbl_Msm1.Text = "El carrito debe contener al menos un producto"; adv.ShowDialog(); fil.Hide(); }
            if (lblIdCliente.Text.Trim().Length < 2) { fil.Show(); adv.lbl_Msm1.Text = "Debes agregar un cliente"; adv.ShowDialog(); fil.Hide(); }
            

            Guardar_Cotizacion();
        }

        private void txt_cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_BusCli_Click(sender,e);

            }
        }

        private void lbl_BusCli_Click(object sender, EventArgs e)
        {
            Frm_ListadoCliente lis = new Frm_ListadoCliente();
            Frm_Filtro fil = new Frm_Filtro();

            fil.Show();
            Frm_ListadoCliente.tipo = txt_cliente.Text;

            lis.ShowDialog();
            fil.Hide();
            if (lis.Tag.ToString() == "A")
            {
                lblIdCliente.Text = lis.lblId.Text;
                txt_cliente.Text = lis.lblNomb.Text;
            }
        }

        private void btn_Nuevo_buscarProd_Click_1(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProd_Compra xpro = new Frm_ListadoProd_Compra();

            fil.Show();
            Frm_ListadoProd_Compra.tipoVenta = "coti";
            xpro.cbxCotizacion.Checked = true;
            xpro.ShowDialog();
            fil.Hide();

            if (xpro.Tag.ToString() == "A")
            {
                string _idProd;
                string _nomprod;
                double _cant;
                double _precio;
                double _importe;
                string _und;
                string _tipoProd;
                double _utilidad;

                if (xpro.lsv_Pedido.Items.Count > 0)
                {
                    for (int i = 0; i < xpro.lsv_Pedido.Items.Count; i++)
                    {
                        var item = xpro.lsv_Pedido.Items[i];
                        _idProd = item.SubItems[0].Text;
                        _nomprod = item.SubItems[1].Text;
                        _cant = Convert.ToDouble(item.SubItems[3].Text);
                        _precio = Convert.ToDouble(item.SubItems[4].Text);
                        _importe = Convert.ToDouble(item.SubItems[5].Text);
                        _und = item.SubItems[2].Text;
                        _tipoProd = item.SubItems[8].Text;
                        _utilidad = Convert.ToDouble(item.SubItems[6].Text);
                        Agregar_Productos_carro(_idProd, _nomprod, _cant, _precio, _importe, _und, _tipoProd, _utilidad);
                    }
                }
                else
                {
                    _idProd = xpro.lblIdProducto.Text;
                    _nomprod = xpro.lblNomProd.Text;
                    _cant = Convert.ToDouble(xpro.lblCant.Text);
                    _precio = Convert.ToDouble(xpro.lblPreUnid.Text);
                    _importe = Convert.ToDouble(xpro.lblImport.Text);
                    _und = xpro.lblUnid.Text;
                    _tipoProd = xpro.lblTipoProd.Text;
                    _utilidad = Convert.ToDouble(xpro.lblUtiUnit.Text);
                    Agregar_Productos_carro(_idProd, _nomprod, _cant, _precio, _importe, _und, _tipoProd, _utilidad);
                }


            }
        }
    }
}
