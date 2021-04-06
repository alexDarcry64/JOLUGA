namespace Microsell_Lite.Compras
{
    partial class Form_VerDet_Compra
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
            this.lsv_Detalle = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsv_Detalle
            // 
            this.lsv_Detalle.HideSelection = false;
            this.lsv_Detalle.Location = new System.Drawing.Point(12, 12);
            this.lsv_Detalle.Name = "lsv_Detalle";
            this.lsv_Detalle.Size = new System.Drawing.Size(776, 385);
            this.lsv_Detalle.TabIndex = 0;
            this.lsv_Detalle.UseCompatibleStateImageBehavior = false;
            // 
            // Form_VerDet_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lsv_Detalle);
            this.Name = "Form_VerDet_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Compra";
            this.Load += new System.EventHandler(this.Form_VerDet_Compra_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_VerDet_Compra_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsv_Detalle;
    }
}