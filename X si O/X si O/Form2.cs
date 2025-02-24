using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_si_O
{
    public partial class Form2 : Form
    {
        public static string Jucator1 = "";
        public static string Jucator2 = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jucator1 = textBox1.Text;
            Jucator2 = textBox2.Text;
            this.Close();
        }
    }
}
