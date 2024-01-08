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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            Msk_Tc.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_Tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Txt_BilgiDüzenleAd.Text = dr[1].ToString();
                Txt_BilgiDüzenleSoyad.Text = dr[2].ToString();
                Msk_BilgiDüzenleTelefon.Text = dr[4].ToString();
                Txt_Sifre.Text = dr[5].ToString();
                cmb_BilgiDüzenleCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(Txt_BilgiDüzenleAd.Text!="" && Txt_BilgiDüzenleAd.Text!=string.Empty && Txt_BilgiDüzenleSoyad.Text!="" && Txt_BilgiDüzenleSoyad.Text!=string.Empty && Msk_BilgiDüzenleTelefon.Text!="" && Msk_BilgiDüzenleTelefon.Text!=string.Empty && Txt_Sifre.Text!="" && Txt_Sifre.Text!=string.Empty && cmb_BilgiDüzenleCinsiyet.Text!="" && cmb_BilgiDüzenleCinsiyet.Text!=string.Empty && Msk_Tc.Text!="" && Msk_Tc.Text != string.Empty)
                {
                    SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd =@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@p1", Txt_BilgiDüzenleAd.Text);
                    komut2.Parameters.AddWithValue("@p2", Txt_BilgiDüzenleSoyad.Text);
                    komut2.Parameters.AddWithValue("@p3", Msk_BilgiDüzenleTelefon.Text);
                    komut2.Parameters.AddWithValue("@p4", Txt_Sifre.Text);
                    komut2.Parameters.AddWithValue("@p5", cmb_BilgiDüzenleCinsiyet.Text);
                    komut2.Parameters.AddWithValue("@p6", Msk_Tc.Text);
                    komut2.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Boş bıraktığınız yerler var.");
                }
                
            }
            catch 
            {
                MessageBox.Show("Hatalı Giriş");
            }
      

        }
    }
}
