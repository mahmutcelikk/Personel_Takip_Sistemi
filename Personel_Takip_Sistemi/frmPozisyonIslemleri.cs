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
            frm.isUpdate = false;
            this.Visible = true;
            liste = PozisyonBLL.PozisyonGetir();
            dataGridPozisyon.DataSource = liste;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmPozisyonEkle frm = new frmPozisyonEkle();
            this.Hide();
            frm.ShowDialog();
            frm.isUpdate = true;
            frm.detay = detay;
            this.Visible = true;
            liste = PozisyonBLL.PozisyonGetir();
            dataGridPozisyon.DataSource = liste;


        }
        List<PozisyonDTO> liste = new List<PozisyonDTO>();
        public PozisyonDetayDTO detay = new PozisyonDetayDTO();
        private void frmPozisyonIslemleri_Load(object sender, EventArgs e)
        {
            liste = PozisyonBLL.PozisyonGetir();
            dataGridPozisyon.DataSource = liste;
            dataGridPozisyon.Columns[1].Visible = false;
            dataGridPozisyon.Columns[3].Visible = false;


        }

        private void dataGridPozisyon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.ID = Convert.ToInt32(dataGridPozisyon.Rows[e.RowIndex].Cells[1].Value);
            detay.DepartmanID = Convert.ToInt32(dataGridPozisyon.Rows[e.RowIndex].Cells[3].Value);
            detay.EskiDepartmanID = Convert.ToInt32(dataGridPozisyon.Rows[e.RowIndex].Cells[3].Value);
            detay.PozisyonAD = dataGridPozisyon.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pozisyon silinsin mi ?", "Dikkat!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PozisyonBLL.PozisyonSil(detay.ID);
                MessageBox.Show("Silindi");
                liste = PozisyonBLL.PozisyonGetir();
                dataGridPozisyon.DataSource = liste;
            }
            else
            {
                this.Close();
            }
        }
    }
}
