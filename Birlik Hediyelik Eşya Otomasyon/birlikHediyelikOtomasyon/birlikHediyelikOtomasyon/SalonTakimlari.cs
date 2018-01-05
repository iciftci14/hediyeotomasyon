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
    public partial class SalonTakimlari : Form
    {
        public SalonTakimlari()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        private void SalonTakimlari_Load(object sender, EventArgs e)
        {
            //Ürünler tablosunun birleştirme aşaması ve kısaltmaları
            //tbl_urunler -> u
            //tbl_urunKodu -> uk
            //tbl_urunKategori -> uka
            dgv_stListe.DataSource = vt.Select(@"select u.urun_id,uk.urunKodu_id,uk.urunKodu,u.urunAdi Urun,uka.urunKatagori_id,uka.urunKatagorisi,u.urunFiyat Fiyati,u.urunBilgisi Icerikler,u.Stok stokDurum from tbl_urunler u
            join tbl_urunKodu uk on uk.urunKodu_id = u.urunKodu_id
            join tbl_urunKatagori uka on uka.urunKatagori_id = u.urunKatagori_id
             where uka.urunKatagori_id=2");
            //Burada sql tablomuzdaki bütün veriler gelirken ürün id'leride gelmektedir
            //Bu yüzden alt kısımda id olan sütunları görünmez yaptık.
            dgv_stListe.Columns[0].Visible = false;
            dgv_stListe.Columns[1].Visible = false;
            dgv_stListe.Columns[4].Visible = false;
            
            
        }

        private void dgv_stListe_SelectionChanged(object sender, EventArgs e)
        {
            //Eğer satır seçili değil ise hata vermesini engelleyen kod.
            if (dgv_stListe.SelectedRows.Count == 0)
                return;
            // Alt kısımda bulunan kodlar DataGridden seçilenleri alt kısma aktarıyor.
            tx_urunKodu.Text = dgv_stListe.SelectedRows[0].Cells[2].Value.ToString();
            tx_urunAdi.Text= dgv_stListe.SelectedRows[0].Cells[3].Value.ToString();
           tx_urunKategori.Text= dgv_stListe.SelectedRows[0].Cells[5].Value.ToString();
            tx_urunFiyati.Text= dgv_stListe.SelectedRows[0].Cells[6].Value.ToString() + " ₺";
            tx_urunIcerikler.Text = dgv_stListe.SelectedRows[0].Cells[7].Value.ToString();
            tx_stok.Text = dgv_stListe.SelectedRows[0].Cells[8].Value.ToString() + " Adet" ;
        }

        private void tx_urunKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tx_urunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tx_urunKategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tx_urunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tx_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
