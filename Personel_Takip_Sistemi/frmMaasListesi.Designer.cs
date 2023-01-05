
namespace Personel_Takip_Sistemi
{
    partial class frmMaasListesi
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboPozisyon = new System.Windows.Forms.ComboBox();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUserNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaas = new System.Windows.Forms.Label();
            this.txtMaasYil = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.lblMaasYil = new System.Windows.Forms.Label();
            this.comboMaasAy = new System.Windows.Forms.ComboBox();
            this.lblIsDurum = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEsit = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboPozisyon);
            this.panel3.Controls.Add(this.comboDepartman);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSoyad);
            this.panel3.Controls.Add(this.lblSoyad);
            this.panel3.Controls.Add(this.txtAd);
            this.panel3.Controls.Add(this.lblAd);
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Controls.Add(this.lblUserNo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 253);
            this.panel3.TabIndex = 0;
            // 
            // comboPozisyon
            // 
            this.comboPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPozisyon.FormattingEnabled = true;
            this.comboPozisyon.Location = new System.Drawing.Point(172, 198);
            this.comboPozisyon.Name = "comboPozisyon";
            this.comboPozisyon.Size = new System.Drawing.Size(155, 33);
            this.comboPozisyon.TabIndex = 4;
            // 
            // comboDepartman
            // 
            this.comboDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(172, 154);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(155, 33);
            this.comboDepartman.TabIndex = 3;
            this.comboDepartman.SelectedIndexChanged += new System.EventHandler(this.comboDepartman_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pozisyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Departman";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(170, 108);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(157, 30);
            this.txtSoyad.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(32, 111);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(79, 25);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyadı";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(170, 61);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 30);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(32, 64);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(44, 25);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Adı";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.Location = new System.Drawing.Point(170, 17);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(157, 30);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNo.Location = new System.Drawing.Point(32, 20);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(90, 25);
            this.lblUserNo.TabIndex = 4;
            this.lblUserNo.Text = "User No";
            this.lblUserNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 108);
            this.panel2.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(688, 35);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(135, 58);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(532, 35);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 58);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(379, 35);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 58);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(224, 35);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 58);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 336);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaas);
            this.panel1.Controls.Add(this.txtMaasYil);
            this.panel1.Controls.Add(this.txtMaas);
            this.panel1.Controls.Add(this.lblMaasYil);
            this.panel1.Controls.Add(this.comboMaasAy);
            this.panel1.Controls.Add(this.lblIsDurum);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 253);
            this.panel1.TabIndex = 1;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(440, 108);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(65, 25);
            this.lblMaas.TabIndex = 32;
            this.lblMaas.Text = "Maaş";
            // 
            // txtMaasYil
            // 
            this.txtMaasYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaasYil.Location = new System.Drawing.Point(555, 17);
            this.txtMaasYil.Name = "txtMaasYil";
            this.txtMaasYil.Size = new System.Drawing.Size(181, 30);
            this.txtMaasYil.TabIndex = 1;
            this.txtMaasYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Location = new System.Drawing.Point(555, 108);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(181, 30);
            this.txtMaas.TabIndex = 3;
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // lblMaasYil
            // 
            this.lblMaasYil.AutoSize = true;
            this.lblMaasYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaasYil.Location = new System.Drawing.Point(440, 17);
            this.lblMaasYil.Name = "lblMaasYil";
            this.lblMaasYil.Size = new System.Drawing.Size(95, 25);
            this.lblMaasYil.TabIndex = 33;
            this.lblMaasYil.Text = "Maaş Yıl";
            // 
            // comboMaasAy
            // 
            this.comboMaasAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboMaasAy.FormattingEnabled = true;
            this.comboMaasAy.Location = new System.Drawing.Point(555, 61);
            this.comboMaasAy.Name = "comboMaasAy";
            this.comboMaasAy.Size = new System.Drawing.Size(181, 33);
            this.comboMaasAy.TabIndex = 2;
            this.comboMaasAy.SelectedIndexChanged += new System.EventHandler(this.comboMaasAy_SelectedIndexChanged);
            // 
            // lblIsDurum
            // 
            this.lblIsDurum.AutoSize = true;
            this.lblIsDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsDurum.Location = new System.Drawing.Point(440, 61);
            this.lblIsDurum.Name = "lblIsDurum";
            this.lblIsDurum.Size = new System.Drawing.Size(97, 25);
            this.lblIsDurum.TabIndex = 31;
            this.lblIsDurum.Text = "Maaş Ay";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(708, 198);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 49);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEsit);
            this.groupBox1.Controls.Add(this.rbKucuk);
            this.groupBox1.Controls.Add(this.rbBuyuk);
            this.groupBox1.Location = new System.Drawing.Point(779, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbEsit
            // 
            this.rbEsit.AutoSize = true;
            this.rbEsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEsit.Location = new System.Drawing.Point(196, 11);
            this.rbEsit.Name = "rbEsit";
            this.rbEsit.Size = new System.Drawing.Size(63, 24);
            this.rbEsit.TabIndex = 2;
            this.rbEsit.TabStop = true;
            this.rbEsit.Text = "Eşit";
            this.rbEsit.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKucuk.Location = new System.Drawing.Point(103, 11);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(81, 24);
            this.rbKucuk.TabIndex = 1;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBuyuk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbBuyuk.Location = new System.Drawing.Point(6, 11);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(81, 24);
            this.rbBuyuk.TabIndex = 0;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(539, 198);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(150, 49);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmMaasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMaasListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş Listesi";
            this.Load += new System.EventHandler(this.frmMaasListesi_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboPozisyon;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUserNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox txtMaasYil;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label lblMaasYil;
        private System.Windows.Forms.ComboBox comboMaasAy;
        private System.Windows.Forms.Label lblIsDurum;
        private System.Windows.Forms.RadioButton rbEsit;
    }
}