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
using DAL.DAO;
using DAL.DTO;

namespace Personel_Takip_Sistemi
{
    public partial class frmIsBilgileri : Form
    {
        public frmIsBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        bool comboFull = false;
        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                comboPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        IsDTO dto = new IsDTO();
        public bool isUpdate = false;
        public IsDetayDTO detay = new IsDetayDTO();
        private void frmIsBilgileri_Load(object sender, EventArgs e)
        {
            comboDurum.Visible = false;
            lblIsDurum.Visible = false;
            dto = IsBLL.GetAll();
            dataGridView1.DataSource = dto.Personeller;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
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

            if (isUpdate)
            {
                comboDurum.Visible = false;
                lblIsDurum.Visible = false;
                txtAd.Text = detay.Ad;
                txtSoyad.Text = detay.Soyad;
                txtUserNo.Text = detay.UserNo.ToString();
                txtRapor.Text = detay.IsRapor;
                txtBaslik.Text = detay.IsBaslik;
                comboDurum.DataSource = dto.IsDurumlari;
                comboDurum.DisplayMember = "IsDurumAd";
                comboDurum.ValueMember = "ID";
                comboDurum.SelectedIndex = detay.IsDurumID;

            }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            iss = new I();
            iss.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        I iss = new I();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (iss.PersonelID == 0)
                MessageBox.Show("Personel Seçiniz.");
            else if (txtBaslik.Text.Trim() == "")
                MessageBox.Show("Başlık giriniz.");
            else if (txtRapor.Text.Trim() == "")
                MessageBox.Show("İş Raporunu doldurunuz.");
            else
            {
                if(isUpdate)
                {
                    DialogResult result = MessageBox.Show("Kayıt İşlemini Onaylıyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo);

                    if(result == DialogResult.Yes) 
                    {
                        IsDetayDTO dtoo = new IsDetayDTO(); 
                        if(Convert.ToInt32(txtUserNo.Text) != detay.UserNo)
                        {
                            dtoo.PersonelID = iss.PersonelID;
                        }
                        else
                        {
                            dtoo.PersonelID = detay.PersonelID;
                            dtoo.IsBaslik = detay.IsBaslik;
                            dtoo.IsRapor = detay.IsRapor; 
                            dtoo.IsDurumID = Convert.ToInt32(detay.IsDurumID);
                            dtoo.IsID = detay.IsID;
                            IsBLL.IsGuncelle(dtoo);
                            MessageBox.Show("Güncellendi");
                            this.Close();
                        }
                    }
                }

                else
                {
                    iss.Baslik = txtBaslik.Text;
                    iss.Icerik = txtRapor.Text;
                    iss.IsDurumID = 1;
                    iss.IsBaslamaTarihi = DateTime.Today;
                    IsBLL.IsEkle(iss);
                    MessageBox.Show("İş Başarıyla Eklendi.");
                    txtBaslik.Clear();
                    txtRapor.Clear();

                }

               
            }

            
        }

       
    }
}
