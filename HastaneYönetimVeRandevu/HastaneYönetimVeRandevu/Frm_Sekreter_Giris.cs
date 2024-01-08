using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYönetimVeRandevu
{
    public partial class Frm_Sekreter_Giris : Form
    {
        public Frm_Sekreter_Giris()
        {
            InitializeComponent();
        }
        sqlBaglantisi baglan = new sqlBaglantisi();
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_SekreterTC.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Frm_Sekreter_Detay frs = new Frm_Sekreter_Detay();
                frs.TCnumara=Msk_SekreterTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre");
            }
            baglan.baglanti().Close();






        }
    }
}
