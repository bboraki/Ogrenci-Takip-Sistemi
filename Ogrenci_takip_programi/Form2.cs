using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_takip_programi
{
    public partial class Form2 : Form
    {
        public void Listele()
        {
            dtOgrenciler.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil",conn);
            adtr.Fill(dtOgrenciler);
            dataGridView1.DataSource = dtOgrenciler;
        }
        public Form1 frm1;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=data.mdb");
        DataTable dtOgrenciler = new DataTable("ogrBil");
        OleDbCommand sil = new OleDbCommand();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblGoster.Text = "Hoş geldiniz, " + frm1.adSoyad;
            Listele();
            dataGridView1.Columns[0].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[2].HeaderText = "Sınıfı";
            dataGridView1.Columns[3].HeaderText = "Adresi";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            frm1.frm3.ShowDialog();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.frm3.ShowDialog();
        }

        private void öğrenciEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm1.frm3.ShowDialog();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes) {
                conn.Open();
                sil.Connection = conn;
                sil.CommandText = "DELETE FROM ogrBil WHERE ogrNo = "+Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)+"";
                sil.ExecuteNonQuery();
                conn.Close();
                Listele();
            }
        }

        private void btn1Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
