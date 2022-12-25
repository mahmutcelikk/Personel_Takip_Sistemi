using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;


namespace Personel_Takip_Sistemi
{
    public partial class frmPozisyonIslemleri : Form
    {
        public frmPozisyonIslemleri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmPozisyonEkle frm = new frmPozisyonEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            liste = PozisyonBLL.PozisyonGetir();
            dataGridPozisyon.DataSource = liste;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmPozisyonEkle frm = new frmPozisyonEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
          
        }
        List<PozisyonDTO> liste = new List<PozisyonDTO>();
        private void frmPozisyonIslemleri_Load(object sender, EventArgs e)
        {
            liste = PozisyonBLL.PozisyonGetir();
            dataGridPozisyon.DataSource = liste;
            dataGridPozisyon.Columns[1].Visible = false;
            dataGridPozisyon.Columns[3].Visible = false;


        }
    }
}
