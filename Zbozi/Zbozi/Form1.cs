using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zbozi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zbozi novezbozi = new Zbozi(textBox1.Text,(int) numericUpDown1.Value, dateTimePicker1.Value,(int) numericUpDown2.Value);
            Produkt novyprodukt = new Produkt(textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value, false);

            MessageBox.Show(novyprodukt.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
