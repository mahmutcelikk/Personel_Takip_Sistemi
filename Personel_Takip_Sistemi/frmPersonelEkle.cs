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
            comboPozisyon.DisplayMember = "Pozisyon Adı";
            comboPozisyon.ValueMember = "ID";
            comboPozisyon.SelectedIndex = -1;

        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.ShowDialog();     
            if(resim.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(resim.FileName);
                txtResim.Text = resim.FileName;
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
            if (txtAd.Text.Trim() == "")
                MessageBox.Show("Adınızı giriniz.");
            if (txtSoyad.Text.Trim() == "")
                MessageBox.Show("Soyadınızı giriniz.");
            if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maaş giriniz.");
            if (txtSifre.Text.Trim() == "")
                MessageBox.Show("Şifre giriniz.");
            if (txtResim.Text.Trim() == "")
                MessageBox.Show("Resim seçiniz.");
            if (comboDepartman.SelectedIndex == -1)
                MessageBox.Show("Departman seçiniz.");
            if (comboPozisyon.SelectedIndex == -1)
                MessageBox.Show("Pozisyon seçiniz.");
            else
            {
                PERSONEL ps = new PERSONEL();
                ps.UserNo = Convert.ToInt32(txtUserNoControl.Text);
                ps.Ad = txtAd.Text;
                ps.Soyad = txtSoyad.Text;

            }
        }

        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
