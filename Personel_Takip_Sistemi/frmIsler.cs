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
using DAL.DTO;

namespace Personel_Takip_Sistemi
{
    public partial class frmIsler : Form
    {
        public frmIsler()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool comboFull;
        IsDTO dto = new IsDTO();
        private void frmIsler_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dto = IsBLL.GetAll();
            dataGridView1.DataSource = dto.Isler;
            dataGridView1.DataSource = dto.Personeller;
            dataGridView1.Columns[0].HeaderText = "Başlık";
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].HeaderText = "Departman";
            dataGridView1.Columns[5].HeaderText = "Pozisyon";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;


            comboDepartman.DataSource = dto.Departmanlar;
            comboDepartman.DisplayMember = "Departman Adı";
            comboDepartman.ValueMember = "ID";
            comboDepartman.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                comboFull = true;
            comboPozisyon.DataSource = dto.Pozisyonlar;
            comboPozisyon.DisplayMember = "PozisyonAd";
            comboPozisyon.ValueMember = "ID";
            comboPozisyon.SelectedIndex = -1;
            comboDurum.DataSource = dto.IsDurumlari;
            comboDurum.ValueMember = "ID";
            comboDurum.DisplayMember = "IsDurumAd";
            comboDurum.SelectedIndex = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmIsBilgileri frm = new frmIsBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            frm.isUpdate = false;
            comboFull = false;
            Doldur();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmIsBilgileri frm = new frmIsBilgileri();
            this.Hide();
            frm.ShowDialog();
            frm.isUpdate = true;
            frm.detay = detay;
            this.Visible = true;
            comboFull = false;
            Doldur();
            Temizle();
        }

        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                comboPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }

        List<IsDetayDTO> listt = new List<IsDetayDTO>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            listt = dto.Isler;
            if (txtUser.Text.Trim() != "")
                listt = listt.Where(x => x.UserNo == Convert.ToInt32(txtUser.Text)).ToList();
            if (txtAd.Text.Trim() != "")
                listt = listt.Where(x => x.Ad.Contains(txtAd.Text)).ToList();
            if (txtSoyad.Text.Trim() != "")
                listt = listt.Where(x => x.Soyad.Contains(txtSoyad.Text)).ToList();
            if (comboDepartman.SelectedIndex != -1)
                listt = listt.Where(x => x.DepartmanID == Convert.ToInt32(comboDepartman.SelectedValue)).ToList();
            if (comboPozisyon.SelectedIndex != -1)
                listt = listt.Where(x => x.PozisyonID == Convert.ToInt32(comboPozisyon.SelectedValue)).ToList();

            if (comboDurum.SelectedIndex != -1)
                listt = listt.Where(x => x.IsDurumID == Convert.ToInt32(comboDurum.SelectedValue)).ToList();
            if (rbStart.Checked)
                listt = listt.Where(x => x.IsBaslamaTarihi >= Convert.ToDateTime(dtpBaslama.Value) &&
                x.IsBaslamaTarihi < Convert.ToDateTime(dtpBitis.Value)).ToList();
            if (rbTeslim.Checked)
                listt = listt.Where(x => x.IsBitisTarihi >= Convert.ToDateTime(dtpBaslama.Value) &&
                x.IsBitisTarihi < Convert.ToDateTime(dtpBitis.Value)).ToList();

            dataGridView1.DataSource = listt;
        }
        void Temizle() {
            txtAd.Clear();
            txtSoyad.Clear();
            txtUser.Clear();
            comboDepartman.SelectedIndex = -1;
            comboDepartman.DataSource = dto.Departmanlar;
            comboPozisyon.SelectedIndex = -1;
            comboPozisyon.DataSource = dto.Pozisyonlar;
            comboDurum.SelectedIndex = -1;
            dtpBaslama.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;
            dataGridView1.DataSource = dto.Isler;
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        public IsDetayDTO detay = new IsDetayDTO();
        public bool isUpdate = false;

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.IsID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detay.UserNo= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detay.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detay.IsDurumID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detay.IsBaslik = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detay.IsRapor = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detay.Ad = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detay.Soyad = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detay.IsBaslamaTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            detay.IsBitisTarihi= Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
     

        }
    }
}
