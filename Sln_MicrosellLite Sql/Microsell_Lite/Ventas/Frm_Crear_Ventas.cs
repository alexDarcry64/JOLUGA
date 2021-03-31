using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsell_Lite.Compras;

//importar:
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using System.IO;
using Microsell_Lite.Utilitarios;
using Microsell_Lite.Productos;
using Microsell_Lite.Clientes;
using Microsell_Lite.Informe;


namespace Microsell_Lite.Ventas
{
    public partial class Frm_Crear_Ventas : Form
    {
        public Frm_Crear_Ventas()
        {
            InitializeComponent();
        }

        private void Frm_Ventana_Ventas_Load(object sender, EventArgs e)
        {
           
            Configurar_listView();
            Llenar_Combo_Doc();

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

      
        private void btn_Nuevo_buscarProd_Click(object sender, EventArgs e)
        {

            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProd_Compra xpro = new Frm_ListadoProd_Compra();

            fil.Show();
            Frm_ListadoProd_Compra.tipoVenta = "venta";
            xpro.cbxCotizacion.Checked = false;
            xpro.ShowDialog();

            fil.Hide();

            if (xpro.Tag.ToString()=="A")
            {
                string _idprod ;
                string _nomprod ;
                double _cant =0;
                double _precio=0 ;
                double _importe=0 ;
                string _und ;
                string _tipoProd ;
                Double _Utili_Unit ;

                if (xpro.lsv_Pedido.Items.Count >0)
                {
                    for (int i = 0; i < xpro.lsv_Pedido.Items.Count; i++)
                    {
                        var item =xpro.lsv_Pedido.Items[i];
                        _idprod = item.SubItems[0].Text;
                        _nomprod = item.SubItems[1].Text;
                        _cant =Convert.ToDouble(item.SubItems[3].Text);
                        _precio = Convert.ToDouble(item.SubItems[4].Text);
                        _importe= Convert.ToDouble(item.SubItems[5].Text);
                        _und = item.SubItems[2].Text;
                        _tipoProd = item.SubItems[8].Text;
                        _Utili_Unit = Convert.ToDouble(item.SubItems[6].Text );

                        Agregar_Productos_alCarrito(_idprod, _nomprod, _cant, _precio, _importe, _und, _tipoProd, _Utili_Unit);
                    }
                }
                else
                {
                    //para agregar de uno en Uno:
                   _idprod = xpro.lblIdProducto.Text;
                    _nomprod = xpro.lblNomProd.Text;
                   _cant = Convert.ToDouble(xpro.lblCant.Text);
                   _precio = Convert.ToDouble(xpro.lblPreUnid.Text);
                     _importe = Convert.ToDouble(xpro.lblPreUnid.Text);
                     _und = xpro.lblUnid.Text;
                    _tipoProd = xpro.lblTipoProd.Text;
                     _Utili_Unit = Convert.ToDouble(xpro.lblUtiUnit.Text);

                    Agregar_Productos_alCarrito(_idprod, _nomprod, _cant, _precio, _importe, _und, _tipoProd, _Utili_Unit);
                }              
                
            }

        }      




        private void Agregar_Productos_alCarrito(string xidprod, string xnomprod, double xcant, double xprecio, double ximporte, string xund, string xtipoProd, double xutili_unit)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();
            try
            {
               

                if (lsv_Det.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(xidprod);
                    item.SubItems.Add(xnomprod.Trim());
                    item.SubItems.Add(xcant.ToString());
                    item.SubItems.Add(xprecio.ToString("###0.00"));
                    item.SubItems.Add(ximporte.ToString("###0.00"));
                    item.SubItems.Add(xtipoProd.ToString());
                    item.SubItems.Add(xund.ToString());
                    item.SubItems.Add(xutili_unit .ToString("###0.00"));
                    item.SubItems.Add(xutili_unit.ToString("###0.00"));

                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;
                    pnl_sinProd.Visible = false;
                }
                else
                {
                    //validar de que el producvto no se ingrese dos veces
                    for (int i = 0; i < lsv_Det.Items.Count; i++)
                    {
                        if (lsv_Det.Items[i].Text.Trim() == xidprod.Trim())
                        {
                            fil.Show();
                            adv.lbl_Msm1.Text = "El producto ya fue agregado al carrito de compras";
                            adv.ShowDialog();
                            fil.Hide();
                            return;
                        }
                    }

                    //lo añadimos:
                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(xidprod);
                    item.SubItems.Add(xnomprod.Trim());
                    item.SubItems.Add(xcant.ToString());
                    item.SubItems.Add(xprecio.ToString("###0.00"));
                    item.SubItems.Add(ximporte.ToString("###0.00"));
                    item.SubItems.Add(xtipoProd.ToString());
                    item.SubItems.Add(xund.ToString());
                    item.SubItems.Add(xutili_unit.ToString("###0.00"));
                    item.SubItems.Add(xutili_unit.ToString("###0.00"));

                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;

                }

            }
            catch (Exception ex)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Error: "+ ex.Message;
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
            double xuti_unit = 0;
            double ximport_Uti = 0;
            double xTotalGanancia = 0;

          
            for (int i = 0; i < lsv_Det.Items.Count; i++)
            {
                xcant = Convert.ToDouble(lsv_Det.Items[i].SubItems[2].Text);
                xprecio = Convert.ToDouble(lsv_Det.Items[i].SubItems[3].Text);

                //calculo:
                ximporte = xprecio * xcant;
                lsv_Det.Items[i].SubItems[4].Text = ximporte.ToString("###0.00");

                //utilidad:
                xuti_unit = Convert.ToDouble(lsv_Det.Items[i].SubItems[7].Text);
                ximport_Uti = xuti_unit * xcant;
                lsv_Det.Items[i].SubItems[8].Text = ximport_Uti.ToString("###0.00");




                //caluclo del total:
                xtotal = xtotal + Convert.ToDouble(lsv_Det.Items[i].SubItems[4].Text);

               xTotalGanancia  = xTotalGanancia  + Convert.ToDouble(lsv_Det.Items[i].SubItems[8].Text);

            }
            //calcular el IGV: IVA
            xsubtotal = xtotal / 1.16;
            xigv = xsubtotal * 0.16;

            lbl_subtotal.Text = xsubtotal.ToString("###0.00");
            lbl_igv.Text = xigv.ToString("###0.00");
            lbl_TotalPagar.Text = xtotal.ToString("###0.00");
            lbl_totalGanancia.Text = xTotalGanancia.ToString("###0.00");

            lbl_son.Text = Numalet.ToString(lbl_TotalPagar.Text);
            let.LetraCapital = chkCapital.Checked;
            if (!actualizado) ActualizarCong();

                   


        }


        Numalet let = new Numalet();
        Boolean actualizado = false;

        private void ActualizarCong()
        {
            actualizado = true;
            chkCapital.Checked = let.LetraCapital;
            if (lbl_son.Text.Length >0)
            {
                lbl_son.Text = let.ToCustomString(lbl_TotalPagar.Text);
                actualizado = false;
            }
        }



        private void bt_add_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_ListadoProd_Compra xpro = new Frm_ListadoProd_Compra();

            fil.Show();
            Frm_ListadoProd_Compra.tipoVenta = "venta";
            xpro.cbxCotizacion.Checked = false;
            xpro.ShowDialog();

            fil.Hide();

            if (xpro.Tag.ToString() == "A")
            {
                string _idprod = xpro.lblIdProducto.Text;
                string _nomprod = xpro.lblNomProd.Text;
                double _cant = Convert.ToDouble(xpro.lblCant.Text);
                double _precio = Convert.ToDouble(xpro.lblPreUnid.Text);
                double _importe = Convert.ToDouble(xpro.lblPreUnid.Text);
                string _und = xpro.lblUnid.Text;
                string _tipoProd = xpro.lblTipoProd.Text;
                Double _Utili_Unit = Convert.ToDouble(xpro.lblUtiUnit.Text);

                Agregar_Productos_alCarrito(_idprod, _nomprod, _cant, _precio, _importe, _und, _tipoProd, _Utili_Unit);


            }
        }

        private void bt_editPre_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Edit_Precio solo = new Frm_Edit_Precio();
            Frm_Advertencia adv = new Frm_Advertencia();

            if (lsv_Det.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Seleccionar el Producto a Editar su Precio";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {
                double precio_Ingresado = 0;
                double cantIngresado = 0;
                double Precio_Editado = 0;
                double cantEditado = 0;
                string xidProd = "";
                double xUti_unit = 0;

                xidProd = lsv_Det.SelectedItems[0].SubItems[0].Text;
                precio_Ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[3].Text);
                cantIngresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[2].Text);
                fil.Show();
                solo.txtPrecio.Text = precio_Ingresado.ToString("###0.00");
                solo.txtCantidad.Text = cantIngresado.ToString();
                solo.idProducto = xidProd.Trim();
                solo.ShowDialog();
                fil.Hide();


                if (solo.Tag.ToString() == "A")
                {
                    Precio_Editado = Convert.ToDouble(solo.txtPrecio.Text);
                    cantEditado = Convert.ToDouble(solo.txtCantidad.Text);
                    xUti_unit = Convert.ToDouble(solo.Lbl_UtilidadUnit.Text);
                    lsv_Det.SelectedItems[0].SubItems[3].Text = Precio_Editado.ToString("###0.00");
                    lsv_Det.SelectedItems[0].SubItems[2].Text = cantEditado.ToString("###0.00");
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
                adv.lbl_Msm1.Text = "Seleccionar el Producto para Quitar";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {

                fil.Show();
                sino.Lbl_msm1.Text = "Estas Seguro de Quitar este producto del Carrito?";
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
                          

        private void Guardar_Pedido()
        {
            RN_Pedido obj = new RN_Pedido();
            EN_Pedido ped = new EN_Pedido();
            EN_Det_Pedido det = new EN_Det_Pedido();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            try
            {
                txt_nroPed.Text = RN_TipoDoc.RN_Nro_id(10);

                ped.Id_pedido = txt_nroPed.Text;
                ped.IdCliente = lbl_idcliente.Text;
                ped.SubTotal = Convert.ToDouble(lbl_subtotal.Text);
                ped.Igv = Convert.ToDouble(lbl_igv.Text);
                ped.TotalPedido = Convert.ToDouble(lbl_TotalPagar.Text);
                ped.IdUsuario = Convert.ToInt32(Cls_Libreria.IdUsu);
                ped.TotalGanancia = Convert.ToDouble(lbl_totalGanancia.Text);

                obj.RN_Insertar_Pedido(ped);              

                if (BD_Pedido.guarda ==true )
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(10);
                    //giuardar el detalle del pedido:

                    det.IdPed = txt_nroPed.Text;

                    for (int i =0; i < lsv_Det.Items.Count; i++)
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
                adv.lbl_Msm1.Text = "Error al Guardar: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }


        }

              

        private void txt_cliente_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode ==Keys.Enter)
            {
                lbl_BusClien_Click(sender, e);
            }


        }

       

        private void lbl_BusClien_Click(object sender, EventArgs e)
        {
            Frm_ListadoCliente lis = new Frm_ListadoCliente();
            Frm_Filtro fil = new Frm_Filtro();

            fil.Show();
            Frm_ListadoCliente.tipo = txt_cliente.Text;
            lis.ShowDialog();
            fil.Hide();

            if (lis.Tag.ToString() == "A")
            {
                lbl_idcliente.Text = lis.lblId.Text;
                txt_cliente.Text = lis.lblNomb.Text;
                Leer_Datos_DelCliente(lbl_idcliente.Text);
            }
        }

        private void Llenar_Combo_Doc()
        {
            RN_TipoDoc obj = new RN_TipoDoc();
            DataTable dato = new DataTable();

            dato = obj.RN_Listar_Docs_Especial();

            if (dato.Rows.Count > 0)
            {
                var cbo = cboTipoDoc;
                cbo.DataSource = dato;
                cbo.DisplayMember = "Documento";
                cbo.ValueMember = "Id_Tipo";
                cbo.SelectedIndex = 0;
            }
        }

        private void Leer_Datos_DelCliente(string idCliente)
        {
            RN_Cliente obj = new RN_Cliente();
            DataTable data = new DataTable();
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            double x_limit_credit = 0;

            try
            {
                data = obj.RN_Buscar_Cliente_Valor(idCliente,"Activo");
                if (data.Rows.Count > 0)
                {
                    txtRfc.Text = Convert.ToString(data.Rows[0]["RFC"]);
                    txtDireccion.Text = Convert.ToString(data.Rows[0]["Direccion"]);
                    x_limit_credit = Convert.ToDouble(data.Rows[0]["Limit_Credit"]);
                    lblLimiteCredito.Text = x_limit_credit.ToString("###0.00");
                }

            }
            catch (Exception ex)
            {

                string msm = ex.Message;
                fil.Show();
                adv.lbl_Msm1.Text = "Error: " + ex.Message;
                adv.ShowDialog();
                fil.Hide();
            }
        }

        private bool Validar_Antes_Vender()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if (lsv_Det.Items.Count == 0) { fil.Show(); ver.lbl_Msm1.Text = "Debes agregar un producto al carrito"; ver.ShowDialog(); fil.Hide(); return false; }
            if (Convert.ToInt32(lbl_idcliente.Text.Length) < 2) { fil.Show(); ver.lbl_Msm1.Text = "Debes agregar un cliente"; ver.ShowDialog(); fil.Hide(); lbl_idcliente.Focus(); return false; }
            if (cboTipoPago.SelectedIndex == -1) { fil.Show(); ver.lbl_Msm1.Text = "Elige el tipo de pago"; ver.ShowDialog(); fil.Hide(); cboTipoPago.Focus(); return false; }
            if (cboTipoDoc.SelectedIndex == -1) { fil.Show(); ver.lbl_Msm1.Text = "Elige un tipo de comprobante"; ver.ShowDialog(); fil.Hide(); cboTipoDoc.Focus(); return false; }
            return true;
        }

        private void GuardarDocumento()
        {
            RN_Documento obj = new RN_Documento();
            EN_Documento doc = new EN_Documento();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            try
            {
                txtNroDoc.Text = RN_TipoDoc.RN_Nro_id(Convert.ToInt32(cboTipoDoc.SelectedValue));
                doc.IdDoc = txtNroDoc.Text;
                doc.IdPedido = txt_nroPed.Text;
                doc.IdTipo = Convert.ToInt32(cboTipoDoc.SelectedValue);
                doc.FechaDoc = dtp_FechaEmi.Value;
                doc.Importe = Convert.ToDouble(lbl_TotalPagar.Text);
                doc.TipoPago = cboTipoDoc.Text;
                doc.NrOperacion = txtNroOperacion.Text;
                doc.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                doc.Igv = Convert.ToDouble(lbl_igv.Text);
                doc.SonLetra = lbl_son.Text;
                doc.TotalGanancia = Convert.ToDouble(lbl_totalGanancia.Text);

                obj.RN_Registrar_Documento(doc);

                if (BD_Documento.seguardo == true)
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(Convert.ToInt32(cboTipoDoc.SelectedValue));
                }
            }
            catch (Exception ex)
            {

                fil.Show();
                ver.lbl_Msm1.Text = "Ha ocurrido un error: "+ex.Message;
                ver.ShowDialog();
                fil.Hide(); 
            }
        }

        private void Guardar_IngresoCaja()
        {
            RN_Caja obj = new RN_Caja();
            EN_Caja cja = new EN_Caja();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            try
            {
                cja.FechaCaja = dtp_FechaEmi.Value;
                cja.TipoCaja = "Entrada";
                cja.Concepto = "Ventas al publico";
                cja.DePara_Cliente = txt_cliente.Text;
                cja.Nr_Documento = txtNroDoc.Text;
                cja.ImporteCaja = Convert.ToDouble(lbl_TotalPagar.Text);
                cja.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                cja.TotalUtilidad = Convert.ToDouble(lbl_totalGanancia.Text);
                cja.TipoPago = cboTipoPago.Text;
                cja.GeneradoPor = cboTipoDoc.Text;
                obj.RN_Registrar_Movimiento_Caja(cja);
            }
            catch (Exception ex)
            {
                fil.Show();
                ver.lbl_Msm1.Text = "Ha ocurrido un error: " + ex.Message;
                ver.ShowDialog();
                fil.Hide();
            }
        }

        int producto_krd = 0;

        private void Registrar_Movimiento_Kardex()
        {
            RN_Kardex obj = new RN_Kardex();
            EN_Kardexcs kar = new EN_Kardexcs();
            RN_Productos pro = new RN_Productos();
            DataTable dato = new DataTable();
            DataTable datopro = new DataTable();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            string xidKardex = "";
            int xItem = 0;
            double stockProd = 0;
            double precioCompraPro = 0;
            string xidProd = "";
            double xcant = 0;
            string xTipoProd = "";

            try
            {
                for (int i = 0; i < lsv_Det.Items.Count; i++)
                {
                    var lis = lsv_Det.Items[i];

                    xidProd = lis.SubItems[0].Text;
                    xcant = Convert.ToDouble(lis.SubItems[2].Text);
                    xTipoProd = lis.SubItems[5].Text;

                    if (obj.RN_VerificarProducto_Cardex(xidProd.Trim()) == true)
                    {

                        dato = obj.RN_KardexDetalle_Producto(xidProd.Trim());
                        if (dato.Rows.Count > 0)
                        {
                            xidKardex = Convert.ToString(dato.Rows[0]["Id_krdx"]);
                            xItem = dato.Rows.Count;

                            datopro = pro.RN_Buscar_Productos(xidProd.Trim());
                            stockProd = Convert.ToDouble(datopro.Rows[0]["Stock_Actual"]);
                            precioCompraPro = Convert.ToDouble(datopro.Rows[0]["Pre_Compra"]);

                            kar.Idkardex = xidKardex;
                            kar.Item = xItem + 1;
                            kar.Doc_soporte = txtNroDoc.Text;
                            kar.Det_operacion = "Por ventas al publico";
                            kar.Cantidad_in = 0;
                            kar.Precio_in = 0;
                            kar.Total_in = 0;
                            kar.Cantidad_out = xcant;
                            kar.Precio_out = precioCompraPro;
                            kar.Importe_total_out = xcant * precioCompraPro;

                            kar.Cantidad_saldo = stockProd - xcant;
                            kar.Promedio = precioCompraPro;
                            kar.Total_saldo = precioCompraPro * kar.Cantidad_saldo;

                            obj.RN_Registrar_Detalle_Kardex(kar);

                            pro.RN_Restar_Stock_Producto(xidProd.Trim(), xcant);

                            producto_krd += 1;
                        }
                    }
                }
                if (true)
                {

                }
            }
            catch (Exception ex)
            {

                fil.Show();
                ver.lbl_Msm1.Text = "Ha ocurrido un error: " + ex.Message;
                ver.ShowDialog();
                fil.Hide();
            }

        }

        private void Registrar_Detalle_Credito(string idCredito)
        {
            EN_Det_Credito det = new EN_Det_Credito();
            RN_Credito obj = new RN_Credito();

            try
            {
                det.IdCredito = idCredito;
                det.Acuenta = Convert.ToDouble(lblACuenta.Text);
                det.SaldoActual = Convert.ToDouble(lblSaldo.Text);
                det.FechaPago = dtp_FechaEmi.Value;
                det.TipoPago = "Efectivo";
                det.NroOperacion = "-";
                det.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                obj.RN_Registrar_Detalle_Credito(det);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Crear_Registro_Credito()
        {
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Exito exito = new Frm_Exito();
            RN_Credito obj = new RN_Credito();
            EN_Credito cre = new EN_Credito();
            EN_Det_Credito det = new EN_Det_Credito();
            RN_Caja objCaja = new RN_Caja();
            EN_Caja cja = new EN_Caja();

            string idCredito = "";

            try
            {
                idCredito = RN_TipoDoc.RN_Nro_id(12);
                cre.IdCredito = idCredito;
                cre.IdDoc = txtNroDoc.Text;
                cre.FechaCredito = dtp_FechaEmi.Value;
                cre.NomCliente = txt_cliente.Text;
                cre.TotalCredito = Convert.ToDouble(lbl_TotalPagar.Text);

                if (Convert.ToDouble(lblACuenta.Text) == 0)
                {
                    cre.SaldoPdnte = Convert.ToDouble(lbl_TotalPagar.Text);
                }

                else if (Convert.ToDouble(lblACuenta.Text) > 0)
                {
                    cre.SaldoPdnte = Convert.ToDouble(lblSaldoPendiente.Text);
                }

                cre.FechaVencimiento = dtpVencimientoSaldo.Value;
                obj.RN_Registrar_Credito(cre);

                if (BD_Credito.credSaved == true)
                {
                    RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(12);

                    if (Convert.ToDouble(lblACuenta.Text) > 0)
                    {
                        Registrar_Detalle_Credito(idCredito);
                            cja.FechaCaja = dtp_FechaEmi.Value;
                            cja.TipoCaja = "Entrada";
                            cja.Concepto = "Abono de credito";
                            cja.DePara_Cliente = txt_cliente.Text;
                            cja.Nr_Documento = txtNroDoc.Text;
                            cja.ImporteCaja = Convert.ToDouble(lblACuenta.Text);
                            cja.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                            cja.TotalUtilidad = Convert.ToDouble(lbl_totalGanancia.Text);
                            cja.TipoPago = "Efectivo";
                            cja.GeneradoPor = "Abono";

                        objCaja.RN_Registrar_Movimiento_Caja(cja);

                        cja.FechaCaja = dtp_FechaEmi.Value;
                        cja.TipoCaja = "Entrada";
                        cja.Concepto = "Ventas al publico a credito";
                        cja.DePara_Cliente = txt_cliente.Text;
                        cja.Nr_Documento = txtNroDoc.Text;
                        cja.ImporteCaja = Convert.ToDouble(lbl_TotalPagar.Text);
                        cja.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu);
                        cja.TotalUtilidad = 0;
                        cja.TipoPago = "Credito";
                        cja.GeneradoPor = cboTipoDoc.Text;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Exito exito = new Frm_Exito();
            Frm_Tipo_Pago_Credito cred = new Frm_Tipo_Pago_Credito();
            try
                {
                if (Validar_Antes_Vender() == true)
                {

                    if (cboTipoPago.SelectedIndex == 2)
                    {
                        fil.Show();
                        cred.limpiar();
                        cred.lblTotalCuenta.Text = lbl_TotalPagar.Text;
                        cred.ShowDialog();
                        fil.Hide();

                        if (cred.Tag.ToString() == "A")
                        {
                            lblACuenta.Text = cred.txtCuenta.Text;
                            lblSaldo.Text = cred.lblSaldo.Text;
                            dtpVencimientoSaldo.Value = cred.dtpVencimiento.Value;

                        }
                    }

                    Guardar_Pedido();

                    if (BD_Pedido.guarda == true && BD_Pedido.detalleguarda == true)
                    {
                        GuardarDocumento();

                        if (BD_Documento.seguardo == true)
                        {
                            if (cboTipoPago.SelectedIndex == 0 || cboTipoPago.SelectedIndex == 1)
                            {
                                Guardar_IngresoCaja();
                            }

                            else if (cboTipoPago.SelectedIndex == 2)
                            {
                                Crear_Registro_Credito();
                            }
                            else if (cboTipoPago.SelectedIndex == 3)
                            {
                               // dassdad
                            }

                            if (BD_Caja.seguardo == true)
                            {
                                Registrar_Movimiento_Kardex();

                                if (BD_Kardex.seguardo == true)
                                {
                                    fil.Show();
                                    exito.lbl_Msm1.Text = "La venta se ha desarrollado exitosamente";
                                    exito.ShowDialog();
                                    fil.Hide();

                                    //imprimir

                                    LimpiarTodo();
                                    pnl_sinProd.Visible = true;
                                }
                            }
                        }
                    }
                }
                }
                catch (Exception ex)
                {
                    fil.Show();
                    ver.lbl_Msm1.Text = "Ha ocurrido un error: " + ex.Message;
                    ver.ShowDialog();
                    fil.Hide();
                }
        }

        private void LimpiarTodo()
        {
            lsv_Det.Items.Clear();
            txt_cliente.Text = "";
            lbl_idcliente.Text = "";
            lbl_totalGanancia.Text = "0";
            lbl_subtotal.Text = "0";
            lbl_igv.Text = "0";
            lbl_totalGanancia.Text = "0";
            lblLimiteCredito.Text = "0";
            cboTipoPago.SelectedIndex = -1;
            cboTipoPago.SelectedIndex = -1;
            lblSaldoPendiente.Text = "0";
            lblSaldoVale.Text = "0";
        }

        private void txt_cliente_DoubleClick(object sender, EventArgs e)
        {
            lbl_BusClien_Click(sender, e);
        }

        private void Frm_Crear_Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_Nuevo_buscarProd_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar_Cotizacion();
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

                Guardar_Pedido();
                if (BD_Pedido.guarda == true && BD_Pedido.detalleguarda == true)
                {
                    txt_NroCotiza.Text = RN_TipoDoc.RN_Nro_id(11);
                    coti.IdCotizacion = txt_NroCotiza.Text;
                    coti.IdPedido = txt_nroPed.Text;
                    coti.FechaCotizacion = dtp_FechaEmi.Value;
                    coti.Vigencia = 15;
                    coti.TotalCoti = Convert.ToDouble(lbl_TotalPagar.Text);
                    coti.Condiciones = "Cotizacion creada apartir de una venta pausada";
                    coti.PrecioConIgv = "Si";
                    coti.EstadoCoti = "Pendiente";

                    obj.RN_Registrar_Cotizacion(coti);

                    if (BD_Cotizacion.guardo == true)
                    {

                        //Mandar a imprimir cotizacion
                        fil.Show();
                        informeCot.Tag = txt_NroCotiza.Text;
                        informeCot.Crear_Impresion_Cotizacion();
                        informeCot.ShowDialog();
                        fil.Hide();


                        RN_TipoDoc.RN_Actualizar_NumeroCorrelativo_Producto(11);
                        fil.Show();
                        ex.lbl_Msm1.Text = "Se ha creado una cotizacion nro: " + txt_NroCotiza.Text + " para el cliente.";
                        ex.ShowDialog();
                        fil.Hide();

                        txtBuscar.Text = txt_NroCotiza.Text;

                        pnl_sinProd.Visible = true;
                        lsv_Det.Items.Clear();
                        txt_cliente.Text = "";
                        txt_NroCotiza.Text = "";
                        txt_nroPed.Text = "";
                        lbl_idcliente.Text = "-";
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
    }
}
