using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vti;

namespace birlikHediyelikOtomasyon
{
    public partial class UrunKodEkle : Form
    {
        public UrunKodEkle()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        private void UrunKodEkle_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Created By İlker ÇİFTCİ www.svtimegame.com");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Sorgu aşaması 
            // Eğer boş ise eklemesini engelleyen Kod!
            if(tx_urunKod.Text=="")
            {
                MessageBox.Show("Bu alan boş bırakılamaz!");
                return;
            }
            //Ürün kodu var ise eklemeyi engelleyen kodu.
            DataTable dtSonuc = vt.Select("select * from tbl_urunKodu where urunKodu='" + tx_urunKod.Text + "'");
            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Böyle bir ürün kodu zaten var! Lütfen tekrar deneyiniz.");
                return;
            }

            //Ürün Kodu Ekleme Aşaması

            int kodEkle = Convert.ToInt32   ( vt.Insert(@"insert into tbl_urunKodu(urunKodu)
				             values('" + tx_urunKod.Text + "')"));
            
            // Ekleme işlemi gerçekleşti ise mesaj veriyoruz.
            
            if (kodEkle > 0)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi.");
            }
        }

        private void UrunKodEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            UrunKodEkle_Load(null, null); 
           
        }
    }
}
