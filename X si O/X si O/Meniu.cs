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
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }
        public static int GameMode = 0;
        public static string Jucator1 = "";
        public static string Jucator2 = "";
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameMode = 1;
            label2.Visible = true;
            textBox1.Visible = true;
            button3.Visible = true;
            label3.Visible = false;
            textBox2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameMode = 0;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GameMode == 1)
            {
                Jucator1 = textBox1.Text;

                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                Jucator1 = textBox1.Text;
                Jucator2 = textBox2.Text;

                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
