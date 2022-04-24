namespace m_ZarAtma
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
            this.lblBirinciZar = new System.Windows.Forms.Label();
            this.lblİkinciZar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBirinciZar
            // 
            this.lblBirinciZar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBirinciZar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirinciZar.Location = new System.Drawing.Point(93, 123);
            this.lblBirinciZar.Name = "lblBirinciZar";
            this.lblBirinciZar.Size = new System.Drawing.Size(90, 90);
            this.lblBirinciZar.TabIndex = 0;
            this.lblBirinciZar.Text = "0";
            this.lblBirinciZar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblİkinciZar
            // 
            this.lblİkinciZar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblİkinciZar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblİkinciZar.Location = new System.Drawing.Point(280, 123);
            this.lblİkinciZar.Name = "lblİkinciZar";
            this.lblİkinciZar.Size = new System.Drawing.Size(90, 90);
            this.lblİkinciZar.TabIndex = 1;
            this.lblİkinciZar.Text = "0";
            this.lblİkinciZar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(198, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 86);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(149, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zar At";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblİkinciZar);
            this.Controls.Add(this.lblBirinciZar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirinciZar;
        private System.Windows.Forms.Label lblİkinciZar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}
