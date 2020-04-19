namespace umutPlak
{
    partial class PlakKaydet
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_cinsi = new System.Windows.Forms.TextBox();
            this.txt_sanatci = new System.Windows.Forms.TextBox();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_turu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_geridon = new System.Windows.Forms.Button();
            this.btn_guncel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_veriGuncel = new System.Windows.Forms.Button();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(581, 241);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(101, 20);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı :";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(66, 184);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 2;
            // 
            // txt_cinsi
            // 
            this.txt_cinsi.Location = new System.Drawing.Point(66, 211);
            this.txt_cinsi.Name = "txt_cinsi";
            this.txt_cinsi.Size = new System.Drawing.Size(100, 20);
            this.txt_cinsi.TabIndex = 3;
            // 
            // txt_sanatci
            // 
            this.txt_sanatci.Location = new System.Drawing.Point(247, 212);
            this.txt_sanatci.Name = "txt_sanatci";
            this.txt_sanatci.Size = new System.Drawing.Size(100, 20);
            this.txt_sanatci.TabIndex = 5;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(247, 185);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(100, 20);
            this.txt_tarih.TabIndex = 4;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(414, 212);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_fiyat.TabIndex = 7;
            // 
            // txt_turu
            // 
            this.txt_turu.Location = new System.Drawing.Point(414, 185);
            this.txt_turu.Name = "txt_turu";
            this.txt_turu.Size = new System.Drawing.Size(100, 20);
            this.txt_turu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cinsi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sanatçı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fiyat :";
            // 
            // btn_geridon
            // 
            this.btn_geridon.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_geridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geridon.Location = new System.Drawing.Point(630, 3);
            this.btn_geridon.Name = "btn_geridon";
            this.btn_geridon.Size = new System.Drawing.Size(78, 21);
            this.btn_geridon.TabIndex = 14;
            this.btn_geridon.Text = "GERİ DÖN";
            this.btn_geridon.UseVisualStyleBackColor = false;
            this.btn_geridon.Click += new System.EventHandler(this.btn_geridon_Click);
            // 
            // btn_guncel
            // 
            this.btn_guncel.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_guncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncel.Location = new System.Drawing.Point(687, 188);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(85, 23);
            this.btn_guncel.TabIndex = 15;
            this.btn_guncel.Text = "Güncelle";
            this.btn_guncel.UseVisualStyleBackColor = false;
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 152);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_veriGuncel
            // 
            this.btn_veriGuncel.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_veriGuncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_veriGuncel.Location = new System.Drawing.Point(687, 212);
            this.btn_veriGuncel.Name = "btn_veriGuncel";
            this.btn_veriGuncel.Size = new System.Drawing.Size(85, 49);
            this.btn_veriGuncel.TabIndex = 17;
            this.btn_veriGuncel.Text = "Fiyat Güncelle";
            this.btn_veriGuncel.UseVisualStyleBackColor = false;
            this.btn_veriGuncel.Click += new System.EventHandler(this.btn_veriGuncel_Click);
            // 
            // txt_saat
            // 
            this.txt_saat.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_saat.Location = new System.Drawing.Point(724, 4);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(58, 20);
            this.txt_saat.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(581, 212);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(101, 24);
            this.btn_sil.TabIndex = 20;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(581, 190);
            this.txt_ara.Multiline = true;
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_ara.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Silinecek :";
            // 
            // PlakKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(789, 265);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.txt_saat);
            this.Controls.Add(this.btn_veriGuncel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.btn_geridon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_turu);
            this.Controls.Add(this.txt_sanatci);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.txt_cinsi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "PlakKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlakKaydet";
            this.Load += new System.EventHandler(this.PlakKaydet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_cinsi;
        private System.Windows.Forms.TextBox txt_sanatci;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_turu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_geridon;
        private System.Windows.Forms.Button btn_guncel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_veriGuncel;
        private System.Windows.Forms.TextBox txt_saat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label7;
    }
}