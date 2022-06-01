namespace GestorSoporte
{
    partial class salidaSsh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salidaSsh));
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbResponse
            // 
            this.rtbResponse.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResponse.ForeColor = System.Drawing.Color.White;
            this.rtbResponse.Location = new System.Drawing.Point(0, 0);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(623, 414);
            this.rtbResponse.TabIndex = 0;
            this.rtbResponse.Text = "";
            // 
            // salidaSsh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 414);
            this.Controls.Add(this.rtbResponse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "salidaSsh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSH Output";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbResponse;
    }
}