using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ogrenci_takip_programi
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=data.mdb");
        OleDbCommand ekle = new OleDbCommand();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                ekle.Connection = conn;
                ekle.CommandText = "INSERT INTO ogrbil(ogrNo,adSoyad,sinifi,adres) VALUES ('"+txtNo.Text+"', '"+txtAdSoyad.Text+"', '"+txtSinif.Text+"','"+txtAdres.Text+"')";
                ekle.ExecuteNonQuery();
                conn.Close();
                frm1.frm2.Listele();

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox) {
                    Controls[i].Text = "";
                    Controls[i].Width = 100;
                }
              
            }

            } 
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                conn.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char) 08)
            {
                e.Handled = true;
            }
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char) 08 && e.KeyChar != (char) 32)
            {
                e.Handled = true;
            }
        }
    }
}
