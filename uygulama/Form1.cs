using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);
            double p = Convert.ToDouble(textBox3.Text);
            
            double ort;

            ort = (n1 + n2 + p ) / 3;

            label4.Text = "Puan Ortalaması :" + String.Format("{0:0.0}", ort);
            
            if (ort < 50)   label5.Text = "Not Geçmez";

            else if (ort < 60)  label5.Text = "Not Geçer";

            else if (ort < 70)  label5.Text = "Not Orta";

            else if (ort < 85)  label5.Text = "Not İyi";

            else  label5.Text = "Not Pekiyi";



        }
    }
}
