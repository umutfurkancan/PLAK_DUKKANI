namespace umutPlak
{
    partial class liste
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
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_geridon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Location = new System.Drawing.Point(188, 216);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(71, 27);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = false;
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(12, 208);
            this.txt_ara.Multiline = true;
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(159, 35);
            this.txt_ara.TabIndex = 2;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // btn_geridon
            // 
            this.btn_geridon.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_geridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geridon.Location = new System.Drawing.Point(577, 211);
            this.btn_geridon.Name = "btn_geridon";
            this.btn_geridon.Size = new System.Drawing.Size(74, 37);
            this.btn_geridon.TabIndex = 15;
            this.btn_geridon.Text = "GERİ DÖN";
            this.btn_geridon.UseVisualStyleBackColor = false;
            this.btn_geridon.Click += new System.EventHandler(this.btn_geridon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 177);
            this.dataGridView1.TabIndex = 16;
            // 
            // txt_saat
            // 
            this.txt_saat.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_saat.Location = new System.Drawing.Point(589, 2);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(58, 20);
            this.txt_saat.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(659, 253);
            this.Controls.Add(this.txt_saat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_geridon);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.btn_ara);
            this.Name = "liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "liste";
            this.Load += new System.EventHandler(this.liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Button btn_geridon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_saat;
        private System.Windows.Forms.Timer timer1;
    }
}