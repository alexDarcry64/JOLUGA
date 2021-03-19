namespace Microsell_Lite.Productos
{
    partial class Frm_ListadoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListadoProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimi = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ltsProductos = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_agregarProveedorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_copiarIDProveedorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlmsj = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlmsj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btn_minimi);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 31);
            this.panel1.TabIndex = 0;
            // 
            // btn_minimi
            // 
            this.btn_minimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimi.FlatAppearance.BorderSize = 0;
            this.btn_minimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimi.ForeColor = System.Drawing.Color.White;
            this.btn_minimi.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimi.Image")));
            this.btn_minimi.Location = new System.Drawing.Point(1149, -3);
            this.btn_minimi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimi.Name = "btn_minimi";
            this.btn_minimi.Size = new System.Drawing.Size(43, 39);
            this.btn_minimi.TabIndex = 8;
            this.btn_minimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_minimi.UseVisualStyleBackColor = true;
            this.btn_minimi.Click += new System.EventHandler(this.btn_minimi_Click);
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
            this.btn_cerrar.Location = new System.Drawing.Point(1207, 4);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(29, 23);
            this.btn_cerrar.TabIndex = 7;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Explorador de Productos";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalItems);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 56);
            this.panel2.TabIndex = 1;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(465, 31);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(26, 17);
            this.lblTotalItems.TabIndex = 14;
            this.lblTotalItems.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(434, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total Items";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.HintForeColor = System.Drawing.Color.Black;
            this.txtbuscar.HintText = "";
            this.txtbuscar.isPassword = false;
            this.txtbuscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbuscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineThickness = 3;
            this.txtbuscar.Location = new System.Drawing.Point(581, 15);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(379, 33);
            this.txtbuscar.TabIndex = 13;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.OnValueChanged += new System.EventHandler(this.txtbuscar_OnValueChanged);
            this.txtbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(967, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Buscar Proveedor");
            // 
            // ltsProductos
            // 
            this.ltsProductos.ContextMenuStrip = this.contextMenuStrip1;
            this.ltsProductos.HideSelection = false;
            this.ltsProductos.Location = new System.Drawing.Point(13, 130);
            this.ltsProductos.Name = "ltsProductos";
            this.ltsProductos.Size = new System.Drawing.Size(1188, 419);
            this.ltsProductos.TabIndex = 2;
            this.ltsProductos.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosToolStripMenuItem,
            this.toolStripSeparator1,
            this.btnEditarProducto,
            this.toolStripSeparator2,
            this.bt_agregarProveedorTool,
            this.toolStripSeparator3,
            this.bt_copiarIDProveedorTool});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 126);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarTodosToolStripMenuItem.Image")));
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProducto.Image")));
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(209, 26);
            this.btnEditarProducto.Text = "Editar producto";
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // bt_agregarProveedorTool
            // 
            this.bt_agregarProveedorTool.Image = ((System.Drawing.Image)(resources.GetObject("bt_agregarProveedorTool.Image")));
            this.bt_agregarProveedorTool.Name = "bt_agregarProveedorTool";
            this.bt_agregarProveedorTool.Size = new System.Drawing.Size(209, 26);
            this.bt_agregarProveedorTool.Text = "Agregar Producto";
            this.bt_agregarProveedorTool.Click += new System.EventHandler(this.bt_agregarProveedorTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // bt_copiarIDProveedorTool
            // 
            this.bt_copiarIDProveedorTool.Image = ((System.Drawing.Image)(resources.GetObject("bt_copiarIDProveedorTool.Image")));
            this.bt_copiarIDProveedorTool.Name = "bt_copiarIDProveedorTool";
            this.bt_copiarIDProveedorTool.Size = new System.Drawing.Size(209, 26);
            this.bt_copiarIDProveedorTool.Text = "Copiar ID Producto";
            this.bt_copiarIDProveedorTool.Click += new System.EventHandler(this.bt_copiarIDProveedorTool_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "id Prod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion del producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pr Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pre Venta1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(791, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pre Venta2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(897, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Utilidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1004, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total S";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1114, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Estado";
            // 
            // pnlmsj
            // 
            this.pnlmsj.Controls.Add(this.pictureBox2);
            this.pnlmsj.Controls.Add(this.label12);
            this.pnlmsj.Controls.Add(this.label6);
            this.pnlmsj.Location = new System.Drawing.Point(13, 277);
            this.pnlmsj.Name = "pnlmsj";
            this.pnlmsj.Size = new System.Drawing.Size(1188, 272);
            this.pnlmsj.TabIndex = 13;
            this.pnlmsj.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(551, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(336, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(521, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "Intenta realizar tu busqueda con otros valores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(433, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Busqueda sin resultados";
            // 
            // Frm_ListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 581);
            this.Controls.Add(this.pnlmsj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltsProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListadoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Explor_Proveedor_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Explor_Proveedor_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlmsj.ResumeLayout(false);
            this.pnlmsj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_minimi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView ltsProductos;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditarProducto;
        private System.Windows.Forms.ToolStripMenuItem bt_agregarProveedorTool;
        private System.Windows.Forms.ToolStripMenuItem bt_copiarIDProveedorTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlmsj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label13;
    }
}