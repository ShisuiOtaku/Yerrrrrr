namespace Waterrrrr
{
    partial class Resultsss
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
            this.txtresultss = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtresultss
            // 
            this.txtresultss.Location = new System.Drawing.Point(397, 51);
            this.txtresultss.Name = "txtresultss";
            this.txtresultss.Size = new System.Drawing.Size(100, 20);
            this.txtresultss.TabIndex = 0;
            this.txtresultss.TextChanged += new System.EventHandler(this.txtresultss_TextChanged);
            // 
            // Resultsss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresultss);
            this.Name = "Resultsss";
            this.Text = "Resultsss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtresultss;
    }
}