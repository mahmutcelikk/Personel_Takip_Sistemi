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
using DAL.DAO;
using BLL;
using System.IO;

namespace Personel_Takip_Sistemi
{
    public partial class frmPersonelIslemleri : Form
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PersonelDTO dto = new PersonelDTO();
        bool comboFull = false;
        public PersonelDetay detay = new PersonelDetay();
        
        private void frmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            Doldur();
       
        }

        private void Doldur()
        {
            dto = PersonelBLL.GetAll();
            dataGridView1.DataSource = dto.Personeller;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].HeaderText = "Departman";
            dataGridView1.Columns[5].HeaderText = "Pozisyon";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Maaş";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;



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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            this.Hide();
            frm.ShowDialog();
            frm.isUpdate = true;
            this.Visible = true;
            comboFull = false;
            Temizle();
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle() ;
            this.Hide();
            frm.ShowDialog();
            frm.isUpdate = true;
            frm.detay = detay;
            this.Visible = true;
            comboFull = false;
            Temizle();
            Doldur();
        }

        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                comboPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        List<PersonelDetay> listt = new List<PersonelDetay>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            listt = dto.Personeller;
            if (txtUserno.Text.Trim() != "")
                listt = listt.Where(x => x.UserNo == Convert.ToInt32(txtUserno.Text)).ToList();
            if (txtAd.Text.Trim() != "")
                listt = listt.Where(x => x.Ad.Contains(txtAd.Text)).ToList();
            if (txtSoyad.Text.Trim() != "")
                listt = listt.Where(x => x.Soyad.Contains(txtSoyad.Text)).ToList();
            if (comboDepartman.SelectedIndex != -1)
                listt = listt.Where(x => x.DepartmanID == Convert.ToInt32(comboDepartman.SelectedValue)).ToList();
            if (comboPozisyon.SelectedIndex != -1)
                listt = listt.Where(x => x.PozisyonID == Convert.ToInt32(comboPozisyon.SelectedValue)).ToList();

            dataGridView1.DataSource = listt;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtUserno.Clear();
            comboDepartman.SelectedIndex = -1;
            comboDepartman.DataSource = dto.Departmanlar;
            comboPozisyon.SelectedIndex = -1;
            comboPozisyon.DataSource = dto.Pozisyonlar;
            dataGridView1.DataSource = dto.Personeller;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            detay.Ad = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detay.Soyad = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detay.isAdmin = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
            detay.UserNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            detay.DepartmanID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            detay.PozisyonID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            detay.Maas = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            detay.Sifre = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            detay.Resim = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            detay.Adres = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            detay.DogumTarihi =Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString());


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Personel Silinsin mi ?", "Dikkat !", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                PersonelBLL.PersonelSil(detay.PersonelID);
                string resimYol = Application.StartupPath + "\\resimler\\" + detay.Resim;
                File.Delete(resimYol);
                MessageBox.Show("Personel Silindi");
                comboFull = false;
                Temizle();
                Doldur();
                
            }
        }
    }
}
