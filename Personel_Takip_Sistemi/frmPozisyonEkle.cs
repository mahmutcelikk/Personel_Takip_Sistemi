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
using DAL.DAO;
using DAL.DTO;
using DAL;

namespace Personel_Takip_Sistemi
{
    public partial class frmPozisyonEkle : Form
    {
        public frmPozisyonEkle()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<DEPARTMAN> departmanlar = new List<DEPARTMAN>();
        public bool isUpdate = false;
        public PozisyonDetayDTO detay = new PozisyonDetayDTO();
        private void frmPozisyonEkle_Load(object sender, EventArgs e)
        {
            departmanlar = DAL.DAO.DepartmanDAO.DepartmanGetir();
            cmbDepAdi.DataSource = departmanlar;
            cmbDepAdi.DisplayMember = "DepartmanAd";
            cmbDepAdi.ValueMember = "ID";
            cmbDepAdi.SelectedIndex = -1;

            if (isUpdate)
            {
                txtPozAdi.Text = detay.PozisyonAD;
                cmbDepAdi.SelectedValue = detay.DepartmanID;
            }
        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtPozAdi.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Pozisyon Adı Giriniz.");
            }
            else if(cmbDepAdi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Departman Adı Seçiniz.");
            }
            else
            {

                if(isUpdate)
                {
                    DialogResult result = MessageBox.Show("Güncellemeyi Onaylıyor Musunuz ?", "Dikkat !", MessageBoxButtons.YesNo);

                    if(result == DialogResult.Yes)
                    {
                        detay.PozisyonAD = txtPozAdi.Text;
                        detay.DepartmanID = Convert.ToInt32(cmbDepAdi.SelectedValue);
                        bool control = false;
                        if (detay.EskiDepartmanID == detay.DepartmanID)
                            control = true;
                        PozisyonBLL.PozisyonGuncelle(detay, control);
                        MessageBox.Show("Güncelleme Başarılı.");
                        this.Close();
                    }
                }
                else
                {
                    POZİSYON pz = new POZİSYON();
                    pz.PozisyonAd = txtPozAdi.Text;
                    pz.DepartmanID = Convert.ToInt32(cmbDepAdi.SelectedValue);
                    PozisyonBLL.PozisyonEkle(pz);
                    MessageBox.Show("Pozisyon Eklendi.");
                    txtPozAdi.Clear();
                    cmbDepAdi.SelectedIndex = -1;
                }
            

            }
        }
    }
}
