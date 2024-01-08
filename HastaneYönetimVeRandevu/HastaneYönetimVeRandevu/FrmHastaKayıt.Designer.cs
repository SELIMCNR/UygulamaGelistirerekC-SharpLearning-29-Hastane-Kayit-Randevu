namespace HastaneYönetimVeRandevu
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnHastaKayıt = new System.Windows.Forms.Button();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(154, 36);
            this.Txt_Ad.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(148, 24);
            this.Txt_Ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad:";
            // 
            // Txt_Soyad
            // 
            this.Txt_Soyad.Location = new System.Drawing.Point(154, 76);
            this.Txt_Soyad.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Soyad.Name = "Txt_Soyad";
            this.Txt_Soyad.Size = new System.Drawing.Size(148, 24);
            this.Txt_Soyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon:";
            // 
            // Msk_Telefon
            // 
            this.Msk_Telefon.Location = new System.Drawing.Point(153, 155);
            this.Msk_Telefon.Margin = new System.Windows.Forms.Padding(4);
            this.Msk_Telefon.Mask = "(999) 000-0000";
            this.Msk_Telefon.Name = "Msk_Telefon";
            this.Msk_Telefon.Size = new System.Drawing.Size(148, 24);
            this.Msk_Telefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre:";
            // 
            // Cmb_Cinsiyet
            // 
            this.Cmb_Cinsiyet.FormattingEnabled = true;
            this.Cmb_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cmb_Cinsiyet.Location = new System.Drawing.Point(154, 228);
            this.Cmb_Cinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Cinsiyet.Name = "Cmb_Cinsiyet";
            this.Cmb_Cinsiyet.Size = new System.Drawing.Size(148, 26);
            this.Cmb_Cinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cinsiyet:";
            // 
            // BtnHastaKayıt
            // 
            this.BtnHastaKayıt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnHastaKayıt.Location = new System.Drawing.Point(171, 266);
            this.BtnHastaKayıt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHastaKayıt.Name = "BtnHastaKayıt";
            this.BtnHastaKayıt.Size = new System.Drawing.Size(106, 55);
            this.BtnHastaKayıt.TabIndex = 7;
            this.BtnHastaKayıt.Text = "Kayıt Yap";
            this.BtnHastaKayıt.UseVisualStyleBackColor = false;
            this.BtnHastaKayıt.Click += new System.EventHandler(this.BtnHastaKayıt_Click);
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(154, 119);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(147, 24);
            this.MskTc.TabIndex = 3;
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(153, 188);
            this.Txt_Sifre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(148, 24);
            this.Txt_Sifre.TabIndex = 5;
            // 
            // FrmHastaKayıt
            // 
            this.AcceptButton = this.BtnHastaKayıt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 338);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.BtnHastaKayıt);
            this.Controls.Add(this.Cmb_Cinsiyet);
            this.Controls.Add(this.Msk_Telefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayıt";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Msk_Telefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_Cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnHastaKayıt;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.TextBox Txt_Sifre;
    }
}