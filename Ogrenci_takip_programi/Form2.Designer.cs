namespace Ogrenci_takip_programi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblGoster = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciIşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.öğrenciDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veliIşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veliEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veliSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veliDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporIşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soyadaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numarayaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öğrenciEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btn1Cikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(691, 394);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblGoster
            // 
            this.lblGoster.AutoSize = true;
            this.lblGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblGoster.Location = new System.Drawing.Point(652, 9);
            this.lblGoster.Name = "lblGoster";
            this.lblGoster.Size = new System.Drawing.Size(41, 15);
            this.lblGoster.TabIndex = 8;
            this.lblGoster.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciIşlemleriToolStripMenuItem,
            this.veliIşlemleriToolStripMenuItem,
            this.raporIşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciIşlemleriToolStripMenuItem
            // 
            this.öğrenciIşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciSilToolStripMenuItem,
            this.toolStripSeparator1,
            this.öğrenciDüzenleToolStripMenuItem});
            this.öğrenciIşlemleriToolStripMenuItem.Name = "öğrenciIşlemleriToolStripMenuItem";
            this.öğrenciIşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.öğrenciIşlemleriToolStripMenuItem.Text = "Öğrenci işlemleri";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciEkleToolStripMenuItem.Image")));
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciSilToolStripMenuItem
            // 
            this.öğrenciSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciSilToolStripMenuItem.Image")));
            this.öğrenciSilToolStripMenuItem.Name = "öğrenciSilToolStripMenuItem";
            this.öğrenciSilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.öğrenciSilToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.öğrenciSilToolStripMenuItem.Text = "Öğrenci sil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            this.öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            this.öğrenciDüzenleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.öğrenciDüzenleToolStripMenuItem.Text = "Öğrenci düzenle";
            // 
            // veliIşlemleriToolStripMenuItem
            // 
            this.veliIşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veliEkleToolStripMenuItem,
            this.veliSilToolStripMenuItem,
            this.veliDüzenleToolStripMenuItem});
            this.veliIşlemleriToolStripMenuItem.Name = "veliIşlemleriToolStripMenuItem";
            this.veliIşlemleriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.veliIşlemleriToolStripMenuItem.Text = "Veli işlemleri";
            // 
            // veliEkleToolStripMenuItem
            // 
            this.veliEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("veliEkleToolStripMenuItem.Image")));
            this.veliEkleToolStripMenuItem.Name = "veliEkleToolStripMenuItem";
            this.veliEkleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.veliEkleToolStripMenuItem.Text = "Veli ekle";
            // 
            // veliSilToolStripMenuItem
            // 
            this.veliSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("veliSilToolStripMenuItem.Image")));
            this.veliSilToolStripMenuItem.Name = "veliSilToolStripMenuItem";
            this.veliSilToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.veliSilToolStripMenuItem.Text = "Veli sil";
            // 
            // veliDüzenleToolStripMenuItem
            // 
            this.veliDüzenleToolStripMenuItem.Name = "veliDüzenleToolStripMenuItem";
            this.veliDüzenleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.veliDüzenleToolStripMenuItem.Text = "Veli düzenle";
            // 
            // raporIşlemleriToolStripMenuItem
            // 
            this.raporIşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem,
            this.veliToolStripMenuItem,
            this.öğretmenToolStripMenuItem});
            this.raporIşlemleriToolStripMenuItem.Name = "raporIşlemleriToolStripMenuItem";
            this.raporIşlemleriToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.raporIşlemleriToolStripMenuItem.Text = "Rapor işlemleri";
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaGöreToolStripMenuItem,
            this.soyadaGöreToolStripMenuItem,
            this.numarayaGöreToolStripMenuItem,
            this.sınıfaGöreToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // adaGöreToolStripMenuItem
            // 
            this.adaGöreToolStripMenuItem.Name = "adaGöreToolStripMenuItem";
            this.adaGöreToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.adaGöreToolStripMenuItem.Text = "Ada göre";
            // 
            // soyadaGöreToolStripMenuItem
            // 
            this.soyadaGöreToolStripMenuItem.Name = "soyadaGöreToolStripMenuItem";
            this.soyadaGöreToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.soyadaGöreToolStripMenuItem.Text = "Soyada göre";
            // 
            // numarayaGöreToolStripMenuItem
            // 
            this.numarayaGöreToolStripMenuItem.Name = "numarayaGöreToolStripMenuItem";
            this.numarayaGöreToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.numarayaGöreToolStripMenuItem.Text = "Numaraya göre";
            // 
            // sınıfaGöreToolStripMenuItem
            // 
            this.sınıfaGöreToolStripMenuItem.Name = "sınıfaGöreToolStripMenuItem";
            this.sınıfaGöreToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sınıfaGöreToolStripMenuItem.Text = "Sınıfa göre";
            // 
            // veliToolStripMenuItem
            // 
            this.veliToolStripMenuItem.Name = "veliToolStripMenuItem";
            this.veliToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.veliToolStripMenuItem.Text = "Veli";
            // 
            // öğretmenToolStripMenuItem
            // 
            this.öğretmenToolStripMenuItem.Name = "öğretmenToolStripMenuItem";
            this.öğretmenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.öğretmenToolStripMenuItem.Text = "Öğretmen";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem1,
            this.öğrenciSilToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            // 
            // öğrenciEkleToolStripMenuItem1
            // 
            this.öğrenciEkleToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciEkleToolStripMenuItem1.Image")));
            this.öğrenciEkleToolStripMenuItem1.Name = "öğrenciEkleToolStripMenuItem1";
            this.öğrenciEkleToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.öğrenciEkleToolStripMenuItem1.Text = "Öğrenci ekle";
            this.öğrenciEkleToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem1_Click);
            // 
            // öğrenciSilToolStripMenuItem1
            // 
            this.öğrenciSilToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciSilToolStripMenuItem1.Image")));
            this.öğrenciSilToolStripMenuItem1.Name = "öğrenciSilToolStripMenuItem1";
            this.öğrenciSilToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.öğrenciSilToolStripMenuItem1.Text = "Öğrenci sil";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(12, 37);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(135, 37);
            this.btnOgrenciEkle.TabIndex = 10;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btn1Cikis
            // 
            this.btn1Cikis.Location = new System.Drawing.Point(468, 27);
            this.btn1Cikis.Name = "btn1Cikis";
            this.btn1Cikis.Size = new System.Drawing.Size(117, 37);
            this.btn1Cikis.TabIndex = 11;
            this.btn1Cikis.Text = "Çıkış";
            this.btn1Cikis.UseVisualStyleBackColor = true;
            this.btn1Cikis.Click += new System.EventHandler(this.btn1Cikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(171, 37);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(135, 37);
            this.btnOgrenciSil.TabIndex = 13;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn1Cikis);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.lblGoster);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblGoster;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciIşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliIşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporIşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soyadaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numarayaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSilToolStripMenuItem1;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btn1Cikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciSil;
    }
}