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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = TCNO;
            SqlCommand komut = new SqlCommand("Select *From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txt_BilgiDüzenleAd.Text = dr[1].ToString();
                Txt_BilgiDüzenleSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                Txt_Sifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC =@p5 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Txt_BilgiDüzenleAd.Text);
            komut.Parameters.AddWithValue("@p2", Txt_BilgiDüzenleSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", Txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgi güncellendi.");

            

        }
    }
}
