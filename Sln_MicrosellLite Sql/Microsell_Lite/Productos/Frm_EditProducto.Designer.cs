namespace Microsell_Lite.Productos
{
    partial class Frm_EditProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditProducto));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_listo = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_cancel = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.txtdescripcion_producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkidcodigobarra = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPesoUnit = new System.Windows.Forms.TextBox();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtPrecioVentaMayor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecioVentaMenor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.picbuscarProveedor = new System.Windows.Forms.PictureBox();
            this.lblidproveedor = new System.Windows.Forms.Label();
            this.picbuscarCategoria = new System.Windows.Forms.PictureBox();
            this.lblidcat = new System.Windows.Forms.Label();
            this.picbuscarMarca = new System.Windows.Forms.PictureBox();
            this.lblidmarca = new System.Windows.Forms.Label();
            this.txtClaveSat = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnl_titu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_listo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnl_titu.Controls.Add(this.btn_cerrar);
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(1208, 53);
            this.pnl_titu.TabIndex = 1;
            this.pnl_titu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseMove);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1152, 5);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(43, 39);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Productos";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdProducto.Location = new System.Drawing.Point(185, 95);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(247, 29);
            this.txtIdProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id Producto";
            // 
            // btn_listo
            // 
            this.btn_listo.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_listo.BackgroundStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_listo.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_listo.BorderStyle.EdgeRadius = 7;
            this.btn_listo.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_listo.BorderStyle.SolidColor = System.Drawing.Color.DodgerBlue;
            this.btn_listo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_listo.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_listo.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_listo.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_listo.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_listo.Location = new System.Drawing.Point(537, 780);
            this.btn_listo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_listo.Name = "btn_listo";
            this.btn_listo.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btn_listo.Size = new System.Drawing.Size(209, 60);
            this.btn_listo.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_listo.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_listo.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listo.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_listo.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_listo.TabIndex = 15;
            this.btn_listo.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listo.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_listo.TextStyle.Text = "Listo";
            this.btn_listo.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_listo.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_listo.Click += new System.EventHandler(this.btn_listo_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_cancel.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancel.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancel.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancel.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancel.BorderStyle.EdgeRadius = 7;
            this.btn_cancel.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_cancel.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_cancel.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_cancel.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Location = new System.Drawing.Point(181, 780);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicSilver;
            this.btn_cancel.Size = new System.Drawing.Size(209, 60);
            this.btn_cancel.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.DimGray;
            this.btn_cancel.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DimGray;
            this.btn_cancel.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_cancel.StateStyles.PressedStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancel.StateStyles.PressedStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancel.StateStyles.PressedStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.TextStyle.Text = "Cancelar";
            this.btn_cancel.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txtdescripcion_producto
            // 
            this.txtdescripcion_producto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion_producto.ForeColor = System.Drawing.Color.DimGray;
            this.txtdescripcion_producto.Location = new System.Drawing.Point(261, 140);
            this.txtdescripcion_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdescripcion_producto.Name = "txtdescripcion_producto";
            this.txtdescripcion_producto.Size = new System.Drawing.Size(897, 29);
            this.txtdescripcion_producto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion del Producto:";
            // 
            // txtproveedor
            // 
            this.txtproveedor.Enabled = false;
            this.txtproveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproveedor.ForeColor = System.Drawing.Color.DimGray;
            this.txtproveedor.Location = new System.Drawing.Point(185, 196);
            this.txtproveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(561, 29);
            this.txtproveedor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proveedor:";
            // 
            // txtmarca
            // 
            this.txtmarca.Enabled = false;
            this.txtmarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.ForeColor = System.Drawing.Color.DimGray;
            this.txtmarca.Location = new System.Drawing.Point(185, 245);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(560, 29);
            this.txtmarca.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Marca:";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Enabled = false;
            this.txtcategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.ForeColor = System.Drawing.Color.DimGray;
            this.txtcategoria.Location = new System.Drawing.Point(892, 239);
            this.txtcategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(267, 29);
            this.txtcategoria.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unidad de Medida:";
            // 
            // piclogo
            // 
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(908, 478);
            this.piclogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(208, 159);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 20;
            this.piclogo.TabStop = false;
            this.piclogo.Click += new System.EventHandler(this.piclogo_Click);
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.Location = new System.Drawing.Point(937, 682);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(110, 17);
            this.lblAbrir.TabIndex = 14;
            this.lblAbrir.Text = "..Buscar Imagen";
            this.lblAbrir.Click += new System.EventHandler(this.lblAbrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioCompra.Location = new System.Drawing.Point(181, 473);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(565, 29);
            this.txtPrecioCompra.TabIndex = 10;
            this.txtPrecioCompra.Text = "0";
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 478);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Precio Compra:";
            // 
            // checkidcodigobarra
            // 
            this.checkidcodigobarra.AutoSize = true;
            this.checkidcodigobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkidcodigobarra.Location = new System.Drawing.Point(457, 97);
            this.checkidcodigobarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkidcodigobarra.Name = "checkidcodigobarra";
            this.checkidcodigobarra.Size = new System.Drawing.Size(152, 24);
            this.checkidcodigobarra.TabIndex = 25;
            this.checkidcodigobarra.Text = "ID Codigo Barra";
            this.checkidcodigobarra.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(788, 310);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "PesoUnit:";
            // 
            // txtPesoUnit
            // 
            this.txtPesoUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoUnit.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesoUnit.Location = new System.Drawing.Point(892, 304);
            this.txtPesoUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesoUnit.Name = "txtPesoUnit";
            this.txtPesoUnit.Size = new System.Drawing.Size(267, 29);
            this.txtPesoUnit.TabIndex = 7;
            this.txtPesoUnit.Text = "0";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.ForeColor = System.Drawing.Color.DimGray;
            this.txtUtilidad.Location = new System.Drawing.Point(892, 386);
            this.txtUtilidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(265, 29);
            this.txtUtilidad.TabIndex = 8;
            this.txtUtilidad.Text = "0";
            this.txtUtilidad.TextChanged += new System.EventHandler(this.txtUtilidad_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(800, 391);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Utilidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(872, 805);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Precios del Producto";
            this.label12.Visible = false;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "Producto",
            "Servicio"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(183, 309);
            this.cmbTipoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(564, 24);
            this.cmbTipoProducto.TabIndex = 4;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "KGM",
            "H87",
            "AB",
            "XBX",
            "MTR",
            "UND",
            "GLN",
            "LTR",
            "MTK",
            "GRM"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(187, 385);
            this.cmbUnidadMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(560, 24);
            this.cmbUnidadMedida.TabIndex = 9;
            // 
            // txtPrecioVentaMayor
            // 
            this.txtPrecioVentaMayor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaMayor.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioVentaMayor.Location = new System.Drawing.Point(193, 633);
            this.txtPrecioVentaMayor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioVentaMayor.Name = "txtPrecioVentaMayor";
            this.txtPrecioVentaMayor.Size = new System.Drawing.Size(553, 29);
            this.txtPrecioVentaMayor.TabIndex = 12;
            this.txtPrecioVentaMayor.Text = "0";
            this.txtPrecioVentaMayor.TextChanged += new System.EventHandler(this.txtPrecioVentaMayor_TextChanged);
            this.txtPrecioVentaMayor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVentaMayor_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 638);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Precio Venta Mayor:";
            // 
            // txtPrecioVentaMenor
            // 
            this.txtPrecioVentaMenor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVentaMenor.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioVentaMenor.Location = new System.Drawing.Point(193, 562);
            this.txtPrecioVentaMenor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioVentaMenor.MaxLength = 2;
            this.txtPrecioVentaMenor.Name = "txtPrecioVentaMenor";
            this.txtPrecioVentaMenor.Size = new System.Drawing.Size(552, 29);
            this.txtPrecioVentaMenor.TabIndex = 11;
            this.txtPrecioVentaMenor.Text = "0";
            this.txtPrecioVentaMenor.TextChanged += new System.EventHandler(this.txtPrecioVentaMenor_TextChanged);
            this.txtPrecioVentaMenor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVentaMenor_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 574);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Precio Venta Menor:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioVenta.Location = new System.Drawing.Point(195, 706);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(551, 29);
            this.txtPrecioVenta.TabIndex = 13;
            this.txtPrecioVenta.Text = "0";
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(63, 711);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "Precio Venta:";
            // 
            // picbuscarProveedor
            // 
            this.picbuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("picbuscarProveedor.Image")));
            this.picbuscarProveedor.Location = new System.Drawing.Point(709, 196);
            this.picbuscarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbuscarProveedor.Name = "picbuscarProveedor";
            this.picbuscarProveedor.Size = new System.Drawing.Size(37, 30);
            this.picbuscarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbuscarProveedor.TabIndex = 39;
            this.picbuscarProveedor.TabStop = false;
            this.picbuscarProveedor.Click += new System.EventHandler(this.picbuscarProveedor_Click);
            // 
            // lblidproveedor
            // 
            this.lblidproveedor.AutoSize = true;
            this.lblidproveedor.Location = new System.Drawing.Point(753, 208);
            this.lblidproveedor.Name = "lblidproveedor";
            this.lblidproveedor.Size = new System.Drawing.Size(12, 17);
            this.lblidproveedor.TabIndex = 40;
            this.lblidproveedor.Text = ".";
            // 
            // picbuscarCategoria
            // 
            this.picbuscarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("picbuscarCategoria.Image")));
            this.picbuscarCategoria.Location = new System.Drawing.Point(1121, 240);
            this.picbuscarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbuscarCategoria.Name = "picbuscarCategoria";
            this.picbuscarCategoria.Size = new System.Drawing.Size(37, 30);
            this.picbuscarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbuscarCategoria.TabIndex = 41;
            this.picbuscarCategoria.TabStop = false;
            this.picbuscarCategoria.Click += new System.EventHandler(this.picbuscarCategoria_Click);
            // 
            // lblidcat
            // 
            this.lblidcat.AutoSize = true;
            this.lblidcat.Location = new System.Drawing.Point(437, 309);
            this.lblidcat.Name = "lblidcat";
            this.lblidcat.Size = new System.Drawing.Size(12, 17);
            this.lblidcat.TabIndex = 42;
            this.lblidcat.Text = ".";
            // 
            // picbuscarMarca
            // 
            this.picbuscarMarca.Image = ((System.Drawing.Image)(resources.GetObject("picbuscarMarca.Image")));
            this.picbuscarMarca.Location = new System.Drawing.Point(709, 246);
            this.picbuscarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbuscarMarca.Name = "picbuscarMarca";
            this.picbuscarMarca.Size = new System.Drawing.Size(37, 30);
            this.picbuscarMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbuscarMarca.TabIndex = 43;
            this.picbuscarMarca.TabStop = false;
            this.picbuscarMarca.Click += new System.EventHandler(this.picbuscarMarca_Click);
            // 
            // lblidmarca
            // 
            this.lblidmarca.AutoSize = true;
            this.lblidmarca.Location = new System.Drawing.Point(440, 256);
            this.lblidmarca.Name = "lblidmarca";
            this.lblidmarca.Size = new System.Drawing.Size(12, 17);
            this.lblidmarca.TabIndex = 44;
            this.lblidmarca.Text = ".";
            // 
            // txtClaveSat
            // 
            this.txtClaveSat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveSat.ForeColor = System.Drawing.Color.DimGray;
            this.txtClaveSat.Location = new System.Drawing.Point(892, 196);
            this.txtClaveSat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClaveSat.Name = "txtClaveSat";
            this.txtClaveSat.Size = new System.Drawing.Size(267, 29);
            this.txtClaveSat.TabIndex = 5;
            this.txtClaveSat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveSat_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(783, 201);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Clave SAT:";
            // 
            // Frm_EditProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 874);
            this.Controls.Add(this.txtClaveSat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblidmarca);
            this.Controls.Add(this.picbuscarMarca);
            this.Controls.Add(this.lblidcat);
            this.Controls.Add(this.picbuscarCategoria);
            this.Controls.Add(this.lblidproveedor);
            this.Controls.Add(this.picbuscarProveedor);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPrecioVentaMenor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrecioVentaMayor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPesoUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkidcodigobarra);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAbrir);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdescripcion_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_titu);
            this.Controls.Add(this.btn_listo);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_EditProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reg_Prod";
            this.Load += new System.EventHandler(this.Frm_Reg_Prod_Load);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_listo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuscarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_cancel;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_listo;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkidcodigobarra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecioVentaMenor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrecioVentaMayor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPesoUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblidproveedor;
        private System.Windows.Forms.PictureBox picbuscarProveedor;
        private System.Windows.Forms.PictureBox picbuscarCategoria;
        private System.Windows.Forms.Label lblidcat;
        private System.Windows.Forms.Label lblidmarca;
        private System.Windows.Forms.PictureBox picbuscarMarca;
        private System.Windows.Forms.TextBox txtClaveSat;
        private System.Windows.Forms.Label label16;
    }
}