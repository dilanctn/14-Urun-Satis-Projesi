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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntıtyUrunEntities db = new DbEntıtyUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            //var kategoriler = db.TBLKATEGORI.ToList();
            //dataGridView1.DataSource = kategoriler;
            dataGridView1.DataSource = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.AD,
                                   x.ID
                               }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TxtKategorıAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtKategorııd.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtKategorııd.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.AD = TxtKategorıAd.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
        }
    }
}
