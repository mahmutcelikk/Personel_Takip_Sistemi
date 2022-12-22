﻿using System;
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
    public partial class frmMaasListesi : Form
    {
        public frmMaasListesi()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

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
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmMaas frm = new frmMaas();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
