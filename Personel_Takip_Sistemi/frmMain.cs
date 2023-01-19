using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;

namespace Personel_Takip_Sistemi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            if (!UserStatic.IsAdmin)
            {
                frmPersonelEkle frm = new frmPersonelEkle();
                PersonelDTO dto = new PersonelDTO();
                dto = PersonelBLL.GetAll();
                PersonelDetay detay = new PersonelDetay();
               // detay = dto.Personeller.First(x=> x.PersonelID == UserStatic.PersonelID);
                frm.isUpdate = true;
                frm.detay = detay;
                frm.ShowDialog();
                this.Visible = true;

            }
            else
            {
                frmPersonelIslemleri frm = new frmPersonelIslemleri();
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
           

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            frmDepartmentListesi frm = new frmDepartmentListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!UserStatic.IsAdmin)
            {
                btnDepartman.Visible = false;
                btnPozisyon.Visible = false;
                btnLogout.Location = new Point(239,187);
                btnExit.Location = new Point(419,187);
            }
        }

        private void btnisler_Click(object sender, EventArgs e)
        {
            frmIsler frm = new frmIsler();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            frmMaasListesi frm = new frmMaasListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            frmIzinIslemleri frm = new frmIzinIslemleri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPozisyon_Click(object sender, EventArgs e)
        {
            frmPozisyonIslemleri frm = new frmPozisyonIslemleri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
