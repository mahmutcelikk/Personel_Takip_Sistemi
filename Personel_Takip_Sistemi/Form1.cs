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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("Lütfen kullanıcı adı giriniz.");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Lütfen şifre giriniz.");
            else
            {
                List<PERSONEL> list = new List<PERSONEL>();
                list = PersonelBLL.PersonelGetir(Convert.ToInt32(txtUserNo.Text),txtPassword.Text);
                if (list.Count <= 0)
                    MessageBox.Show("Kullanıcı adı ve şifre giriniz.");
                else
                {
                    PERSONEL personel = list.First();
                    UserStatic.PersonelID = personel.ID;
                    UserStatic.IsAdmin = personel.isAdmin;
                    UserStatic.UserNo = personel.UserNo;
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                }

            }
            

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
