using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimVeRandevu
{
    public partial class Frm_Doktor_Detay : Form
    {
        public Frm_Doktor_Detay()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TC;

        private void Frm_Doktor_Detay_Load(object sender, EventArgs e)
        {
            LblTcDkt.Text = TC;

            //Doktor ad soyad

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTcDkt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyadDkt.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+LblAdSoyadDkt.Text+"'",bgl.baglanti());
            da.Fill(dt);

        }

        private void Btn_Düzenle_Click(object sender, EventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = LblTcDkt.Text;
            fr.Show();
        }

        private void Btn_duyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular();
            fr.Show();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Rnd_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = Rnd_DataGrid.SelectedCells[0].RowIndex;
            Rch_txt_Sikayet.Text = Rnd_DataGrid.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
