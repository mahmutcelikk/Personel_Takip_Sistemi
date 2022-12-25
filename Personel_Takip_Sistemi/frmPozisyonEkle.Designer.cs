
namespace Personel_Takip_Sistemi
{
    partial class frmPozisyonEkle
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
            this.txtPozAdi = new System.Windows.Forms.TextBox();
            this.lblPozAdi = new System.Windows.Forms.Label();
            this.lblDepAdı = new System.Windows.Forms.Label();
            this.cmbDepAdi = new System.Windows.Forms.ComboBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPozAdi
            // 
            this.txtPozAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozAdi.Location = new System.Drawing.Point(275, 48);
            this.txtPozAdi.Name = "txtPozAdi";
            this.txtPozAdi.Size = new System.Drawing.Size(181, 30);
            this.txtPozAdi.TabIndex = 0;
            // 
            // lblPozAdi
            // 
            this.lblPozAdi.AutoSize = true;
            this.lblPozAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozAdi.Location = new System.Drawing.Point(57, 51);
            this.lblPozAdi.Name = "lblPozAdi";
            this.lblPozAdi.Size = new System.Drawing.Size(138, 25);
            this.lblPozAdi.TabIndex = 2;
            this.lblPozAdi.Text = "Pozisyon Adı";
            // 
            // lblDepAdı
            // 
            this.lblDepAdı.AutoSize = true;
            this.lblDepAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepAdı.Location = new System.Drawing.Point(57, 113);
            this.lblDepAdı.Name = "lblDepAdı";
            this.lblDepAdı.Size = new System.Drawing.Size(155, 25);
            this.lblDepAdı.TabIndex = 2;
            this.lblDepAdı.Text = "Departman Adı";
            // 
            // cmbDepAdi
            // 
            this.cmbDepAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepAdi.FormattingEnabled = true;
            this.cmbDepAdi.Location = new System.Drawing.Point(275, 110);
            this.cmbDepAdi.Name = "cmbDepAdi";
            this.cmbDepAdi.Size = new System.Drawing.Size(181, 33);
            this.cmbDepAdi.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(275, 187);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(135, 58);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(101, 187);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 58);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmPozisyonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 266);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbDepAdi);
            this.Controls.Add(this.lblDepAdı);
            this.Controls.Add(this.txtPozAdi);
            this.Controls.Add(this.lblPozAdi);
            this.Name = "frmPozisyonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPozisyonEkle";
            this.Load += new System.EventHandler(this.frmPozisyonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPozAdi;
        private System.Windows.Forms.Label lblPozAdi;
        private System.Windows.Forms.Label lblDepAdı;
        private System.Windows.Forms.ComboBox cmbDepAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
    }
}