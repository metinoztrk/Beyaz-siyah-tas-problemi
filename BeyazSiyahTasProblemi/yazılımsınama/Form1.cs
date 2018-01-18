using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılımsınama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilen_deger = Convert.ToInt32(textBox1.Text);
            İkiliAgacDugumu kok = new İkiliAgacDugumu("Beyaz",1);
            İkiliAgac agac = new İkiliAgac(kok);
            agac.agacolustur(kok,girilen_deger);
            agac.agacolustur2(kok,girilen_deger);
            agac.kokunsolunusay(kok,girilen_deger);
            agac.durumlarısay(kok,girilen_deger);
            MessageBox.Show(agac.durumsayisi().ToString());
            textBox1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
