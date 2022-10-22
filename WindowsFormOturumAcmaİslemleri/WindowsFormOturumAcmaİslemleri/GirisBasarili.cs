using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormOturumAcmaİslemleri.Models;

namespace WindowsFormOturumAcmaİslemleri
{
    public partial class GirisBasarili : Form
    {
        WindowsFormOturumAcmaİslemleriEntitiesConnectionDB db = new WindowsFormOturumAcmaİslemleriEntitiesConnectionDB();
        public GirisBasarili()
        {
            InitializeComponent();
        }

        private void GirisBasarili_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format(@"Hoş Geldiniz.Sayın{0}
            {1}", db.PersonelGisisTablosu.FirstOrDefault(x => x.Id == Form1.Id).FirsName, db.PersonelGisisTablosu.FirstOrDefault(x => x.Id == Form1.Id).LastName);
        }
    }
}
