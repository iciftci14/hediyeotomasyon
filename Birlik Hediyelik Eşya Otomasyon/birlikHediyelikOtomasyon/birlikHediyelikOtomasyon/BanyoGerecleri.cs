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
    public partial class BanyoGerecleri : Form
    {
        public BanyoGerecleri()
        {
            InitializeComponent();
           
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void BanyoGerecleri_Load(object sender, EventArgs e)
        {
            //Form açılınca gerekli tablolara veri doldurma aşaması.
            dgv_stListe.DataSource = vt.Select(@"select u.urun_id,uk.urunKodu_id,uk.urunKodu,
                    u.urunAdi Urun,uka.urunKatagori_id,uka.urunKatagorisi,u.urunFiyat 
            Fiyati,u.urunBilgisi Icerikler,u.Stok stokDurumu from tbl_urunler u
            join tbl_urunKodu uk on uk.urunKodu_id = u.urunKodu_id
            join tbl_urunKatagori uka on uka.urunKatagori_id = u.urunKatagori_id
             where uka.urunKatagori_id=3");
            dgv_stListe.Columns[0].Visible = false;
            dgv_stListe.Columns[1].Visible = false;
            dgv_stListe.Columns[4].Visible = false;
        }
    }
}
