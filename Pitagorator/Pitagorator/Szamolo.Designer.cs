
namespace Pitagorator
{
    partial class Szamolo
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
            this.p_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).BeginInit();
            this.SuspendLayout();
            // 
            // p_box
            // 
            this.p_box.Image = global::Pitagorator.Properties.Resources.adat_gomb;
            this.p_box.Location = new System.Drawing.Point(499, 92);
            this.p_box.Name = "p_box";
            this.p_box.Size = new System.Drawing.Size(100, 50);
            this.p_box.TabIndex = 0;
            this.p_box.TabStop = false;
            // 
            // Szamolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_box);
            this.Name = "Szamolo";
            this.Text = "Szamolo";
            this.Load += new System.EventHandler(this.Szamolo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox p_box;
    }
}