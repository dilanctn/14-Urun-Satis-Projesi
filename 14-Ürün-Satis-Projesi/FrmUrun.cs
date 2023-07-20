using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_EntıtyProje_Uygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntıtyUrunEntities db = new DbEntıtyUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM
                                        }).ToList();


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtUrunAd.Text;
            t.MARKA = TxtUrunMarka.Text;
            t.STOK = short.Parse(TxtUrunStok.Text);
            t.KATEGORI = int.Parse(CmbKategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(TxtUrunFiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Kyadedildi");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtıd.Text);
            var rn = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(rn);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txtıd.Text);
            var rn = db.TBLURUN.Find(x);
            rn.URUNAD = TxtUrunAd.Text;
            rn.STOK =short.Parse( TxtUrunStok.Text);
            rn.MARKA = TxtUrunMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarı İle Güncellendi");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            CmbKategori.ValueMember = "ID";
            CmbKategori.DisplayMember = "AD";
            CmbKategori.DataSource = kategoriler;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Txtıd.Text = CmbKategori.SelectedValue.ToString();
        }
    }
}
