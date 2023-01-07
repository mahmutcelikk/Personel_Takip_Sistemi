using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DAO;
using DAL.DTO;
using DAL;
using BLL;

namespace Personel_Takip_Sistemi
{
    public partial class frmIzinBilgileri : Form
    {
        public frmIzinBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TimeSpan sure = new TimeSpan();
        public bool isUpdate = false;
        public IzinDetayDTO detay = new IzinDetayDTO();
        private void frmIzinBilgileri_Load(object sender, EventArgs e)
        {
            txtUser.Text = UserStatic.UserNo.ToString();
            if(isUpdate)
            {
                dpBaslama.Value = detay.BaslamaTarihi;
                dpBitis.Value = detay.BitisTarihi;
                txtIzinSure.Text = detay.Sure.ToString();
                txtAciklama.Text = detay.Aciklama;
            }
             
        }

        private void dpBaslama_ValueChanged(object sender, EventArgs e)
        {
            sure =  dpBitis.Value.Date - dpBaslama.Value.Date;
            txtIzinSure.Text = sure.TotalDays.ToString();
        }

        private void dpBitis_ValueChanged(object sender, EventArgs e)
        {
            sure = dpBitis.Value.Date - dpBaslama.Value.Date;
            txtIzinSure.Text = sure.TotalDays.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIzinSure.Text.Trim() == "" && Convert.ToInt32(txtIzinSure.Text) <= 0)
                MessageBox.Show("Lütfen tarih aralıkları seçiniz.");
            else if (txtAciklama.Text.Trim() == "")
                MessageBox.Show("Açıklama giriniz.");
            else
            {

                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Değiklikleri Onaylıyor Musunuz?", "Dikkat", MessageBoxButtons.YesNo);
                   
                    if(result == DialogResult.Yes)
                    {

                        IzinDetayDTO detayDTO = new IzinDetayDTO();
                        detayDTO.IzinID = detay.IzinID;
                        detayDTO.BaslamaTarihi = dpBaslama.Value;
                        detayDTO.BitisTarihi = dpBitis.Value;
                        detayDTO.Sure = Convert.ToInt32(txtIzinSure.Text);
                        detayDTO.Aciklama = txtAciklama.Text;
                        IzinBLL.IzinGuncelle(detayDTO);
                        MessageBox.Show("Güncellendi.");
                        this.Close();

                    }
                }
                else
                {

                    IZIN iz = new IZIN();
                    iz.PersonelID = UserStatic.PersonelID;
                    iz.IzinDurumID = 1;
                    iz.IzinBaslamaTarihi = dpBaslama.Value;
                    iz.IzinBitisTarihi = dpBitis.Value;
                    iz.Sure = Convert.ToInt32(txtIzinSure.Text);
                    iz.Aciklama = txtAciklama.Text;
                    IzinBLL.IzinEkle(iz);
                    MessageBox.Show("İzin Eklendi.");
                    dpBaslama.Value = DateTime.Today;
                    dpBitis.Value = DateTime.Today;
                    txtIzinSure.Clear();
                    txtAciklama.Clear();
                }

               
            }
            
        }
    }
}
