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
    public partial class frmDepartmentListesi : Form
    {
        public frmDepartmentListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmDepartmanEkle frm = new frmDepartmanEkle();
            frm.ShowDialog();

        }

        private void frmDepartmentListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
