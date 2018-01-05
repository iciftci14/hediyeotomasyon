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
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }
        int secili_id = 0;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void UrunEkleme_Load(object sender, EventArgs e)
        {

            //Seçilmesi için önce ürün katagorisini gerekli yere yüklüyoruz.
            cbx_urunKategori.DisplayMember = "Katagori";
            cbx_urunKategori.ValueMember = "urunKatagori_id";
            cbx_urunKategori.DataSource = vt.Select("select urunKatagori_id,urunKatagorisi Katagori from tbl_urunKatagori");
            //Eksik kalan yer tamamla düzelecek :);
            //Ürün Eklenen Kısmı Ekle butonuna basılınca açılacak olan kısım.
            dgv_urunEklenen.DataSource = vt.Select(@"select u.urun_id,uk.urunKodu_id,uk.urunKodu,u.urunAdi Urun,uka.urunKatagori_id,uka.urunKatagorisi,u.urunFiyat Fiyati,u.urunBilgisi Icerikler,u.Stok StokAdedi from tbl_urunler u
            join tbl_urunKodu uk on uk.urunKodu_id = u.urunKodu_id
            join tbl_urunKatagori uka on uka.urunKatagori_id = u.urunKatagori_id");
            dgv_urunEklenen.Columns[0].Visible = false;
            dgv_urunEklenen.Columns[1].Visible = false;
            dgv_urunEklenen.Columns[4].Visible = false;


        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (tx_urunKod.Text == "")
            {
                MessageBox.Show("Lütfen aramak istediğiniz ürünün kodunu yazınız.");
                return;

            }
            //Ürün kod kısmını veritabanımızdan aratıyoruz çıkan sonuç ile id'yi alıp tabloya ekleme yapacağız.

            dgv_urunKod.DataSource = vt.Select(@"select urunKodu_id,urunKodu from tbl_urunKodu
                    where urunKodu like '%" + tx_urunKod.Text + "%'");

            // Arama kısmından dönen sonuç datagridview'de listeleniyor
            
            //Ürün Kod ararken eğer sonuç yok ise hata mesajı veriyoruz.---------
            if (dgv_urunKod.SelectedRows.Count==0)
            {
                MessageBox.Show("Böyle bir ürün kodu bulunmamaktadır.");


            }
            //--------------------------------------------------------------------
        }
        public void dgv_urunKod_SelectionChanged(object sender, EventArgs e)
        {

            secili_id = (int)dgv_urunKod.SelectedRows[0].Cells[0].Value;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Ürün Ekleme aşamasından önce hata kontrollerini yapıyoruz.

            if (tx_urunKod.Text == "")
            {
                MessageBox.Show("Boş kısımları doldurunuz.");
                return;
            }
            if (tx_urunAdi.Text == "" || tx_urunBilgi.Text == "") {
                MessageBox.Show("Boş kısımları doldurunuz.");
                return;
            }


            dgv_urunEklenen.DataSource = vt.Insert(@"insert into tbl_urunler(urunAdi,urunFiyat,urunBilgisi,urunKodu_id,urunKatagori_id,Stok)
                                    values('" + tx_urunAdi.Text + "','" + nud_fiyat.Value + "','" + tx_urunBilgi.Text + "','" + secili_id + "','" + cbx_urunKategori.SelectedValue + "','"+nud_stok.Value+"')");
            UrunEkleme_Load(null, null);
            MessageBox.Show("Ürün başarıyla eklendi.");
            // ***** Bu kısımda beklenmedik bir hatadan dolayı şu anda yorum içerisine aldık. Sonra tekrar Aktif Edicez!! *******
            //else {
            //    MessageBox.Show("Beklenmedik bir hata oluştu Lütfen Tekrar Deneyin!");
            //}

        }

        private void dgv_urunEklenen_SelectionChanged(object sender, EventArgs e)
        {


            //Seçili olan satırdaki bilgileri kutulara aktarma alanı.
            if (dgv_urunEklenen.SelectedRows.Count == 0)
                return;

            tx_urunAdi.Text = dgv_urunEklenen.SelectedRows[0].Cells[3].Value.ToString();
            cbx_urunKategori.SelectedValue = dgv_urunEklenen.SelectedRows[0].Cells[4].Value;
            //cbx_urunKategori.SelectedValue = dgv_urunEklenen.SelectedRows[0].Cells[2].Value;
            nud_fiyat.Text = dgv_urunEklenen.SelectedRows[0].Cells[6].Value.ToString();
            tx_urunBilgi.Text = dgv_urunEklenen.SelectedRows[0].Cells[7].Value.ToString();
            nud_stok.Text = dgv_urunEklenen.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_urunEklenen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz");
                return;
            }
            int secili_id = (int)dgv_urunEklenen.SelectedRows[0].Cells[0].Value;
            int etkilenenKayitSayisi = vt.UpdateDelete("delete from tbl_urunler where urun_id=" + secili_id);
            if (etkilenenKayitSayisi > 0)
            {
                UrunEkleme_Load(null, null);
                MessageBox.Show("Kayıt Silindi.");
            }
        }

        private void btn_guncele_Click(object sender, EventArgs e)
        {
            // Update sorgusu ile tasarlanacak..
            // MessageBox.Show("Yapım aşamasındadır..");
            // Hata kontrol aşamaları Start. ------------------------

            if (dgv_urunEklenen.SelectedRows.Count==0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünü yan kısımdan seçiniz!");
                return;
            }

            if (tx_urunKod.Text == "") { 
            
                MessageBox.Show("Boş kısımları doldurunuz.");
                return;
            }
            if (tx_urunAdi.Text == "" || tx_urunBilgi.Text == "") {
            
                MessageBox.Show("Boş kısımları doldurunuz.");
                return;
            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_urunAdi.Text = "";
            tx_urunBilgi.Text = "";
            tx_urunKod.Text = "";
            cbx_urunKategori.SelectedIndex = 1;
            nud_fiyat.Value = 10;
            nud_stok.Value = 0;
            MessageBox.Show("İçerikler Temizlenmiştir..");
        }

        private void btn_urunKoduEkle_Click(object sender, EventArgs e)
        {
            UrunKodEkle uk = new UrunKodEkle();
            uk.StartPosition = FormStartPosition.CenterParent;
            uk.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sonra yapılacak.
            /*
            OpenFileDialog op = new OpenFileDialog();
            */
        }

        private void dgv_urunEklenen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
