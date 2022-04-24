namespace n_DijitalSaat
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
            this.components = new System.ComponentModel.Container();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSaat
            // 
            this.lblSaat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaat.Location = new System.Drawing.Point(40, 31);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(100, 75);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.Text = "00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDakika
            // 
            this.lblDakika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDakika.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDakika.Location = new System.Drawing.Point(219, 31);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(100, 75);
            this.lblDakika.TabIndex = 1;
            this.lblDakika.Text = "00";
            this.lblDakika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaniye
            // 
            this.lblSaniye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaniye.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaniye.Location = new System.Drawing.Point(407, 31);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(100, 75);
            this.lblSaniye.TabIndex = 2;
            this.lblSaniye.Text = "00";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(156, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(178, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 394);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
