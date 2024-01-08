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
    public partial class Frm_Sekreter_Detay : Form
    {
        public Frm_Sekreter_Detay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void Frm_Sekreter_Detay_Load(object sender, EventArgs e)
        {
            Lbl_Tc.Text = TCnumara;

            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC = @p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",Lbl_Tc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                Lbl_Ad.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();

            //Branşları Datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Bransad from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları listeye aktarma 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' '+DoktorSoyad ) as 'Doktorlar',DoktorBrans  From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                Cmb_Brans.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();


        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)");
            komutKaydet.Parameters.AddWithValue("@r1", Msk_Tarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2",Msk_Saat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", Cmb_Brans.Text);
            komutKaydet.Parameters.AddWithValue("@r4",Cmb_Doktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu");
        }

        private void Cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Doktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Cmb_Brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmb_Doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void Btn_Olustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",Rch_Duyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturldu");
        }

        private void Btn_pnldkt_Click(object sender, EventArgs e)
        {
            FrmDoktorPnl fr = new FrmDoktorPnl();
            fr.Show();
        }

        private void Btn_pnlbrans_Click(object sender, EventArgs e)
        {
            FrmBransPnl frmBransPnl = new FrmBransPnl();
            frmBransPnl.Show();
        }

        private void Btn_pnlliste_Click(object sender, EventArgs e)
        {
            FrmRandevuPnlListe frl = new FrmRandevuPnlListe();
            frl.Show();
        }

    
        

        private void Btn_Duyuru_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular();
            fr.Show();
        }
    }
}
