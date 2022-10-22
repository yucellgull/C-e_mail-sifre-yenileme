using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormOturumAcmaİslemleri.Models;

namespace WindowsFormOturumAcmaİslemleri
{
    public partial class Form1 : Form
    {
        WindowsFormOturumAcmaİslemleriEntitiesConnectionDB dB = new WindowsFormOturumAcmaİslemleriEntitiesConnectionDB();
        public Form1()
        {
            InitializeComponent();
        }
        public static int Id;


        private void button1_Click(object sender, EventArgs e)
        {
            var Durum = dB.PersonelGisisTablosu.FirstOrDefault(x => x.MailAdress == textBox1.Text && x.Password == textBox2.Text);
            if (Durum != null)
            {
               Id = Durum.Id;
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girilen Birgiler Hatalıdır", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreYenile sy = new SifreYenile();
            sy.ShowDialog();
        }
    }
}
