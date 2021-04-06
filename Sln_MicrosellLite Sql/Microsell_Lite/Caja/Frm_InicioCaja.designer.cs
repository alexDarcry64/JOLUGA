namespace Microsell_Lite.Caja
{
    partial class Frm_InicioCaja
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_Nomalgo = new System.Windows.Forms.Label();
            this.ElDivider1 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.txt_importe = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btn_procesar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnCancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_importe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_procesar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(564, 47);
            this.Pnl_titulo.TabIndex = 16;
            // 
            // lbl_Nomalgo
            // 
            this.lbl_Nomalgo.AutoSize = true;
            this.lbl_Nomalgo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomalgo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Nomalgo.Location = new System.Drawing.Point(132, 64);
            this.lbl_Nomalgo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nomalgo.Name = "lbl_Nomalgo";
            this.lbl_Nomalgo.Size = new System.Drawing.Size(273, 44);
            this.lbl_Nomalgo.TabIndex = 422;
            this.lbl_Nomalgo.Text = "Inicio de Caja";
            // 
            // ElDivider1
            // 
            this.ElDivider1.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.ElDivider1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ElDivider1.LineSize = 1;
            this.ElDivider1.Location = new System.Drawing.Point(28, 101);
            this.ElDivider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ElDivider1.Name = "ElDivider1";
            this.ElDivider1.Size = new System.Drawing.Size(509, 28);
            this.ElDivider1.TabIndex = 423;
            this.ElDivider1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_importe
            // 
            this.txt_importe.CaptionStyle.CaptionSize = 0;
            this.txt_importe.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_importe.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_importe.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_importe.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txt_importe.CaptionStyle.TextStyle.Text = "ElEntryBox1";
            this.txt_importe.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txt_importe.EditBoxStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_importe.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_importe.Location = new System.Drawing.Point(200, 151);
            this.txt_importe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(176, 45);
            this.txt_importe.TabIndex = 1;
            this.txt_importe.ValidationStyle.MaxLength = 150;
            this.txt_importe.ValidationStyle.PasswordChar = '\0';
            this.txt_importe.ValidationStyle.StringValidationStyle.CharacterCasing = Klik.Windows.Forms.v1.EntryLib.CharacterCasing.Upper;
            this.txt_importe.Value = "";
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_procesar.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(191)))));
            this.btn_procesar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_procesar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_procesar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_procesar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_procesar.BorderStyle.EdgeRadius = 7;
            this.btn_procesar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_procesar.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            this.btn_procesar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_procesar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_procesar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_procesar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_procesar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_procesar.Location = new System.Drawing.Point(360, 260);
            this.btn_procesar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btn_procesar.Size = new System.Drawing.Size(177, 52);
            this.btn_procesar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_procesar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_procesar.TabIndex = 425;
            this.btn_procesar.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_procesar.TextStyle.Text = "Guardar";
            this.btn_procesar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_procesar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnCancelar.BackgroundStyle.SolidColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnCancelar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnCancelar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnCancelar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btnCancelar.BorderStyle.EdgeRadius = 7;
            this.btnCancelar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnCancelar.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnCancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnCancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Location = new System.Drawing.Point(28, 260);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.btnCancelar.Size = new System.Drawing.Size(177, 52);
            this.btnCancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.TabIndex = 426;
            this.btnCancelar.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.TextStyle.Text = "Cancelar";
            this.btnCancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frm_InicioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 326);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.txt_importe);
            this.Controls.Add(this.lbl_Nomalgo);
            this.Controls.Add(this.ElDivider1);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_InicioCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Caja ";
            this.Load += new System.EventHandler(this.Frm_InicioCaja_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_InicioCaja_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_InicioCaja_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_importe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_procesar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.Label lbl_Nomalgo;
        internal Klik.Windows.Forms.v1.EntryLib.ELDivider ElDivider1;
        internal System.Windows.Forms.Panel Pnl_titulo;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_importe;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_procesar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btnCancelar;
    }
}