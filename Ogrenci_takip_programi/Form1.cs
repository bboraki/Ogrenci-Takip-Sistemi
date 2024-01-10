using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_takip_programi
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public string adSoyad;
        void temizle()
        {
            txtKullanici.Text = "";
            txtSifre.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm2.frm1 = this;
            frm3.frm1 = this;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            lblHataMesaj.ForeColor = Color.Red;
            if (txtKullanici.Text.Trim().ToLower() == "admin" && txtSifre.Text.Trim().ToLower() == "1234")
            {
                adSoyad = txtAdSoyad.Text;
                this.Hide();
                frm2.Show();
            } 
            else if (txtKullanici.Text == "" || txtSifre.Text == "")
            {
                lblHataMesaj.Text = "Kullanıcı adı ya da şifre boş bırakılamaz.";
                temizle();
            }
            else
            {
                lblHataMesaj.Text = "Kullanıcı adı ya da şifre hatalıdır.";
                temizle();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
