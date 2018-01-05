using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Vti
{
    class VeritabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;
                                Initial Catalog=db_hediyelikOtomasyon;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataTable dt = new DataTable();


       


        public int UpdateDelete(string sorgu)
        {
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;

            int etkilenenKayitSayisi= komut.ExecuteNonQuery();
            baglanti.Close();
            return etkilenenKayitSayisi;
        }

        public object Insert(string sorgu)
        {
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;


           int etkilenenKayitSayisi = komut.ExecuteNonQuery();
            komut.CommandText = "select SCOPE_IDENTITY()";

            dt = new DataTable();
            adtr.SelectCommand = komut;
            adtr.Fill(dt);

            baglanti.Close();
            return dt.Rows[0][0];
        }

        public DataTable Select(string sorgu)
        {
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            adtr.SelectCommand = komut;

            dt = new DataTable();
            adtr.Fill(dt);
            baglanti.Close();
            return dt;
        }

    }
}
