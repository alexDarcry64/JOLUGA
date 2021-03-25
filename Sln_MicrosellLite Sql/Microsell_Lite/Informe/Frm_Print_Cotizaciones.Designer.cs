namespace Microsell_Lite.Informe
{
    partial class Frm_Print_Cotizaciones
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
            this.VzrCoti = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VzrCoti
            // 
            this.VzrCoti.ActiveViewIndex = -1;
            this.VzrCoti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VzrCoti.Cursor = System.Windows.Forms.Cursors.Default;
            this.VzrCoti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VzrCoti.Location = new System.Drawing.Point(0, 0);
            this.VzrCoti.Name = "VzrCoti";
            this.VzrCoti.ShowGroupTreeButton = false;
            this.VzrCoti.Size = new System.Drawing.Size(732, 522);
            this.VzrCoti.TabIndex = 0;
            this.VzrCoti.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Print_Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 522);
            this.Controls.Add(this.VzrCoti);
            this.Name = "Frm_Print_Cotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Print_Cotizaciones";
            this.Load += new System.EventHandler(this.Frm_Print_Cotizaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VzrCoti;
    }
}