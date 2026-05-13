namespace FrmLab1
{
    partial class FrmFileName
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
            this.lblEnterFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterFileName
            // 
            this.lblEnterFileName.AutoSize = true;
            this.lblEnterFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterFileName.Location = new System.Drawing.Point(79, 75);
            this.lblEnterFileName.Name = "lblEnterFileName";
            this.lblEnterFileName.Size = new System.Drawing.Size(322, 46);
            this.lblEnterFileName.TabIndex = 0;
            this.lblEnterFileName.Text = "Enter File Name";
            this.lblEnterFileName.Click += new System.EventHandler(this.lblEnterFileName_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(78, 136);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(587, 67);
            this.txtFileName.TabIndex = 1;
            // 
            // BtnOkay
            // 
            this.BtnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOkay.Location = new System.Drawing.Point(285, 240);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(189, 46);
            this.BtnOkay.TabIndex = 2;
            this.BtnOkay.Text = "Okay";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // FrmFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 454);
            this.Controls.Add(this.BtnOkay);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblEnterFileName);
            this.Name = "FrmFileName";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmFileName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button BtnOkay;
    }
}