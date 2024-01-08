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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            Lbl_Tc.Text = tc;

            //AdSoyad verilerini çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.Add("@p1", Lbl_Tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                Lbl_Ad.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC =" + tc, bgl.baglanti());
            da.Fill(dt);
            Rnd_GecmisGrid.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                Cmb_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void Cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(Cmb_Brans.Text!="" && Cmb_Brans.Text != string.Empty)
                {
                    Cmb_Doktor.Items.Clear();
                    SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
                    komut3.Parameters.AddWithValue("@p1", Cmb_Brans.Text);
                    SqlDataReader dr3 = komut3.ExecuteReader();
                    while (dr3.Read())
                    {
                        Cmb_Doktor.Items.Add(dr3[0] + "  " + dr3[1]);
                    }
                    bgl.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Alanlar boş olamaz.");
                }

            }
            catch 
            {
                MessageBox.Show("Hatalı giriş.");
            }
   
        }

        private void Cmb_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='"+Cmb_Brans.Text+"'"+" and RandevuDoktor='"+Cmb_Doktor.Text+"' and RandevuDurum=0",bgl.baglanti()); 
           da.Fill(dt);
           RndAktifGrid.DataSource = dt;  
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = Lbl_Tc.Text;
            fr.Show();
        }


        private void RndAktifGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = RndAktifGrid.SelectedCells[0].RowIndex;
           Txt_id.Text = RndAktifGrid.Rows[secilen].Cells[0].Value.ToString();


        }

        private void Btn_Randevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Lbl_Tc.Text);
            komut.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p3",Txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
