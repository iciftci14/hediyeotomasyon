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
    public partial class Anamenu : Form
    {
        public Anamenu()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        private void iletisim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Birlik Hediyelik Eşya San.Tic.LTD.ŞTİ Telefon Numaramız : ~~");
            
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış İşlemini Onaylıyormusunuz ?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
           
        }

        private void mutfakGereçleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MutfakGerecleri mg = new MutfakGerecleri();
            mg.MdiParent = this;
            mg.Show();
        }

        private void banyoGereçleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanyoGerecleri bg = new BanyoGerecleri();
            bg.MdiParent = this;
            bg.Show();
        }

        private void salonTakımıGereçleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalonTakımıGerecleri stg = new SalonTakımıGerecleri();
            stg.MdiParent = this;
            stg.Show();
        }

        private void ceyizSetleri_Click(object sender, EventArgs e)
        {
            CeyizSetleri cyzst = new CeyizSetleri();
            cyzst.MdiParent = this;
            cyzst.Show();
        }

        private void salonTakımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalonTakimlari stkm = new SalonTakimlari();
            stkm.MdiParent = this;
            stkm.Show();
            
        }

        private void yeniÜrünEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkleme uekle = new UrunEkleme();
            uekle.MdiParent = this;
            uekle.Show();
        }

        private void ürünKoduEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunKodEkle ukodEkle = new UrunKodEkle();
            ukodEkle.MdiParent = this;
            ukodEkle.Show();
        }

        //private void urunKatagoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form1 urunKatagori = new Form1();
        //    urunKatagori.MdiParent = this;
        //    urunKatagori.Show();
        //}
    }
}
