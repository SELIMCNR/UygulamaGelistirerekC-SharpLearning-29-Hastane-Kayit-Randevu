namespace HastaneYönetimVeRandevu
{
    partial class Frm_AnaMenüGirişi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnaMenüGirişi));
            this.Lbl_Hasta = new System.Windows.Forms.Label();
            this.Lbl_Doktor = new System.Windows.Forms.Label();
            this.Lbl_Sekreter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Sekreter = new System.Windows.Forms.Button();
            this.Btn_Doktor = new System.Windows.Forms.Button();
            this.Btn_Hasta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Hasta
            // 
            this.Lbl_Hasta.AutoSize = true;
            this.Lbl_Hasta.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Hasta.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Hasta.Location = new System.Drawing.Point(44, 248);
            this.Lbl_Hasta.Name = "Lbl_Hasta";
            this.Lbl_Hasta.Size = new System.Drawing.Size(64, 25);
            this.Lbl_Hasta.TabIndex = 1;
            this.Lbl_Hasta.Text = "Hasta";
            // 
            // Lbl_Doktor
            // 
            this.Lbl_Doktor.AutoSize = true;
            this.Lbl_Doktor.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Doktor.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Doktor.Location = new System.Drawing.Point(191, 248);
            this.Lbl_Doktor.Name = "Lbl_Doktor";
            this.Lbl_Doktor.Size = new System.Drawing.Size(73, 25);
            this.Lbl_Doktor.TabIndex = 1;
            this.Lbl_Doktor.Text = "Doktor";
            // 
            // Lbl_Sekreter
            // 
            this.Lbl_Sekreter.AutoSize = true;
            this.Lbl_Sekreter.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Sekreter.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Sekreter.Location = new System.Drawing.Point(362, 248);
            this.Lbl_Sekreter.Name = "Lbl_Sekreter";
            this.Lbl_Sekreter.Size = new System.Drawing.Size(89, 25);
            this.Lbl_Sekreter.TabIndex = 1;
            this.Lbl_Sekreter.Text = "Sekteter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yörük Selim Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneYönetimVeRandevu.Properties.Resources.heartbeating;
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Sekreter
            // 
            this.Btn_Sekreter.BackgroundImage = global::HastaneYönetimVeRandevu.Properties.Resources.secreteray;
            this.Btn_Sekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Sekreter.Location = new System.Drawing.Point(322, 133);
            this.Btn_Sekreter.Name = "Btn_Sekreter";
            this.Btn_Sekreter.Size = new System.Drawing.Size(148, 102);
            this.Btn_Sekreter.TabIndex = 0;
            this.Btn_Sekreter.UseVisualStyleBackColor = true;
            this.Btn_Sekreter.Click += new System.EventHandler(this.Btn_Sekreter_Click);
            this.Btn_Sekreter.MouseLeave += new System.EventHandler(this.Btn_Sekreter_MouseLeave);
            this.Btn_Sekreter.MouseHover += new System.EventHandler(this.Btn_Sekreter_MouseHover);
            // 
            // Btn_Doktor
            // 
            this.Btn_Doktor.BackgroundImage = global::HastaneYönetimVeRandevu.Properties.Resources.doctor;
            this.Btn_Doktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Doktor.Location = new System.Drawing.Point(159, 133);
            this.Btn_Doktor.Name = "Btn_Doktor";
            this.Btn_Doktor.Size = new System.Drawing.Size(145, 102);
            this.Btn_Doktor.TabIndex = 0;
            this.Btn_Doktor.UseVisualStyleBackColor = true;
            this.Btn_Doktor.Click += new System.EventHandler(this.Btn_Doktor_Click);
            // 
            // Btn_Hasta
            // 
            this.Btn_Hasta.BackgroundImage = global::HastaneYönetimVeRandevu.Properties.Resources.Hasta;
            this.Btn_Hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Hasta.Location = new System.Drawing.Point(8, 133);
            this.Btn_Hasta.Name = "Btn_Hasta";
            this.Btn_Hasta.Size = new System.Drawing.Size(136, 102);
            this.Btn_Hasta.TabIndex = 0;
            this.Btn_Hasta.UseVisualStyleBackColor = true;
            this.Btn_Hasta.Click += new System.EventHandler(this.Btn_Hasta_Click);
            this.Btn_Hasta.MouseLeave += new System.EventHandler(this.Btn_Hasta_MouseLeave);
            this.Btn_Hasta.MouseHover += new System.EventHandler(this.Btn_Hasta_MouseHover);
            // 
            // Frm_AnaMenüGirişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(482, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Sekreter);
            this.Controls.Add(this.Lbl_Doktor);
            this.Controls.Add(this.Lbl_Hasta);
            this.Controls.Add(this.Btn_Sekreter);
            this.Controls.Add(this.Btn_Doktor);
            this.Controls.Add(this.Btn_Hasta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AnaMenüGirişi";
            this.Text = "Yörük Selim Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Hasta;
        private System.Windows.Forms.Button Btn_Doktor;
        private System.Windows.Forms.Button Btn_Sekreter;
        private System.Windows.Forms.Label Lbl_Hasta;
        private System.Windows.Forms.Label Lbl_Doktor;
        private System.Windows.Forms.Label Lbl_Sekreter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

