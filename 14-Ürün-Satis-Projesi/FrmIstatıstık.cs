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
    public partial class FrmIstatıstık : Form
    {
        public FrmIstatıstık()
        {
            InitializeComponent();
        }

        DbEntıtyUrunEntities db = new DbEntıtyUrunEntities();


        private void FrmIstatıstık_Load(object sender, EventArgs e)
        {
            LblKategorıSayısı.Text = db.TBLKATEGORI.Count().ToString();
            LblUrunSayisi.Text = db.TBLURUN.Count().ToString();
            LblAktifMusteri.Text = db.TBLMUSTERI.Count(X => X.DURUM == true).ToString();
            LblPasifMusteri.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            LblTopStok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            LblKasaTop.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString()+" TL";
            LblEnYuksekUrun.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();//descending zden a ya sıraladı ve en usttekini getirdi
            LblEnDusukUrun.Text = (from y in db.TBLURUN orderby y.FIYAT ascending select y.URUNAD).FirstOrDefault();// ascending a dan z ye sıraladı ve en üsttekini getirdi
            LblBeyazEsya.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            LblTopBuzdolabıSayısı.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            LblTopSehir.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();//sehir verisini distinct ile tekrarsız olarak seç , aldseçtiğin bu değeri count ile say, ve yaz
            //EN ÇOK TERCİH EDİLEN MARKA İÇİN TBLURUNLER TABLOSUNUN MARKALAR SATIRINDAKİ
            //VERİLERİ MARKALARINA GÖRE GRUPLAYIP SIRALAMAMIZ GEREKİYOR BUNUN İÇİN DE
            //MODELE PROSEDÜR DAHİL ETMEMİZ GEREKİYOR.
            //SQLDE NEW QUERY OLUSTURMALIYIZ ORAYA SÖYLE BİR SORGU YAZIYORUZ
            /*
             * 
CREATE PROCEDURE MARKAGETIR
AS
SELECT TOP 1 MARKA FROM TBLURUN GROUP BY MARKA 
ORDER BY COUNT (*) DESC
             */
            //SONRA C # PROJEMİZDEKİ MODELİ AÇIP SAĞ TUŞ "UPDATE MODEL FROM DATABASE" İ SEÇİP OARDAN DA
            //"STORED PRODUCES AND FUNCTİON" SEKMESİNDEN MARKAGETİR ADI İLE OLUŞTURDUĞUMUZ 
            //PROSEDÜRÜ SEÇİP FİNİSH DERSEK PROJEYE DAHİL OLUR VE MARKAGETİR ADINDA METHOD OLUŞTURULMUŞ OLUŞUR
            //BU METDOHU ÇAĞIRARAK İŞLEMİMİZİ DEVAM ETTİREBİLİRİZ.
            LblEnFazlaMarka.Text = db.MARKAGETIR().FirstOrDefault();

        }

    }
}
