using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace Personel_Takip_Sistemi
{
    public partial class frmDepartmentListesi : Form
    {
        public frmDepartmentListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmDepartmanEkle frm = new frmDepartmanEkle();
            this.Hide();
            frm.ShowDialog();
            frm.isUpdate = false;
            this.Visible = true;
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste;

        }

        List<DEPARTMAN> liste = new List<DEPARTMAN>();
        DEPARTMAN detay = new DEPARTMAN();
        private void frmDepartmentListesi_Load(object sender, EventArgs e)
        {
            
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Departman Adı";
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmDepartmanEkle frm = new frmDepartmanEkle();
            this.Hide();
            frm.ShowDialog();
            frm.isUpdate = true;
            frm.detay = detay;
            this.Visible = true;
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detay.DepartmanAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
