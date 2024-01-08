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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void BtnHastaKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                if(Txt_Ad.Text != "" && Txt_Ad.Text != string.Empty && Txt_Soyad.Text!="" && Txt_Soyad.Text!=string.Empty && MskTc.Text !="" && MskTc.Text!=string.Empty && Msk_Telefon.Text!="" && Msk_Telefon.Text!=string.Empty && Txt_Sifre.Text!="" &&Txt_Sifre.Text!=string.Empty && Cmb_Cinsiyet.Text!="" && Cmb_Cinsiyet.Text!=string.Empty) 
                {
                    SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                    komut.Parameters.AddWithValue("@p2", Txt_Soyad.Text);
                    komut.Parameters.AddWithValue("@p3", MskTc.Text);
                    komut.Parameters.AddWithValue("@p4", Msk_Telefon.Text);
                    komut.Parameters.AddWithValue("@p5", Txt_Sifre.Text);
                    komut.Parameters.AddWithValue("@p6", Cmb_Cinsiyet.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz : " + Txt_Sifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("Boş bırakılan yerler var !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }

        }
    }
}
