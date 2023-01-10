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
    public partial class frmMaas : Form
    {
        public frmMaas()
        {
            InitializeComponent();
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        MaasDTO dto = new MaasDTO();
        bool comboFull;
        public bool isUpdate = false;
        public MaasDetayDTO detay = new MaasDetayDTO();
        bool control = false;

        private void frmMaas_Load(object sender, EventArgs e)
        {
            dto = MaasBLL.GetALL();

            dataGridView1.DataSource = dto.Personeller;
            dataGridView1.Columns[0].Visible = false;
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
            comboAylar.DataSource = dto.Aylar;
            comboAylar.DisplayMember = "Ay";
            comboAylar.ValueMember = "ID";
            comboAylar.SelectedIndex = -1;
            txtYil.Text = DateTime.Today.Year.ToString();

            if (isUpdate)
            {
                txtAd.Text = detay.Ad;
                txtSoyad.Text = detay.Soyad;
                txtUser.Text = detay.UserNo.ToString();
                txtMaas.Text = detay.MaasMiktar.ToString();
                txtYil.Text = detay.MaasYil.ToString();
                comboAylar.SelectedValue = detay.MaasAyID;


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                comboPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        MAA maas = new MAA();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maas.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtUser.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (maas.PersonelID == 0)
                MessageBox.Show("Personel Seçiniz.");
            else if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maaş Giriniz.");
            else if (txtYil.Text.Trim() == "")
                MessageBox.Show("Yıl Giriniz.");
            else if (comboAylar.SelectedIndex == -1)
                MessageBox.Show("Ay Seçiniz.");
            else
            {
                if(isUpdate)
                {
                    DialogResult result = MessageBox.Show("Maaş Güncellemesini Onaylıyor Musunuz ?", "Dikkat !", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        MaasDetayDTO maas = new MaasDetayDTO();
                        maas.MaasID = detay.MaasID;
                        maas.MaasAyID = Convert.ToInt32(comboAylar.SelectedValue);
                        maas.MaasYil =  Convert.ToInt32(txtYil.Text);
                        maas.EskiMaas = detay.MaasMiktar;
                        maas.MaasMiktar = Convert.ToInt32(txtMaas.Text);
                        
                        if (maas.MaasMiktar > maas.EskiMaas)
                            control = true;
                        MaasBLL.MaasGuncelle(maas,control);
                        MessageBox.Show("Maaş Güncellendi.");
                        this.Close();
                        
                    }
                }

                else { 
                maas.Ay_ID = Convert.ToInt32(comboAylar.SelectedValue);
                maas.Miktar = Convert.ToInt32(txtMaas.Text);
                maas.YIL = Convert.ToInt32(txtYil.Text);
                MaasBLL.MaasEkle(maas);
                MessageBox.Show("Maaş Eklendi.");
                txtMaas.Clear();
                maas = new MAA();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
