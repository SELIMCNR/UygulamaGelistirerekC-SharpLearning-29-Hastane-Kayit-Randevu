namespace HastaneYönetimVeRandevu
{
    partial class Frm_Doktor_Detay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyadDkt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTcDkt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rch_txt_Sikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rnd_DataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Btn_duyurular = new System.Windows.Forms.Button();
            this.Btn_Düzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rnd_DataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyadDkt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTcDkt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // LblAdSoyadDkt
            // 
            this.LblAdSoyadDkt.AutoSize = true;
            this.LblAdSoyadDkt.Location = new System.Drawing.Point(68, 60);
            this.LblAdSoyadDkt.Name = "LblAdSoyadDkt";
            this.LblAdSoyadDkt.Size = new System.Drawing.Size(46, 13);
            this.LblAdSoyadDkt.TabIndex = 1;
            this.LblAdSoyadDkt.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad: ";
            // 
            // LblTcDkt
            // 
            this.LblTcDkt.AutoSize = true;
            this.LblTcDkt.Location = new System.Drawing.Point(68, 31);
            this.LblTcDkt.Name = "LblTcDkt";
            this.LblTcDkt.Size = new System.Drawing.Size(73, 13);
            this.LblTcDkt.TabIndex = 1;
            this.LblTcDkt.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rch_txt_Sikayet);
            this.groupBox2.Location = new System.Drawing.Point(13, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // Rch_txt_Sikayet
            // 
            this.Rch_txt_Sikayet.Location = new System.Drawing.Point(6, 19);
            this.Rch_txt_Sikayet.Name = "Rch_txt_Sikayet";
            this.Rch_txt_Sikayet.Size = new System.Drawing.Size(213, 106);
            this.Rch_txt_Sikayet.TabIndex = 0;
            this.Rch_txt_Sikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rnd_DataGrid);
            this.groupBox3.Location = new System.Drawing.Point(243, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 380);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // Rnd_DataGrid
            // 
            this.Rnd_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rnd_DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rnd_DataGrid.Location = new System.Drawing.Point(3, 16);
            this.Rnd_DataGrid.Name = "Rnd_DataGrid";
            this.Rnd_DataGrid.Size = new System.Drawing.Size(417, 361);
            this.Rnd_DataGrid.TabIndex = 0;
            this.Rnd_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Rnd_DataGrid_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Cikis);
            this.groupBox4.Controls.Add(this.Btn_duyurular);
            this.groupBox4.Controls.Add(this.Btn_Düzenle);
            this.groupBox4.Location = new System.Drawing.Point(12, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 107);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(5, 48);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(215, 23);
            this.Btn_Cikis.TabIndex = 0;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Btn_duyurular
            // 
            this.Btn_duyurular.Location = new System.Drawing.Point(114, 19);
            this.Btn_duyurular.Name = "Btn_duyurular";
            this.Btn_duyurular.Size = new System.Drawing.Size(105, 23);
            this.Btn_duyurular.TabIndex = 0;
            this.Btn_duyurular.Text = "Duyurular";
            this.Btn_duyurular.UseVisualStyleBackColor = true;
            this.Btn_duyurular.Click += new System.EventHandler(this.Btn_duyurular_Click);
            // 
            // Btn_Düzenle
            // 
            this.Btn_Düzenle.Location = new System.Drawing.Point(7, 19);
            this.Btn_Düzenle.Name = "Btn_Düzenle";
            this.Btn_Düzenle.Size = new System.Drawing.Size(105, 23);
            this.Btn_Düzenle.TabIndex = 0;
            this.Btn_Düzenle.Text = "Bilgi Düzenle";
            this.Btn_Düzenle.UseVisualStyleBackColor = true;
            this.Btn_Düzenle.Click += new System.EventHandler(this.Btn_Düzenle_Click);
            // 
            // Frm_Doktor_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(669, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Doktor_Detay";
            this.Text = "Frm_Doktor_Detay";
            this.Load += new System.EventHandler(this.Frm_Doktor_Detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rnd_DataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTcDkt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAdSoyadDkt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Rnd_DataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox Rch_txt_Sikayet;
        private System.Windows.Forms.Button Btn_Düzenle;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button Btn_duyurular;
    }
}