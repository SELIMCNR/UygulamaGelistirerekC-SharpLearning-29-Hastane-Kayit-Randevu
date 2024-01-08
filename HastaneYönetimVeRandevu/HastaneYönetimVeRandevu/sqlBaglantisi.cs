using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYönetimVeRandevu
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BC3LOP2\\SELM;Initial Catalog=HastaneProje;Integrated Security=True;");
            baglan.Open();
            return baglan;

        }
    }
}
