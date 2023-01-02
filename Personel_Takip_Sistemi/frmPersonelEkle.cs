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
using DAL.DTO;
using BLL;
using System.IO;

namespace Personel_Takip_Sistemi
{
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void lblUserNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUserNoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        PersonelDTO dto = new PersonelDTO(); 
        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            dto = PersonelBLL.GetAll();
            comboDepartman.DataSource = dto.Departmanlar;
            comboDepartman.DisplayMember = "Departman Adı";
            comboDepartman.ValueMember = "ID";
            comboDepartman.SelectedIndex = -1;
            comboPozisyon.DataSource = dto.Pozisyonlar;
            comboPozisyon.DisplayMember = "PozisyonAd";
            comboPozisyon.ValueMember = "ID";
            comboPozisyon.SelectedIndex = -1;
            if(dto.Departmanlar.Count>0)
                comboFull = true;

        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.ShowDialog();     
            if(resim.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(resim.FileName);
                txtResim.Text = resim.FileName;
                resimAd = Guid.NewGuid().ToString();
                resimAd += resim.SafeFileName;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUserNoControl.Text.Trim() == "")
                MessageBox.Show("User No giriniz.");
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNoControl.Text)))
                MessageBox.Show("Bu kullanıcı mevcut. Lütfen yeni bir kullanıcı giriniz.");
            else if (txtAd.Text.Trim() == "")
                MessageBox.Show("Adınızı giriniz.");
            else if (txtSoyad.Text.Trim() == "")
                MessageBox.Show("Soyadınızı giriniz.");
            else if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maaş giriniz.");
            else if (txtSifre.Text.Trim() == "")
                MessageBox.Show("Şifre giriniz.");
            else if (txtResim.Text.Trim() == "")
                MessageBox.Show("Resim seçiniz.");
            else if (comboDepartman.SelectedIndex == -1)
                MessageBox.Show("Departman seçiniz.");
            else if (comboPozisyon.SelectedIndex == -1)
                MessageBox.Show("Pozisyon seçiniz.");
            else
            {
                PERSONEL ps = new PERSONEL();
                ps.UserNo = Convert.ToInt32(txtUserNoControl.Text);
                ps.Password = txtSifre.Text;
                ps.Ad = txtAd.Text;
                ps.Soyad = txtSoyad.Text;
                ps.Maas = Convert.ToInt32(txtMaas.Text);
                ps.Adres = txtAdres.Text;
                ps.DogumGunu = dtpDogumGunu.Value;
                ps.isAdmin = checkBoxAdmin.Checked;
                ps.PozisyonID = Convert.ToInt32(comboPozisyon.SelectedValue);
                ps.DepartmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                ps.Resim = resimAd;
                PersonelBLL.PersonelEkle(ps);
                File.Copy(txtResim.Text,@"resimler\\" + resimAd);
                MessageBox.Show("Personel Eklendi.");
                txtUserNoControl.Clear();
                txtSifre.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtMaas.Clear();
                txtAdres.Clear();
                dtpDogumGunu.Value = DateTime.Today;
                checkBoxAdmin.Checked = false;
                comboPozisyon.SelectedIndex = -1;
                comboPozisyon.DataSource = dto.Pozisyonlar;
                comboDepartman.SelectedIndex = -1;
                txtResim.Clear();
                resimAd = " ";

            }
        }
        bool comboFull = false;
        string resimAd = " ";
        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                comboPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
            }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (txtUserNoControl.Text.Trim() == "")
            {
                MessageBox.Show("User No Boş");
            }
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNoControl.Text)))
            {
                MessageBox.Show("Bu userno mevcuttur. Lütfen yeni bir user no giriniz.");
            }
            else
                MessageBox.Show("Bu user no kullanılabilir.");
        }
    }
}
