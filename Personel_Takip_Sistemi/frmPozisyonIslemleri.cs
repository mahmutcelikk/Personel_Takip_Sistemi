using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Sistemi
{
    public partial class frmPozisyonIslemleri : Form
    {
        public frmPozisyonIslemleri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmPozisyonEkle frm = new frmPozisyonEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmPozisyonEkle frm = new frmPozisyonEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
