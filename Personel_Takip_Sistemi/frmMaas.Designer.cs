
namespace Personel_Takip_Sistemi
{
    partial class frmMaas
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
            this.lblMaas = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.lblMaasYil = new System.Windows.Forms.Label();
            this.comboAylar = new System.Windows.Forms.ComboBox();
            this.lblIsDurum = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUserNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboPozisyon = new System.Windows.Forms.ComboBox();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(45, 189);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(65, 25);
            this.lblMaas.TabIndex = 26;
            this.lblMaas.Text = "Maaş";
            // 
            // txtYil
            // 
            this.txtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(183, 240);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(181, 30);
            this.txtYil.TabIndex = 1;
            this.txtYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // lblMaasYil
            // 
            this.lblMaasYil.AutoSize = true;
            this.lblMaasYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaasYil.Location = new System.Drawing.Point(45, 245);
            this.lblMaasYil.Name = "lblMaasYil";
            this.lblMaasYil.Size = new System.Drawing.Size(95, 25);
            this.lblMaasYil.TabIndex = 27;
            this.lblMaasYil.Text = "Maaş Yıl";
            // 
            // comboAylar
            // 
            this.comboAylar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboAylar.FormattingEnabled = true;
            this.comboAylar.Location = new System.Drawing.Point(183, 295);
            this.comboAylar.Name = "comboAylar";
            this.comboAylar.Size = new System.Drawing.Size(181, 33);
            this.comboAylar.TabIndex = 2;
            // 
            // lblIsDurum
            // 
            this.lblIsDurum.AutoSize = true;
            this.lblIsDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsDurum.Location = new System.Drawing.Point(45, 298);
            this.lblIsDurum.Name = "lblIsDurum";
            this.lblIsDurum.Size = new System.Drawing.Size(97, 25);
            this.lblIsDurum.TabIndex = 25;
            this.lblIsDurum.Text = "Maaş Ay";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(183, 137);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(181, 30);
            this.txtSoyad.TabIndex = 21;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(45, 140);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(79, 25);
            this.lblSoyad.TabIndex = 22;
            this.lblSoyad.Text = "Soyadı";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(183, 90);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(181, 30);
            this.txtAd.TabIndex = 20;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(45, 93);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(44, 25);
            this.lblAd.TabIndex = 23;
            this.lblAd.Text = "Adı";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.Location = new System.Drawing.Point(183, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(181, 30);
            this.txtUser.TabIndex = 19;
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNo.Location = new System.Drawing.Point(45, 49);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(90, 25);
            this.lblUserNo.TabIndex = 24;
            this.lblUserNo.Text = "User No";
            this.lblUserNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(455, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 595);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 403);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboPozisyon);
            this.panel2.Controls.Add(this.comboDepartman);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 192);
            this.panel2.TabIndex = 0;
            // 
            // comboPozisyon
            // 
            this.comboPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPozisyon.FormattingEnabled = true;
            this.comboPozisyon.Location = new System.Drawing.Point(89, 132);
            this.comboPozisyon.Name = "comboPozisyon";
            this.comboPozisyon.Size = new System.Drawing.Size(155, 33);
            this.comboPozisyon.TabIndex = 1;
            // 
            // comboDepartman
            // 
            this.comboDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(89, 52);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(155, 33);
            this.comboDepartman.TabIndex = 0;
            this.comboDepartman.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(84, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pozisyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(84, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Departman";
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Location = new System.Drawing.Point(183, 189);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(181, 30);
            this.txtMaas.TabIndex = 0;
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(227, 439);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(137, 58);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(50, 439);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 58);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmMaas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 595);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.lblMaasYil);
            this.Controls.Add(this.comboAylar);
            this.Controls.Add(this.lblIsDurum);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUserNo);
            this.Controls.Add(this.panel1);
            this.Name = "frmMaas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş Bilgileri";
            this.Load += new System.EventHandler(this.frmMaas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label lblMaasYil;
        private System.Windows.Forms.ComboBox comboAylar;
        private System.Windows.Forms.Label lblIsDurum;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUserNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboPozisyon;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
    }
}