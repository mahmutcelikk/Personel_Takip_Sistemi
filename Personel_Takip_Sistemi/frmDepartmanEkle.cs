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
    public partial class frmDepartmanEkle : Form
    {
        public frmDepartmanEkle()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAd.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Departman Adı giriniz.");
            }else
            {
                DEPARTMAN dpt = new DEPARTMAN();
                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Güncellemeyi Onaylıyor Musunuz ?", "Dikkat !", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        dpt.ID = detay.ID;
                        dpt.DepartmanAd = txtDepartmanAd.Text;
                        DepartmanBLL.DepartmanGuncelle(dpt);
                        MessageBox.Show("Güncelleme Başarılı.");
                        this.Close();
                }
                else
                {
                    dpt.DepartmanAd = txtDepartmanAd.Text;
                    DepartmanBLL.DepartmanEkle(dpt);
                    MessageBox.Show("Departman Başarıyla Kaydedildi.");
                    txtDepartmanAd.Clear();
                }
                
            }
            
        }

        public bool isUpdate = false;
        public DEPARTMAN detay = new DEPARTMAN();
        private void frmDepartmanEkle_Load(object sender, EventArgs e)
        {
            if (isUpdate)
                txtDepartmanAd.Text = detay.DepartmanAd;
        }
    }
}
