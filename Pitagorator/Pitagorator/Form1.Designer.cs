
namespace Pitagorator
{
    partial class Form1
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
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).BeginInit();
            this.SuspendLayout();
            // 
            // p_box
            // 
            this.p_box.Location = new System.Drawing.Point(98, 118);
            this.p_box.Name = "p_box";
            this.p_box.Size = new System.Drawing.Size(100, 50);
            this.p_box.TabIndex = 0;
            this.p_box.TabStop = false;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(302, 286);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "button1";
            this.start_btn.UseVisualStyleBackColor = true;
            Events esemenyekk = new Events();
            this.start_btn.Click += new System.EventHandler(delegate (object sender, System.EventArgs e) { esemenyekk.start_btn_Click(sender, e, this.Controls, this); });
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.p_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_box;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
    }
}

