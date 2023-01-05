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

namespace Personel_Takip_Sistemi
{
    public partial class frmMaasListesi : Form
    {
        public frmMaasListesi()
        {
            InitializeComponent();
        }

        List<MaasDetayDTO> listt = new List<MaasDetayDTO>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            listt = dto.Maaslar;
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
            if (txtMaas.Text.Trim() != "")
                listt = listt.Where(x => x.MaasMiktar == Convert.ToInt32(txtMaas.Text)).ToList();
            if (txtMaasYil.Text.Trim() != "")
                listt = listt.Where(x => x.MaasYil == Convert.ToInt32(txtMaasYil.Text)).ToList();
            if (comboMaasAy.SelectedIndex != -1)
                listt = listt.Where(x => x.MaasAyID == Convert.ToInt32(comboMaasAy.SelectedValue)).ToList();
            if (rbBuyuk.Checked)
                listt = listt.Where(x => x.MaasMiktar > Convert.ToInt32(txtMaas.Text)).ToList();
            else if (rbEsit.Checked)
                listt = listt.Where(x => x.MaasMiktar == Convert.ToInt32(txtMaas.Text)).ToList();
            else if (rbKucuk.Checked)
                listt = listt.Where(x => x.MaasMiktar < Convert.ToInt32(txtMaas.Text)).ToList();

            dataGridView1.DataSource = listt;
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMaas frm = new frmMaas();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            Temizle();
            comboFull = false;
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmMaas frm = new frmMaas();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            Temizle();
            comboFull = false;
            Doldur();
        }

        MaasDTO dto = new MaasDTO();
        bool comboFull ;
        private void frmMaasListesi_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dto = MaasBLL.GetALL();
            dataGridView1.DataSource = dto.Maaslar;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Yıl";
            dataGridView1.Columns[9].HeaderText = "Ay";
            dataGridView1.Columns[10].HeaderText = "Maaş Miktarı";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;



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
            comboMaasAy.DataSource = dto.Aylar;
            comboMaasAy.DisplayMember = "Aylar";
            comboMaasAy.ValueMember = "ID";
            comboMaasAy.SelectedIndex = -1;

        }

        private void comboDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                int departmanID = Convert.ToInt32(comboDepartman.SelectedValue);
                comboPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            Temizle();
            
        }

        private void Temizle()
        {
            dataGridView1.DataSource = dto.Maaslar;
            txtUser.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtMaas.Clear();
            txtMaasYil.Clear();
            comboDepartman.SelectedIndex = -1;
            comboPozisyon.SelectedIndex = -1;
            comboMaasAy.SelectedIndex = -1;
            rbBuyuk.Checked = false;
            rbEsit.Checked = false;
            rbKucuk.Checked = false;
        }

        private void comboMaasAy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
