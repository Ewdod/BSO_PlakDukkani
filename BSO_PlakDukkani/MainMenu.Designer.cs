namespace BSO_PlakDukkani
{
    partial class MainMenu
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvAlbumler = new DataGridView();
            groupBox1 = new GroupBox();
            cmbSatistaMi = new ComboBox();
            dtCikisTarihi = new DateTimePicker();
            btnEkle = new Button();
            label4 = new Label();
            txtIndirimOrani = new TextBox();
            label5 = new Label();
            txtFiyat = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtSanatci = new TextBox();
            label2 = new Label();
            txtAlbumAdi = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvListelenenAlan = new DataGridView();
            cmbSirala = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListelenenAlan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(13, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 430);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(dgvAlbumler);
            groupBox2.Location = new Point(502, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 378);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ekle Sil Güncelle";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(235, 324);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(208, 29);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(0, 324);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(223, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvAlbumler
            // 
            dgvAlbumler.AllowUserToAddRows = false;
            dgvAlbumler.AllowUserToDeleteRows = false;
            dgvAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumler.Location = new Point(6, 37);
            dgvAlbumler.MultiSelect = false;
            dgvAlbumler.Name = "dgvAlbumler";
            dgvAlbumler.ReadOnly = true;
            dgvAlbumler.RowTemplate.Height = 25;
            dgvAlbumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbumler.Size = new Size(437, 279);
            dgvAlbumler.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSatistaMi);
            groupBox1.Controls.Add(dtCikisTarihi);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIndirimOrani);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSanatci);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAlbumAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 20);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(454, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekleme";
            // 
            // cmbSatistaMi
            // 
            cmbSatistaMi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSatistaMi.FormattingEnabled = true;
            cmbSatistaMi.Items.AddRange(new object[] { "True", "False" });
            cmbSatistaMi.Location = new Point(211, 287);
            cmbSatistaMi.Name = "cmbSatistaMi";
            cmbSatistaMi.Size = new Size(200, 29);
            cmbSatistaMi.TabIndex = 14;
            // 
            // dtCikisTarihi
            // 
            dtCikisTarihi.Location = new Point(211, 147);
            dtCikisTarihi.Name = "dtCikisTarihi";
            dtCikisTarihi.Size = new Size(200, 29);
            dtCikisTarihi.TabIndex = 13;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(39, 340);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(372, 31);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 10;
            label4.Text = "Satışta Durumu :";
            // 
            // txtIndirimOrani
            // 
            txtIndirimOrani.Location = new Point(211, 240);
            txtIndirimOrani.Name = "txtIndirimOrani";
            txtIndirimOrani.Size = new Size(200, 29);
            txtIndirimOrani.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 248);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 8;
            label5.Text = "İndirim Orani :";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(211, 193);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(200, 29);
            txtFiyat.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 201);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 6;
            label6.Text = "Fiyatı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 4;
            label3.Text = "Çıkış Tarihi :";
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(211, 98);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(200, 29);
            txtSanatci.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 2;
            label2.Text = "Sanatçı - Group :";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(211, 51);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(200, 29);
            txtAlbumAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "Albüm Adı :";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvListelenenAlan);
            panel2.Location = new Point(13, 486);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(951, 231);
            panel2.TabIndex = 1;
            // 
            // dgvListelenenAlan
            // 
            dgvListelenenAlan.AllowUserToAddRows = false;
            dgvListelenenAlan.AllowUserToDeleteRows = false;
            dgvListelenenAlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListelenenAlan.Location = new Point(0, 4);
            dgvListelenenAlan.Margin = new Padding(4);
            dgvListelenenAlan.MultiSelect = false;
            dgvListelenenAlan.Name = "dgvListelenenAlan";
            dgvListelenenAlan.ReadOnly = true;
            dgvListelenenAlan.RowTemplate.Height = 25;
            dgvListelenenAlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListelenenAlan.Size = new Size(951, 259);
            dgvListelenenAlan.TabIndex = 0;
            // 
            // cmbSirala
            // 
            cmbSirala.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSirala.FormattingEnabled = true;
            cmbSirala.Items.AddRange(new object[] { "Satışı Durmuş Albümler", "Satışı Devam Eden Albümler", "Sisteme En Son Eklenen 10 Albüm", "İndirimdeki Albümler" });
            cmbSirala.Location = new Point(105, 445);
            cmbSirala.Name = "cmbSirala";
            cmbSirala.Size = new Size(177, 29);
            cmbSirala.TabIndex = 2;
            cmbSirala.SelectedIndexChanged += cmbSirala_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 453);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 15;
            label7.Text = "Sıralama :";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(979, 728);
            Controls.Add(label7);
            Controls.Add(cmbSirala);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "MainMenu";
            FormClosed += MainMenu_FormClosed;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListelenenAlan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvAlbumler;
        private GroupBox groupBox1;
        private ComboBox cmbSatistaMi;
        private DateTimePicker dtCikisTarihi;
        private Button btnEkle;
        private Label label4;
        private TextBox txtIndirimOrani;
        private Label label5;
        private TextBox txtFiyat;
        private Label label6;
        private Label label3;
        private TextBox txtSanatci;
        private Label label2;
        private TextBox txtAlbumAdi;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvListelenenAlan;
        private ComboBox cmbSirala;
        private Label label7;
    }
}