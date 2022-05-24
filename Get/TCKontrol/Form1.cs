using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long kimlikNo = long.Parse(txtTC.Text); // kullanıcı TCsini al.
            int yil = int.Parse(txtYil.Text);
            bool durum = false;

            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient())
                {
                    durum = service.TCKimlikNoDogrula(kimlikNo, txtAd.Text, txtSoyad.Text, yil);
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (durum == true)
                MessageBox.Show("Kayıt Başarılı");
            else
                MessageBox.Show("Girilen Veriler Yanlış. Tekrar Kontrol Ediniz !");
        }
    }
}
