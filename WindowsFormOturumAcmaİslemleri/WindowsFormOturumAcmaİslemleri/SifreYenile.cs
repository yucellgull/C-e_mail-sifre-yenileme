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
    public partial class SifreYenile : Form
    {
        public SifreYenile()
        {
            InitializeComponent();
        }
        MailGonderici mg = new MailGonderici();

        private void button1_Click(object sender, EventArgs e)
        {
            mg.Microsoft(textBox1.Text, textBox2.Text);
            MessageBox.Show("Girilen Bilgiler Eşleşirse Şifreniz Yenilenecek ve Mail Olarak Gönderilecek ", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
