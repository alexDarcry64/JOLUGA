namespace Microsell_Lite.Utilitarios
{
    partial class Frm_Solo_Fecha
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Solo_Fecha));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.elDivider1 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.btn_Aceptar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dtpFecha = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.pnl_titu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Precio";
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.SkyBlue;
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(456, 60);
            this.pnl_titu.TabIndex = 2;
            this.pnl_titu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseMove);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_nom.Location = new System.Drawing.Point(16, 172);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(13, 18);
            this.lbl_nom.TabIndex = 4;
            this.lbl_nom.Text = "-";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 4);
            this.label4.TabIndex = 487;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elDivider1
            // 
            this.elDivider1.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.elDivider1.Location = new System.Drawing.Point(84, 129);
            this.elDivider1.Margin = new System.Windows.Forms.Padding(4);
            this.elDivider1.Name = "elDivider1";
            this.elDivider1.Size = new System.Drawing.Size(267, 28);
            this.elDivider1.TabIndex = 488;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.AllowAnimations = true;
            this.btn_Aceptar.AllowMouseEffects = true;
            this.btn_Aceptar.AllowToggling = false;
            this.btn_Aceptar.AnimationSpeed = 200;
            this.btn_Aceptar.AutoGenerateColors = false;
            this.btn_Aceptar.AutoRoundBorders = true;
            this.btn_Aceptar.AutoSizeLeftIcon = true;
            this.btn_Aceptar.AutoSizeRightIcon = true;
            this.btn_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.BackgroundImage")));
            this.btn_Aceptar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Aceptar.ButtonText = "Aceptar";
            this.btn_Aceptar.ButtonTextMarginLeft = 0;
            this.btn_Aceptar.ColorContrastOnClick = 45;
            this.btn_Aceptar.ColorContrastOnHover = 45;
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Aceptar.CustomizableEdges = borderEdges2;
            this.btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Aceptar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Aceptar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Aceptar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Aceptar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aceptar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Aceptar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Aceptar.IconMarginLeft = 11;
            this.btn_Aceptar.IconPadding = 10;
            this.btn_Aceptar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Aceptar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Aceptar.IconSize = 25;
            this.btn_Aceptar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Aceptar.IdleBorderRadius = 48;
            this.btn_Aceptar.IdleBorderThickness = 1;
            this.btn_Aceptar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Aceptar.IdleIconLeftImage = null;
            this.btn_Aceptar.IdleIconRightImage = null;
            this.btn_Aceptar.IndicateFocus = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(273, 172);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Aceptar.OnDisabledState.BorderRadius = 1;
            this.btn_Aceptar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Aceptar.OnDisabledState.BorderThickness = 1;
            this.btn_Aceptar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Aceptar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Aceptar.OnDisabledState.IconLeftImage = null;
            this.btn_Aceptar.OnDisabledState.IconRightImage = null;
            this.btn_Aceptar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Aceptar.onHoverState.BorderRadius = 1;
            this.btn_Aceptar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Aceptar.onHoverState.BorderThickness = 1;
            this.btn_Aceptar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_Aceptar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.onHoverState.IconLeftImage = null;
            this.btn_Aceptar.onHoverState.IconRightImage = null;
            this.btn_Aceptar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Aceptar.OnIdleState.BorderRadius = 1;
            this.btn_Aceptar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Aceptar.OnIdleState.BorderThickness = 1;
            this.btn_Aceptar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Aceptar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.OnIdleState.IconLeftImage = null;
            this.btn_Aceptar.OnIdleState.IconRightImage = null;
            this.btn_Aceptar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Aceptar.OnPressedState.BorderRadius = 1;
            this.btn_Aceptar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Aceptar.OnPressedState.BorderThickness = 1;
            this.btn_Aceptar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_Aceptar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.OnPressedState.IconLeftImage = null;
            this.btn_Aceptar.OnPressedState.IconRightImage = null;
            this.btn_Aceptar.Size = new System.Drawing.Size(171, 50);
            this.btn_Aceptar.TabIndex = 489;
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Aceptar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Aceptar.TextMarginLeft = 0;
            this.btn_Aceptar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Aceptar.UseDefaultRadiusAndThickness = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowAnimations = true;
            this.btnCancelar.AllowMouseEffects = true;
            this.btnCancelar.AllowToggling = false;
            this.btnCancelar.AnimationSpeed = 200;
            this.btnCancelar.AutoGenerateColors = false;
            this.btnCancelar.AutoRoundBorders = true;
            this.btnCancelar.AutoSizeLeftIcon = true;
            this.btnCancelar.AutoSizeRightIcon = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackColor1 = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.ButtonTextMarginLeft = 0;
            this.btnCancelar.ColorContrastOnClick = 45;
            this.btnCancelar.ColorContrastOnHover = 45;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges1;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelar.IconMarginLeft = 11;
            this.btnCancelar.IconPadding = 10;
            this.btnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.IdleBorderColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.IdleBorderRadius = 48;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.IdleIconLeftImage = null;
            this.btnCancelar.IdleIconRightImage = null;
            this.btnCancelar.IndicateFocus = false;
            this.btnCancelar.Location = new System.Drawing.Point(36, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.OnDisabledState.BorderRadius = 1;
            this.btnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnDisabledState.BorderThickness = 1;
            this.btnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.OnDisabledState.IconLeftImage = null;
            this.btnCancelar.OnDisabledState.IconRightImage = null;
            this.btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancelar.onHoverState.BorderRadius = 1;
            this.btnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.onHoverState.BorderThickness = 1;
            this.btnCancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancelar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.onHoverState.IconLeftImage = null;
            this.btnCancelar.onHoverState.IconRightImage = null;
            this.btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.OnIdleState.BorderRadius = 1;
            this.btnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnIdleState.BorderThickness = 1;
            this.btnCancelar.OnIdleState.FillColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnIdleState.IconLeftImage = null;
            this.btnCancelar.OnIdleState.IconRightImage = null;
            this.btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.BorderRadius = 1;
            this.btnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnPressedState.BorderThickness = 1;
            this.btnCancelar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnPressedState.IconLeftImage = null;
            this.btnCancelar.OnPressedState.IconRightImage = null;
            this.btnCancelar.Size = new System.Drawing.Size(156, 50);
            this.btnCancelar.TabIndex = 490;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.TextMarginLeft = 0;
            this.btnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.UseDefaultRadiusAndThickness = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpFecha.BorderRadius = 1;
            this.dtpFecha.Color = System.Drawing.Color.Silver;
            this.dtpFecha.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtpFecha.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpFecha.DisabledColor = System.Drawing.Color.Gray;
            this.dtpFecha.DisplayWeekNumbers = false;
            this.dtpFecha.DPHeight = 0;
            this.dtpFecha.FillDatePicker = true;
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFecha.ForeColor = System.Drawing.Color.Black;
            this.dtpFecha.Icon = ((System.Drawing.Image)(resources.GetObject("dtpFecha.Icon")));
            this.dtpFecha.IconColor = System.Drawing.Color.Gray;
            this.dtpFecha.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpFecha.LeftTextMargin = 5;
            this.dtpFecha.Location = new System.Drawing.Point(84, 90);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(0, 32);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(284, 32);
            this.dtpFecha.TabIndex = 491;
            this.dtpFecha.Value = new System.DateTime(2021, 3, 26, 11, 38, 0, 0);
            // 
            // Frm_Solo_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(456, 251);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.pnl_titu);
            this.Controls.Add(this.elDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Solo_Fecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad";
            this.Load += new System.EventHandler(this.Frm_Solo_Canti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Solo_Canti_KeyDown);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_titu;
        internal System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label label4;
        private Klik.Windows.Forms.v1.EntryLib.ELDivider elDivider1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Aceptar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelar;
        public Bunifu.UI.WinForms.BunifuDatePicker dtpFecha;
    }
}