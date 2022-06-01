namespace GestorSoporte
{
    partial class ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayuda));
            this.txtAyuda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAyuda
            // 
            this.txtAyuda.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtAyuda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAyuda.Location = new System.Drawing.Point(10, 11);
            this.txtAyuda.Margin = new System.Windows.Forms.Padding(10);
            this.txtAyuda.Multiline = true;
            this.txtAyuda.Name = "txtAyuda";
            this.txtAyuda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAyuda.Size = new System.Drawing.Size(781, 430);
            this.txtAyuda.TabIndex = 0;
            this.txtAyuda.TabStop = false;
            // 
            // ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAyuda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "titulo de la ayuda";
            this.Load += new System.EventHandler(this.ayudaSsh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAyuda;
    }
}