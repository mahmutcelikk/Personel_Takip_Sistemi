
namespace Personel_Takip_Sistemi
{
    partial class frmMain
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
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnisler = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnIzin = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnPozisyon = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.Blue;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonel.Location = new System.Drawing.Point(56, 12);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(142, 152);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel İşlemleri";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnisler
            // 
            this.btnisler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnisler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnisler.Location = new System.Drawing.Point(239, 12);
            this.btnisler.Name = "btnisler";
            this.btnisler.Size = new System.Drawing.Size(142, 152);
            this.btnisler.TabIndex = 1;
            this.btnisler.Text = "İşler";
            this.btnisler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnisler.UseVisualStyleBackColor = false;
            // 
            // btnMaas
            // 
            this.btnMaas.BackColor = System.Drawing.Color.Chartreuse;
            this.btnMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaas.Location = new System.Drawing.Point(419, 12);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(142, 152);
            this.btnMaas.TabIndex = 2;
            this.btnMaas.Text = "Maaş";
            this.btnMaas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaas.UseVisualStyleBackColor = false;
            // 
            // btnIzin
            // 
            this.btnIzin.BackColor = System.Drawing.Color.Gray;
            this.btnIzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzin.Location = new System.Drawing.Point(56, 187);
            this.btnIzin.Name = "btnIzin";
            this.btnIzin.Size = new System.Drawing.Size(142, 152);
            this.btnIzin.TabIndex = 3;
            this.btnIzin.Text = "İzin İşlemleri";
            this.btnIzin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzin.UseVisualStyleBackColor = false;
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.Green;
            this.btnDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartman.Location = new System.Drawing.Point(239, 187);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(142, 152);
            this.btnDepartman.TabIndex = 4;
            this.btnDepartman.Text = "Departman İşlemleri";
            this.btnDepartman.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnPozisyon
            // 
            this.btnPozisyon.BackColor = System.Drawing.Color.Aqua;
            this.btnPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPozisyon.Location = new System.Drawing.Point(419, 187);
            this.btnPozisyon.Name = "btnPozisyon";
            this.btnPozisyon.Size = new System.Drawing.Size(142, 152);
            this.btnPozisyon.TabIndex = 5;
            this.btnPozisyon.Text = "Pozisyon İşlemleri";
            this.btnPozisyon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPozisyon.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(154, 374);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 152);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(346, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 152);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXİT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 568);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPozisyon);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.btnIzin);
            this.Controls.Add(this.btnMaas);
            this.Controls.Add(this.btnisler);
            this.Controls.Add(this.btnPersonel);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnisler;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnIzin;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnPozisyon;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
    }
}