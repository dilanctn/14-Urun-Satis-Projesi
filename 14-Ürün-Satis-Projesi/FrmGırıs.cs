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
    public partial class FrmGırıs : Form
    {
        public FrmGırıs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntıtyUrunEntities db = new DbEntıtyUrunEntities();
            var sorgu = from x in db.TBLADMIN where x.KULLANICI == TxtKullanıcı.Text && x.SIFRE == TxtSıfre.Text select x;
            if (sorgu.Any())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yapıldı");
            }
            //kullanıcılar=a,b
            //sifreler=1,23
        }
    }
}
