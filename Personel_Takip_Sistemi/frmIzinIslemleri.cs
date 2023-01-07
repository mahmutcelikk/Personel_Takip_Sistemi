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
using DAL.DAO;

namespace Personel_Takip_Sistemi
{
    public partial class frmIzinIslemleri : Form
    {
        public frmIzinIslemleri()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmIzinBilgileri frm = new frmIzinBilgileri();
            this.Hide();
            frm.ShowDialog();
            frm.isUpdate = false;
            this.Visible = true;
            comboFull = false;
            Doldur();
            Temizle();
        }
      
        public bool isUpdate = false;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
             if (detay.IzinID == 0)
                MessageBox.Show("Lütfen bir izin seçiniz.");
            else
            {
                frmIzinBilgileri frm = new frmIzinBilgileri();  
                frm.isUpdate = true;
                this.Hide();
                frm.detay = detay;
                frm.ShowDialog();
                this.Visible = true;
                comboFull = false;
                Doldur();
                Temizle();
            }

        }

        IzinDTO dto = new IzinDTO();
        private bool comboFull;
        private void frmIzinIslemleri_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dto = IzinBLL.GetAll();
            dataGridView1.DataSource = dto.Izinler;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].Visible = false; ;
            dataGridView1.Columns[5].Visible = false; ;
            dataGridView1.Columns[6].Visible = false ;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Başlama Tarihi";            
            dataGridView1.Columns[9].HeaderText = "Bitiş Tarihi";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Süre";
            dataGridView1.Columns[12].HeaderText = "İzin Durumu";
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;



            comboDepartman.DataSource = dto.Departmanlar;
            comboDepartman.DisplayMember = "DepartmanAd";
            comboDepartman.ValueMember = "ID";
            comboDepartman.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                comboFull = true;
            comboPozisyon.DataSource = dto.Pozisyonlar;
            comboPozisyon.DisplayMember = "PozisyonAd";
            comboPozisyon.ValueMember = "ID";
            comboPozisyon.SelectedIndex = -1;
            comboDurum.DataSource = dto.IzinDurumlari;
            comboDurum.DisplayMember = "IzinDurumAd";
            comboDurum.ValueMember = "ID";
            comboDurum.SelectedIndex = -1;
        }

        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                comboPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        List<IzinDetayDTO> listt = new List<IzinDetayDTO>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            listt = dto.Izinler;
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
            if (rbStart.Checked)
                listt = listt.Where(x => x.BaslamaTarihi >= Convert.ToDateTime(dtpBaslama.Value) &&
                                         x.BaslamaTarihi < Convert.ToDateTime(dtpBitis.Value)).ToList();
            if (rbFinish.Checked)
                listt = listt.Where(x => x.BitisTarihi < Convert.ToDateTime(dtpBitis.Value) &&
                                         x.BitisTarihi >= Convert.ToDateTime(dtpBaslama.Value)).ToList();
            if (comboDurum.SelectedIndex != -1)     
                listt = listt.Where(x => x.IzinDurumID == Convert.ToInt32(comboDurum.SelectedValue)).ToList();
            if (txtIzinSuresi.Text.Trim() != "")
                listt = listt.Where(x => x.Sure == Convert.ToInt32(txtIzinSuresi.Text)).ToList();

            dataGridView1.DataSource = listt;
        }
        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtUser.Clear();
            txtIzinSuresi.Clear();
            comboDepartman.SelectedIndex = -1;
            comboDepartman.DataSource = dto.Departmanlar;
            comboPozisyon.SelectedIndex = -1;
            comboPozisyon.DataSource = dto.Pozisyonlar;
            comboDurum.SelectedIndex = -1;
            comboDurum.DataSource = dto.IzinDurumlari;
            dtpBaslama.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today;
            dataGridView1.DataSource = dto.Izinler;
            rbStart.Checked = false;
            rbFinish.Checked = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        IzinDetayDTO detay = new IzinDetayDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.IzinID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detay.BaslamaTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detay.BitisTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detay.Sure = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            detay.Aciklama = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (detay.IzinID == 0)
                MessageBox.Show("İzin Seçiniz.");
            else
            {
                IzinBLL.IzinGuncellemesi(detay.IzinID, ComboStatic.Onayla);
                MessageBox.Show("Onaylandı.");
                Temizle();
                Doldur();

            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (detay.IzinID == 0)
                MessageBox.Show("İzin Seçiniz.");
            else
            {
                IzinBLL.IzinGuncellemesi(detay.IzinID, ComboStatic.Reddedildi);
                MessageBox.Show("Reddedildi.");
                Temizle();
                Doldur();

            }
        }
    }
}
