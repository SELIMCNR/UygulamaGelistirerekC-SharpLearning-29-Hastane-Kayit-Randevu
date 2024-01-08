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
    public partial class Frm_Doktor_Giris : Form
    {
        public Frm_Doktor_Giris()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void Frm_Doktor_Giris_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msk_DoktorTC.Text);
            komut.Parameters.AddWithValue("@p2", Txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Frm_Doktor_Detay fr = new Frm_Doktor_Detay();
                fr.TC = Msk_DoktorTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali kullanıcı adı veya sifre");
            }
            bgl.baglanti().Close();
        }
    }
}
