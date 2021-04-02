namespace Microsell_Lite.Clientes
{
    partial class Frm_ListadoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListadoCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_agregarClienteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_copiarIDProveedorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.datosCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rfc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.esta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpFechaAniv = new System.Windows.Forms.DateTimePicker();
            this.panel = new System.Windows.Forms.Panel();
            this.ltsCli = new System.Windows.Forms.ListView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNomb = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.pnlAddCliente = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.pnlAddCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 68);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.txtbuscar.Location = new System.Drawing.Point(233, 20);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(267, 33);
            this.txtbuscar.TabIndex = 15;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.OnValueChanged += new System.EventHandler(this.txtbuscar_OnValueChanged);
            this.txtbuscar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbuscar_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Buscar Proveedor");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Clientes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosToolStripMenuItem,
            this.toolStripSeparator1,
            this.btnEditarCliente,
            this.toolStripSeparator2,
            this.bt_agregarClienteTool,
            this.toolStripSeparator3,
            this.bt_copiarIDProveedorTool});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 126);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarTodosToolStripMenuItem.Image")));
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCliente.Image")));
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(195, 26);
            this.btnEditarCliente.Text = "Editar Cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // bt_agregarClienteTool
            // 
            this.bt_agregarClienteTool.Image = ((System.Drawing.Image)(resources.GetObject("bt_agregarClienteTool.Image")));
            this.bt_agregarClienteTool.Name = "bt_agregarClienteTool";
            this.bt_agregarClienteTool.Size = new System.Drawing.Size(195, 26);
            this.bt_agregarClienteTool.Text = "Agregar Cliente";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // bt_copiarIDProveedorTool
            // 
            this.bt_copiarIDProveedorTool.Image = ((System.Drawing.Image)(resources.GetObject("bt_copiarIDProveedorTool.Image")));
            this.bt_copiarIDProveedorTool.Name = "bt_copiarIDProveedorTool";
            this.bt_copiarIDProveedorTool.Size = new System.Drawing.Size(195, 26);
            this.bt_copiarIDProveedorTool.Text = "Copiar ID Cliente";
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
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.datosCli,
            this.rfc,
            this.esta});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 68);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 36);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // datosCli
            // 
            this.datosCli.Text = "Datos del Cliente";
            // 
            // rfc
            // 
            this.rfc.Text = "RFC";
            // 
            // esta
            // 
            this.esta.Text = "Estado";
            // 
            // dtpFechaAniv
            // 
            this.dtpFechaAniv.Location = new System.Drawing.Point(451, 608);
            this.dtpFechaAniv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaAniv.Name = "dtpFechaAniv";
            this.dtpFechaAniv.Size = new System.Drawing.Size(92, 22);
            this.dtpFechaAniv.TabIndex = 10;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ltsCli);
            this.panel.Location = new System.Drawing.Point(0, 110);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(551, 492);
            this.panel.TabIndex = 5;
            // 
            // ltsCli
            // 
            this.ltsCli.HideSelection = false;
            this.ltsCli.Location = new System.Drawing.Point(0, 2);
            this.ltsCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltsCli.Name = "ltsCli";
            this.ltsCli.Size = new System.Drawing.Size(551, 486);
            this.ltsCli.TabIndex = 4;
            this.ltsCli.UseCompatibleStateImageBehavior = false;
            this.ltsCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltsCli_KeyDown);
            this.ltsCli.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltsCli_MouseDoubleClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(465, 699);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 17);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "-";
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.Location = new System.Drawing.Point(487, 699);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(13, 17);
            this.lblNomb.TabIndex = 7;
            this.lblNomb.Text = "-";
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(507, 699);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(13, 17);
            this.lblRuc.TabIndex = 11;
            this.lblRuc.Text = "-";
            // 
            // pnlAddCliente
            // 
            this.pnlAddCliente.BackColor = System.Drawing.SystemColors.Window;
            this.pnlAddCliente.Controls.Add(this.btnGuardar);
            this.pnlAddCliente.Controls.Add(this.btnSalir);
            this.pnlAddCliente.Controls.Add(this.txtDireccion);
            this.pnlAddCliente.Controls.Add(this.txtRuc);
            this.pnlAddCliente.Controls.Add(this.txtNombre);
            this.pnlAddCliente.Controls.Add(this.txtId);
            this.pnlAddCliente.Controls.Add(this.label2);
            this.pnlAddCliente.Location = new System.Drawing.Point(0, 68);
            this.pnlAddCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAddCliente.Name = "pnlAddCliente";
            this.pnlAddCliente.Size = new System.Drawing.Size(571, 677);
            this.pnlAddCliente.TabIndex = 12;
            this.pnlAddCliente.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(51, 297);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(437, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(51, 234);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(437, 22);
            this.txtRuc.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 169);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(437, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 110);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(437, 22);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(175, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrar Nuevo Cliente";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Location = new System.Drawing.Point(360, 468);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(153, 53);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(360, 663);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 53);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Location = new System.Drawing.Point(51, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(175, 53);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNewCliente.Location = new System.Drawing.Point(45, 663);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(181, 53);
            this.btnNewCliente.TabIndex = 14;
            this.btnNewCliente.Text = "Nuevo Cliente";
            this.btnNewCliente.UseVisualStyleBackColor = false;
            this.btnNewCliente.Click += new System.EventHandler(this.btnNewCliente_Click);
            // 
            // Frm_ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(571, 746);
            this.Controls.Add(this.pnlAddCliente);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.lblNomb);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtpFechaAniv);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewCliente);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ListadoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Cliente";
            this.Load += new System.EventHandler(this.Frm_ListadoCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.pnlAddCliente.ResumeLayout(false);
            this.pnlAddCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditarCliente;
        private System.Windows.Forms.ToolStripMenuItem bt_agregarClienteTool;
        private System.Windows.Forms.ToolStripMenuItem bt_copiarIDProveedorTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader datosCli;
        private System.Windows.Forms.ColumnHeader rfc;
        private System.Windows.Forms.ColumnHeader esta;
        private System.Windows.Forms.DateTimePicker dtpFechaAniv;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListView ltsCli;
        internal System.Windows.Forms.Label lblRuc;
        internal System.Windows.Forms.Label lblNomb;
        internal System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlAddCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.Button btnGuardar;
    }
}