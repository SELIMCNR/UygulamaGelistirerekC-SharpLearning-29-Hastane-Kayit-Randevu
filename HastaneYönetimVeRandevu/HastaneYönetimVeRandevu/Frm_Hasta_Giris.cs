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
    public partial class Frm_Hasta_Giris : Form
    {
        public Frm_Hasta_Giris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr= new FrmHastaKayıt();
            fr.Show();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {
                if(Msk_Tc.Text!="" && Msk_Tc.Text!=string.Empty && Txt_Sifre.Text!="" &&  Txt_Sifre.Text!=string.Empty) 
                {
                    SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC =@p1 and HastaSifre=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Msk_Tc.Text);
                    komut.Parameters.AddWithValue("@p2", Txt_Sifre.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {

                        FrmHastaDetay fr = new FrmHastaDetay();
                        fr.tc = Msk_Tc.Text; //veriyi diğer forma gönder.
                        fr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Tc  & Şifre ");
                    }

                    bgl.baglanti().Close();
                }
               
            }
            catch 
            {
                MessageBox.Show("Hatalı Tc  & Şifre ");
            }
        
        }
    }
}
