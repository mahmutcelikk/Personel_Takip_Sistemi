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

        IsDTO dto = new IsDTO();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDurum.Visible = false;
            lblIsDurum.Visible = false;
            dto = IsBLL.GetAll();
        }
    }
}
