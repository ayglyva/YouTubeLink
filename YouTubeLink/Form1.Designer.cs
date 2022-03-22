using System;

namespace YouTubeLink
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baslik.ForeColor = System.Drawing.Color.Maroon;
            this.baslik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.baslik.Location = new System.Drawing.Point(184, 9);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(407, 36);
            this.baslik.TabIndex = 0;
            this.baslik.Text = "YouTube Video Yuklemek";
            this.baslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // link
            // 
            this.link.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.link.Location = new System.Drawing.Point(147, 107);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(490, 23);
            this.link.TabIndex = 2;
            this.link.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(294, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yukle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(787, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Mp3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Button button1;
    }
}
