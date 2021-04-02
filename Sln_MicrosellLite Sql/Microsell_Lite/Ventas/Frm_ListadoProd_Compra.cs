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
using Microsell_Lite.Productos;
using Microsell_Lite.Compras;

namespace Microsell_Lite.Ventas
{
    public partial class Frm_ListadoProd_Compra : Form
    {
        public static string tipoVenta = "";
        public Frm_ListadoProd_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Explor_Proveedor_Load(object sender, EventArgs e)
        {
            Configurar_listView();
            Configurar_listView_Pedido();
            if (tipoVenta.Trim() == "compra" || tipoVenta == "coti")
            {
                cbxTodos_Sin.Checked = true;
            }
            else
            {
                cbxTodos_Sin.Checked = false;
            }
            Cargar_todos_Productos();
            txtbuscar.Focus();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void Frm_Explor_Proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();
            if(e.Button== MouseButtons.Left)
            {
                obj.Mover_formulario(this);
            }
        }

        //configurar lisview

        private void Configurar_listView()
        {
            var lis = ltsProductos;

            ltsProductos.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("ID", 100, HorizontalAlignment.Left);//0
            lis.Columns.Add("Nombre del Producto", 240, HorizontalAlignment.Left);//0
            lis.Columns.Add("Stock", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Pre Compra", 80, HorizontalAlignment.Left);//0
            lis.Columns.Add("Venta Menor", 120, HorizontalAlignment.Left);//0}
            lis.Columns.Add("Venta Mayor", 120, HorizontalAlignment.Left);//0}
            lis.Columns.Add("Foto", 120, HorizontalAlignment.Left);//0}
            lis.Columns.Add("marca", 120, HorizontalAlignment.Left);//0}
            lis.Columns.Add("Und", 164, HorizontalAlignment.Left);//0
            lis.Columns.Add("Utilidad Unit", 164, HorizontalAlignment.Left);//0

            lis.Columns.Add("Estado", 120, HorizontalAlignment.Left);//0}
            lis.Columns.Add("TipoProd", 164, HorizontalAlignment.Left);//0
        }

        private void Configurar_listView_Pedido()
        {
            var lis = ltsProductos;

            ltsProductos.Items.Clear();
            lis.Columns.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //configurar las columnas

            lis.Columns.Add("ID Producto", 100, HorizontalAlignment.Left);//0
            lis.Columns.Add("Nombre del Producto", 190, HorizontalAlignment.Left);//0
            lis.Columns.Add("Und", 50, HorizontalAlignment.Left);//0
            lis.Columns.Add("Cant", 50, HorizontalAlignment.Left);//0
            lis.Columns.Add("Pre", 50, HorizontalAlignment.Left);//0
            lis.Columns.Add("Importe", 65, HorizontalAlignment.Left);//0
            lis.Columns.Add("Utilidad Unit", 100, HorizontalAlignment.Left);//0}
            lis.Columns.Add("Ganancia Total", 100, HorizontalAlignment.Left);//0}
            lis.Columns.Add("Tipo Prod", 100, HorizontalAlignment.Left);//0}
        }

        //llenar list view
        private void llenar_Listview(DataTable data)
        {
            try
            {
                string idprod = "";
                double stock = 0;
                ltsProductos.Items.Clear();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow dr = data.Rows[i];

                    idprod = dr["Id_Pro"].ToString();
                    stock = Convert.ToDouble(dr["Stock_Actual"]);

                    if (cbxTodos_Sin.Checked == true)
                    {
                        ListViewItem list = new ListViewItem(dr["Id_Pro"].ToString());
                        list.SubItems.Add(dr["Descripcion_Larga"].ToString());
                        list.SubItems.Add(dr["Stock_Actual"].ToString());
                        list.SubItems.Add(dr["Pre_Compra"].ToString());
                        list.SubItems.Add(dr["Pre_vntaxMenor"].ToString());
                        list.SubItems.Add(dr["Pre_vntaxMayor"].ToString());
                        list.SubItems.Add(dr["Foto"].ToString());
                        list.SubItems.Add(dr["Marca"].ToString());
                        list.SubItems.Add(dr["UndMedida"].ToString());
                        list.SubItems.Add(dr["UtilidadUnit"].ToString());
                        list.SubItems.Add(dr["Estado_Pro"].ToString());
                        list.SubItems.Add(dr["TipoProdcto"].ToString());
                        ltsProductos.Items.Add(list);//si no ponemos esto el list nunca llenara
                    }
                    else
                    {
                        if (stock > 0)
                        {
                            ListViewItem list = new ListViewItem(dr["Id_Pro"].ToString());
                            list.SubItems.Add(dr["Descripcion_Larga"].ToString());
                            list.SubItems.Add(dr["Stock_Actual"].ToString());
                            list.SubItems.Add(dr["Pre_Compra"].ToString());
                            list.SubItems.Add(dr["Pre_vntaxMenor"].ToString());
                            list.SubItems.Add(dr["Pre_vntaxMayor"].ToString());
                            list.SubItems.Add(dr["Foto"].ToString());
                            list.SubItems.Add(dr["Marca"].ToString());
                            list.SubItems.Add(dr["UndMedida"].ToString());
                            list.SubItems.Add(dr["UtilidadUnit"].ToString());
                            list.SubItems.Add(dr["Estado_Pro"].ToString());
                            list.SubItems.Add(dr["TipoProdcto"].ToString());
                            ltsProductos.Items.Add(list);//si no ponemos esto el list nunca llenara
                        }
                    }
                }
                PintarFilas();
                pnlmsj.Visible = false;
            }
            catch (Exception ex)
            {

                string sm = ex.Message;
            }
            

            
           }

        private void Agregar_Producto_Pedido(string xxidPro, string xxnombre,string xxund, double xxcant, double xxprecio, double xximporte, double xxutilidad_unit, double xxgananciaTotal, string xxtipoProd)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();

            if (lsv_Pedido.Items.Count == 0)
            {
                ListViewItem item = new ListViewItem();
                item = lsv_Pedido.Items.Add(xxidPro.Trim());
                item.SubItems.Add(xxnombre.Trim());
                item.SubItems.Add(xxund.ToString());
                item.SubItems.Add(xxcant.ToString());
                item.SubItems.Add(xxprecio.ToString("###0.00"));
                item.SubItems.Add(xximporte.ToString("###0.00"));
                item.SubItems.Add(xxutilidad_unit.ToString("###0.00"));
                item.SubItems.Add(xxgananciaTotal.ToString("###0.00"));
                item.SubItems.Add(xxtipoProd.ToString());

                Calcular();
            }
            else
            {
                for (int i = 0; i < lsv_Pedido.Items.Count; i++)
                {
                    if (lsv_Pedido.Items[i].Text.Trim() == xxidPro.Trim())
                    {
                        fil.Show();
                        adv.lbl_Msm1.Text = "El producto ya fue agregado al carrito de compras";
                        adv.ShowDialog();
                        fil.Hide();
                    }
                }

                ListViewItem item = new ListViewItem();
                item = lsv_Pedido.Items.Add(xxidPro.Trim());
                item.SubItems.Add(xxnombre.Trim());
                item.SubItems.Add(xxund.ToString());
                item.SubItems.Add(xxcant.ToString());
                item.SubItems.Add(xxprecio.ToString("###0.00"));
                item.SubItems.Add(xximporte.ToString("###0.00"));
                item.SubItems.Add(xxutilidad_unit.ToString("###0.00"));
                item.SubItems.Add(xxgananciaTotal.ToString("###0.00"));
                item.SubItems.Add(xxtipoProd.ToString());

                Calcular();
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

            for (int i = 0; i < lsv_Pedido.Items.Count; i++)
            {
                xcant = Convert.ToDouble(lsv_Pedido.Items[i].SubItems[3].Text);
                xprecio = Convert.ToDouble(lsv_Pedido.Items[i].SubItems[4].Text);

                ximporte = xprecio * xcant;
                lsv_Pedido.Items[i].SubItems[5].Text = ximporte.ToString("###0.00");
                xtotal = xtotal + Convert.ToDouble(lsv_Pedido.Items[i].SubItems[5].Text);
            }
            xsubtotal = xtotal / 1.16;

            xigv = xsubtotal * 0.16;
            
            lblTotal.Text = xtotal.ToString("###0.00");
            lblTotalItem.Text = Convert.ToString(lsv_Pedido.Items.Count);
            btnCarrito.Text = Convert.ToString(lsv_Pedido.Items.Count);
        }

        private void Cargar_todos_Productos()
        {
            RN_Productos obj = new RN_Productos();
            DataTable dato = new DataTable();

            dato = obj.RN_Mostrar_Todos_Productos();
            if(dato.Rows.Count>0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsProductos.Items.Clear();
                pnlmsj.Visible = true;
            }
        }


        private void buscar_Productos(string valor)
        {
            RN_Productos obj = new RN_Productos();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Productos(valor);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview(dato);
            }
            else
            {
                ltsProductos.Items.Clear();
                pnlmsj.Visible = true;
            }
        }

        private void txtbuscar_OnValueChanged(object sender, EventArgs e)
       {
            if(txtbuscar.Text.Trim().Length > 2)
            {
                buscar_Productos(txtbuscar.Text);
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtbuscar.Text.Trim().Length > 2)
                {
                    buscar_Productos(txtbuscar.Text);

                    if (ltsProductos.Items.Count > 0)
                    {
                        ltsProductos.Focus();
                        ltsProductos.Items[0].Selected = true;
                    }
                }
                else
                {
                    Cargar_todos_Productos();
                    if (ltsProductos.Items.Count > 0)
                    {
                        ltsProductos.Focus();
                        ltsProductos.Items[0].Selected = true;
                    }
                }

            }
        }

        private void Seleccionar_Producto_ModoCotizacion()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Cantidad solo = new Frm_Solo_Cantidad();
            Frm_Advertencia adv = new Frm_Advertencia();

            if (ltsProductos.SelectedIndices.Count == 0) { fil.Show(); adv.lbl_Msm1.Text = "Debes seleccionar un producto"; adv.ShowDialog(); fil.Hide(); ; return; }
            double stock = 0;
            string estadoProd = "";
            double xpreCompr = 0;
            double xUtilidad = 0;

            var lis = ltsProductos.SelectedItems[0];

            lblNomProd.Text = lis.SubItems[1].Text;
            lblPreUnid.Text = lis.SubItems[4].Text;
            lblIdProducto.Text = lis.SubItems[0].Text;
            stock = Convert.ToDouble(lis.SubItems[2].Text);
            lblUtiUnit.Text = lis.SubItems[9].Text;
            estadoProd = lis.SubItems[10].Text;
            xpreCompr = Convert.ToDouble(lis.SubItems[3].Text);
            lblTipoProd.Text = lis.SubItems[11].Text;
            lblUnid.Text = lis.SubItems[8].Text;

            if (estadoProd.Trim() == "Eliminado") { fil.Show(); adv.lbl_Msm1.Text = "El producto esta eliminado"; adv.ShowDialog(); fil.Hide(); return; }
            //if (lblTipoProd.Text.Trim().ToString() == "Producto")
            //{
            //    if (stock == 0) { fil.Show(); MessageBox.Show("El producto no cuenta con la cantidad suficiente", "Seleccion de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); fil.Hide(); return; }
            //}

            if (cbxLlenarCarrito.Checked == true)
            {
                fil.Show();
                solo.txt_cant.Text = "1";
                solo.ShowDialog();
                fil.Hide();
                if (solo.Tag.ToString() == "A")
                {
                    lblCant.Text = solo.txt_cant.Text;
                    solo.txt_cant.Text = "";
                    //xUtilidad = Convert.ToDouble(lblCant.Text) * Convert.ToDouble(xpreCompr);
                    //lblUtiUnit.Text = xUtilidad.ToString("###0.00");
                    double importxx = Convert.ToDouble(lblCant.Text) * Convert.ToDouble(lblPreUnid.Text);
                    lblImport.Text = importxx.ToString("###0.00");
                    lblTotal.Text = importxx.ToString(); ;

                    Agregar_Producto_Pedido(lblIdProducto.Text, lblNomProd.Text, lblUnid.Text, Convert.ToDouble(lblCant.Text),
                        Convert.ToDouble(lblPreUnid.Text), Convert.ToDouble(lblImport.Text), Convert.ToDouble(lblUtiUnit.Text),
                        Convert.ToDouble(lblTotal.Text), lblTipoProd.Text);
                }
            }
            else
            {
                fil.Show();
                solo.txt_cant.Text = "1";
                solo.ShowDialog();
                fil.Hide();
                

                try
                {
                    if (solo.Tag.ToString() == "A")
                    {
                        lblCant.Text = solo.txt_cant.Text;
                        solo.txt_cant.Text = "";

                        double importxx = Convert.ToDouble(lblCant.Text) * Convert.ToDouble(lblPreUnid.Text);
                        lblImport.Text = importxx.ToString("###0.00");
                        //xUtilidad = Convert.ToDouble(lblCant.Text) * Convert.ToDouble(xpreCompr);
                        //lblUtiUnit.Text = xUtilidad.ToString("###0.00");
                        this.Tag = "A";
                        solo.Close();
                        this.Close();
                    }
                }
                catch (Exception)
                {

                    solo.Tag = "";
                    solo.Close();
                }
            }
        }

        private void LimpiarLabels()
        {
            lblCant.Text = "0";
            lblIdProducto.Text = "";
            lblImport.Text = "0";
            lblNomProd.Text = "";
            lblUnid.Text = "";
            lblUtiUnit.Text = "0";
            lblTotal.Text = "0";

        }

        private void Seleccionar_Producto_Vender()
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Edit_Cant solo = new Frm_Edit_Cant(); 
            Frm_Advertencia adv = new Frm_Advertencia();

            if (ltsProductos.SelectedIndices.Count == 0){ fil.Show(); adv.lbl_Msm1.Text = "Debes seleccionar un producto"; adv.ShowDialog(); fil.Hide(); return; }

            if (cbxCotizacion.Checked == true)
            {
                Seleccionar_Producto_ModoCotizacion();
            }
            else
            {
                double stock = 0;
                string estadoProd = "";
                double xpreCompr = 0;
                double xUtilidad = 0;

                var lis = ltsProductos.SelectedItems[0];

                lblNomProd.Text = lis.SubItems[1].Text;
                lblPreUnid.Text = lis.SubItems[4].Text;
                lblIdProducto.Text = lis.SubItems[0].Text;
                stock = Convert.ToDouble(lis.SubItems[2].Text);
                lblUtiUnit.Text = lis.SubItems[9].Text;
                estadoProd = lis.SubItems[10].Text;
                xpreCompr = Convert.ToDouble(lis.SubItems[3].Text);
                lblTipoProd.Text = lis.SubItems[11].Text;
                lblUnid.Text = lis.SubItems[8].Text;

                if (estadoProd.Trim() == "Eliminado") { fil.Show(); adv.lbl_Msm1.Text = "El producto esta eliminado"; adv.ShowDialog(); fil.Hide(); return; }
                if (lblTipoProd.Text.Trim().ToString() == "Producto")
                {
                    if (stock == 0) { fil.Show(); adv.lbl_Msm1.Text = "El producto no cuenta con la cantidad suficiente"; adv.ShowDialog(); fil.Hide(); return; }
                }
                if (cbxLlenarCarrito.Checked == true)
                {
                    fil.Show();
                    solo.lblTipoProd.Text = lblTipoProd.Text;
                    solo.lblStock.Text = stock.ToString();
                    solo.txt_cant.Text = "1";
                    solo.ShowDialog();
                    fil.Hide();
                    if (solo.Tag.ToString() == "A")
                    {
                        lblCant.Text = solo.txt_cant.Text;
                        solo.txt_cant.Text = "";
                        //xUtilidad = Convert.ToDouble(lblCant.Text) - Convert.ToDouble(xpreCompr);
                        //lblUtiUnit.Text = xUtilidad.ToString("###0.00");
                        double importxx = Convert.ToDouble(lblCant.Text) * Convert.ToDouble(lblPreUnid.Text);
                        lblImport.Text = importxx.ToString("###0.00");
                        lblTotal.Text = importxx.ToString(); ;

                        Agregar_Producto_Pedido(lblIdProducto.Text,lblNomProd.Text, lblUnid.Text, Convert.ToDouble(lblCant.Text),
                            Convert.ToDouble(lblPreUnid.Text),Convert.ToDouble(lblImport.Text),Convert.ToDouble(lblUtiUnit.Text),
                            Convert.ToDouble(lblTotal.Text),lblTipoProd.Text);
                        LimpiarLabels();
                    }
                }
                else
                {
                    fil.Show();
                    solo.lblTipoProd.Text = lblTipoProd.Text;
                    solo.lblStock.Text = stock.ToString();
                    solo.txt_cant.Text = "1";
                    solo.ShowDialog();
                    fil.Hide();

                    try
                    {
                        if (solo.Tag.ToString() == "A")
                        {
                            lblCant.Text = solo.txt_cant.Text;
                            solo.txt_cant.Text = "";
                            //xUtilidad = Convert.ToDouble(lblCant.Text) - Convert.ToDouble(xpreCompr);
                            //lblUtiUnit.Text = xUtilidad.ToString("###0.00");
                            double importxx = Convert.ToDouble(lblCant.Text) * Convert.ToDouble(lblPreUnid.Text);
                            lblImport.Text = importxx.ToString("###0.00");
                            this.Tag = "A";
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {

                        solo.Tag = "";
                        this.Close();
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_AddProducto ad = new Frm_AddProducto();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if(ad.Tag.ToString()=="A")
            {
                Cargar_todos_Productos();
            }
        }

        private void bt_copiarIDProveedorTool_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if(ltsProductos.SelectedIndices.Count==0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsProductos.SelectedItems[0];
                string idprovee = lis.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(idprovee.Trim());
            }
        }

        private void bt_agregarProveedorTool_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_AddProducto ad = new Frm_AddProducto();

            fil.Show();
            ad.ShowDialog();
            fil.Hide();

            if (ad.Tag.ToString() == "A")
            {
                Cargar_todos_Productos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_EditProducto edi = new Frm_EditProducto();

            if (ltsProductos.SelectedIndices.Count == 0)
            {
                fil.Show();
                ver.ShowDialog();
                fil.Hide();
            }
            else
            {
                var lis = ltsProductos.SelectedItems[0];
                string idproducto = lis.SubItems[0].Text;

                fil.Show();
                edi.Tag = idproducto;
                edi.ShowDialog();
                fil.Hide();

                if(edi.Tag.ToString()=="A")
                {
                    Cargar_todos_Productos();
                }
                
            }
        }

        private void PintarFilas()
        {
            int cont = 1;
            //for (int i=0; i < ltsProductos.Items.Count; i++)
            //{
            //    if (cont % 2 == 0)
            //    {

            //    }
            //    else
            //    {
            //        ltsProductos.Items[i].BackColor = Color.WhiteSmoke;
            //    }
            //    cont += 1;
            //}

            for (int i = 0; i < ltsProductos.Items.Count; i++)
            {
                ltsProductos.Items[i].SubItems[2].BackColor = Color.Linen;
                ltsProductos.Items[i].SubItems[3].BackColor = Color.Beige;
                ltsProductos.Items[i].SubItems[5].BackColor = Color.MintCream;
                ltsProductos.Items[i].SubItems[6].BackColor = Color.AliceBlue;

                ltsProductos.Items[i].SubItems[2].Font = new System.Drawing.Font("Oxygen",10,FontStyle.Bold);
                ltsProductos.Items[i].SubItems[5].Font = new System.Drawing.Font("Oxygen", 10, FontStyle.Bold);
                ltsProductos.Items[i].UseItemStyleForSubItems = false;
            }
        }

        private void btnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

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

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            btnEditar_Click(sender,e);
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_todos_Productos();
        }

        private void ltsProductos_DoubleClick(object sender, EventArgs e)
        {
            btnElegir_Click(sender, e);
        }

        private void ltsProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnElegir_Click(sender, e);
            }
        }

        private void Frm_ListadoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Tag = "";
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnContinuarVenta_Click(sender,e);
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.A))
            {
                txtbuscar.Focus();
            }
        }

        private void btn_Nuevo_buscarProd_Click(object sender, EventArgs e)
        {
        }

        private void cbxTodos_Sin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTodos_Sin.Checked == true)
            {
                Cargar_todos_Productos();
            }
            else
            {
                Cargar_todos_Productos();
            }
        }

        private void lsv_Pedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adv = new Frm_Advertencia();

            if (lsv_Pedido.SelectedIndices.Count == 0)
            {
                fil.Show();
                adv.lbl_Msm1.Text = "Selecciona un producto a quitar";
                adv.ShowDialog();
                fil.Hide();
            }
            else
            {
                    int i;
                    var lis = lsv_Pedido.SelectedItems[0];
                    for (i = lsv_Pedido.SelectedItems.Count - 1; i >= 0; i--)
                    {
                    lsv_Pedido.Items.Remove(lsv_Pedido.SelectedItems[i]);
                    }
                    Calcular();
            }
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (pnlCarrito.Visible == true)
            {
                pnlCarrito.Visible = false;
            }
            else
            {
                pnlCarrito.Visible = true;
            }
        }

        private void btnElegirProducto(object sender, EventArgs e)
        {
            Seleccionar_Producto_Vender();
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            Seleccionar_Producto_Vender();
        }

        private void btnContinuarVenta_Click(object sender, EventArgs e)
        {
            if (lsv_Pedido.Items.Count > 0)
            {
                cbxLlenarCarrito.Checked = true;
                this.Tag = "A";
                this.Close();
            }
        }
    }
}
