namespace Microsell_Lite.Proveedores
{
    partial class Frm_Explor_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Explor_Proveedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimi = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ltsProveedores = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_agregarProveedorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_copiarIDProveedorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btn_minimi);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 25);
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
            this.btn_minimi.Location = new System.Drawing.Point(682, -2);
            this.btn_minimi.Name = "btn_minimi";
            this.btn_minimi.Size = new System.Drawing.Size(32, 32);
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
            this.btn_cerrar.Location = new System.Drawing.Point(726, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(22, 19);
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
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Explorador de Proveedores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 46);
            this.panel2.TabIndex = 1;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtbuscar.ForeColor = System.Drawing.Color.White;
            this.txtbuscar.HintForeColor = System.Drawing.Color.Empty;
            this.txtbuscar.HintText = "";
            this.txtbuscar.isPassword = false;
            this.txtbuscar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbuscar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtbuscar.LineThickness = 3;
            this.txtbuscar.Location = new System.Drawing.Point(436, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(284, 27);
            this.txtbuscar.TabIndex = 13;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbuscar.OnValueChanged += new System.EventHandler(this.txtbuscar_OnValueChanged);
            this.txtbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(725, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Buscar Proveedor");
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(64, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar Proveedor");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEditar_MouseMove);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(10, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 32);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnAgregar, "Nuevo Proveedor");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ltsProveedores
            // 
            this.ltsProveedores.ContextMenuStrip = this.contextMenuStrip1;
            this.ltsProveedores.HideSelection = false;
            this.ltsProveedores.Location = new System.Drawing.Point(10, 92);
            this.ltsProveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ltsProveedores.Name = "ltsProveedores";
            this.ltsProveedores.Size = new System.Drawing.Size(743, 251);
            this.ltsProveedores.TabIndex = 2;
            this.ltsProveedores.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosToolStripMenuItem,
            this.toolStripSeparator1,
            this.editarProveedorToolStripMenuItem,
            this.toolStripSeparator2,
            this.bt_agregarProveedorTool,
            this.toolStripSeparator3,
            this.bt_copiarIDProveedorTool});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 110);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // editarProveedorToolStripMenuItem
            // 
            this.editarProveedorToolStripMenuItem.Name = "editarProveedorToolStripMenuItem";
            this.editarProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarProveedorToolStripMenuItem.Text = "Editar proveedor";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // bt_agregarProveedorTool
            // 
            this.bt_agregarProveedorTool.Name = "bt_agregarProveedorTool";
            this.bt_agregarProveedorTool.Size = new System.Drawing.Size(180, 22);
            this.bt_agregarProveedorTool.Text = "Agregar Proveedor";
            this.bt_agregarProveedorTool.Click += new System.EventHandler(this.bt_agregarProveedorTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // bt_copiarIDProveedorTool
            // 
            this.bt_copiarIDProveedorTool.Name = "bt_copiarIDProveedorTool";
            this.bt_copiarIDProveedorTool.Size = new System.Drawing.Size(180, 22);
            this.bt_copiarIDProveedorTool.Text = "Copiar ID Proveedor";
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
            // Frm_Explor_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(758, 366);
            this.Controls.Add(this.ltsProveedores);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Explor_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Explor_Proveedor_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Explor_Proveedor_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_minimi;
        private System.Windows.Forms.Button btnAgregar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListView ltsProveedores;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bt_agregarProveedorTool;
        private System.Windows.Forms.ToolStripMenuItem bt_copiarIDProveedorTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}