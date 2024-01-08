using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimVeRandevu
{
    public partial class Frm_AnaMenüGirişi : Form
    {
        public Frm_AnaMenüGirişi()
        {
            InitializeComponent();
        }

        private void Btn_Hasta_MouseHover(object sender, EventArgs e)
        {
            Btn_Doktor.BackColor= Color.Green;
            Btn_Hasta.BackColor= Color.Blue;
            Btn_Sekreter.BackColor= Color.GreenYellow;
            pictureBox1.BackColor= Color.PaleGoldenrod;

        }

        private void Btn_Hasta_MouseLeave(object sender, EventArgs e)
        {
            Btn_Doktor.BackColor = Color.White;
            Btn_Hasta.BackColor = Color.White;
            Btn_Sekreter.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
        }

        private void Btn_Sekreter_MouseHover(object sender, EventArgs e)
        {

            Btn_Doktor.BackColor = Color.Green;
            Btn_Hasta.BackColor = Color.Blue;
            Btn_Sekreter.BackColor = Color.GreenYellow;
            pictureBox1.BackColor = Color.PaleGoldenrod;
        }

        private void Btn_Sekreter_MouseLeave(object sender, EventArgs e)
        {
            Btn_Doktor.BackColor = Color.White;
            Btn_Hasta.BackColor = Color.White;
            Btn_Sekreter.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
        }

        private void Btn_Hasta_Click(object sender, EventArgs e)
        {
            Frm_Hasta_Giris fr= new Frm_Hasta_Giris();
            fr.Show();
            this.Hide();
        }

        private void Btn_Doktor_Click(object sender, EventArgs e)
        {
            Frm_Doktor_Giris fr = new Frm_Doktor_Giris();   
            fr.Show();
            this.Hide();
        }

        private void Btn_Sekreter_Click(object sender, EventArgs e)
        {
            Frm_Sekreter_Giris fr = new Frm_Sekreter_Giris();
            fr.Show();
            this.Hide();
        }
    }
}
