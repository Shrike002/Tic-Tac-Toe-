namespace X_si_O
{
    public partial class Form1 : Form
    {
        new Button[,] b = new Button[3, 3];
        int x = 0;
        int GameMode = Meniu.GameMode;
        int timer = 1;
        int ContorRunda = 0;
        int scorx = 0, scoro = 0, scorr = 0;
        string Jucator1 = Meniu.Jucator1;
        string Jucator2 = Meniu.Jucator2;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (Jucator1 != "")
                labelX.Text = Jucator1 + " - " + scorx;
            if (Jucator2 != "" && GameMode == 0)
                labelO.Text = Jucator2 + " - " + scoro;
            else if(GameMode == 1)
                labelO.Text = "CPU - " + scoro;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Timp runda: " + timer + " s";
            timer++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Visible = true;
            button1.Enabled = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    b[i, j] = new Button();
                    b[i, j].Size = new Size(75, 75);
                    b[i, j].Font = new Font("Arial", 20, FontStyle.Bold);
                    b[i, j].Text = "";
                    b[i, j].Location = new Point(75 * (j + 1) - 15, 75 * (i + 1) - 30);
                    b[i, j].BackColor = Color.White;
                    if (GameMode == 0)
                        b[i, j].Click += new EventHandler(buttoane_Click);
                    else
                        b[i, j].Click += new EventHandler(buttoane_Click_Single);
                    panel1.Controls.Add(b[i, j]);
                }
        }
        private void buttoane_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            x++;
            if (x % 2 != 0)
                btn.Text = "X";
            else
                btn.Text = "O";
            btn.Enabled = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (b[i, j] == btn)
                    {
                        if (b[i, 0].Text == b[i, 1].Text && b[i, 0].Text == b[i, 2].Text)
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, j].Text == b[1, j].Text && b[1, j].Text == b[2, j].Text)
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 0].Text == b[1, 1].Text && b[1, 1].Text == b[2, 2].Text && b[0, 0].Text != "")
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 2].Text == b[1, 1].Text && b[1, 1].Text == b[2, 0].Text && b[0, 2].Text != "")
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 0].Text != "" && b[0, 1].Text != "" && b[0, 2].Text != "" && b[1, 0].Text != "" && b[1, 1].Text != "" && b[1, 2].Text != "" && b[2, 0].Text != "" && b[2, 1].Text != "" && b[2, 2].Text != "")
                        {
                            timer1.Stop();
                            scorr++;
                            MessageBox.Show("Remiza!");
                            Resetare();
                            return;
                        }
                    }
                }
        }

        private void buttoane_Click_Single(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int rx = random.Next(0, 3);
            int ry = random.Next(0, 3);
            x++;
            btn.Text = "X";
            btn.Enabled = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (b[i, j] == btn)
                    {
                        if (b[i, 0].Text == b[i, 1].Text && b[i, 0].Text == b[i, 2].Text)
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, j].Text == b[1, j].Text && b[1, j].Text == b[2, j].Text)
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 0].Text == b[1, 1].Text && b[1, 1].Text == b[2, 2].Text && b[0, 0].Text != "")
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 2].Text == b[1, 1].Text && b[1, 1].Text == b[2, 0].Text && b[0, 2].Text != "")
                        {
                            if (btn.Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 0].Text != "" && b[0, 1].Text != "" && b[0, 2].Text != "" && b[1, 0].Text != "" && b[1, 1].Text != "" && b[1, 2].Text != "" && b[2, 0].Text != "" && b[2, 1].Text != "" && b[2, 2].Text != "")
                        {
                            timer1.Stop();
                            scorr++;
                            MessageBox.Show("Remiza!");
                            Resetare();
                            return;
                        }
                    }
                }
            while (b[rx, ry].Text != "")
            {
                rx = random.Next(0, 3);
                ry = random.Next(0, 3);
            }
            b[rx, ry].Enabled = false;
            b[rx, ry].Text = "O";

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (b[i, j] == b[rx, ry])
                    {
                        if (b[i, 0].Text == b[i, 1].Text && b[i, 0].Text == b[i, 2].Text)
                        {
                            if (b[rx, ry].Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, j].Text == b[1, j].Text && b[1, j].Text == b[2, j].Text)
                        {
                            if (b[rx, ry].Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 0].Text == b[1, 1].Text && b[1, 1].Text == b[2, 2].Text && b[0, 0].Text != "")
                        {
                            if (b[rx, ry].Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 2].Text == b[1, 1].Text && b[1, 1].Text == b[2, 0].Text && b[0, 2].Text != "")
                        {
                            if (b[rx, ry].Text == "X")
                            {
                                timer1.Stop();
                                scorx++;
                                MessageBox.Show("X a castigat!");
                                Resetare();
                                return;
                            }
                            else
                            {
                                timer1.Stop();
                                scoro++;
                                MessageBox.Show("O a castigat!");
                                Resetare();
                                return;
                            }
                        }
                        if (b[0, 0].Text != "" && b[0, 1].Text != "" && b[0, 2].Text != "" && b[1, 0].Text != "" && b[1, 1].Text != "" && b[1, 2].Text != "" && b[2, 0].Text != "" && b[2, 1].Text != "" && b[2, 2].Text != "")
                        {
                            timer1.Stop();
                            scorr++;
                            MessageBox.Show("Remiza!");
                            Resetare();
                            return;
                        }
                    }
                }



        }
        private void Resetare()
        {
            timer1.Stop();
            ContorRunda++;
            if (Jucator1 != "")
            {
                labelX.Text = Jucator1 + " - " + scorx;
            }
            else
                labelX.Text = "X - " + scorx;
            if (GameMode == 0 && Jucator2 != "")
            {
                labelO.Text = Jucator2 + " - " + scoro;
            }
            else if (GameMode == 1)
            {
                labelO.Text = "CPU - " + scoro;
            }
            else
            {
                labelO.Text = "O - " + scoro;
            }
            labelR.Text = "Remize - " + scorr;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    panel1.Controls.Remove(b[i, j]);
                    button1.Enabled = true;
                }
            if (ContorRunda % 2 == 0)
                x = 0;
            else
                x = 1;
            timer = 1;
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.LightSkyBlue;
            this.labelX.BackColor = Color.LightSkyBlue;
            this.labelX.ForeColor = Color.Black;
            this.labelO.BackColor = Color.LightSkyBlue;
            this.labelO.ForeColor = Color.Black;
            this.labelR.BackColor = Color.LightSkyBlue;
            this.labelR.ForeColor = Color.Black;
            this.button1.BackColor = Color.DarkBlue;
            this.button1.ForeColor = Color.White;
        }

        private void rosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Red;
            this.labelX.BackColor = Color.Red;
            this.labelX.ForeColor = Color.Black;
            this.labelO.BackColor = Color.Red;
            this.labelO.ForeColor = Color.Black;
            this.labelR.BackColor = Color.Red;
            this.labelR.ForeColor = Color.Black;
            this.button1.BackColor = Color.DarkRed;
            this.button1.ForeColor = Color.White;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.LightGreen;
            this.labelX.BackColor = Color.LightGreen;
            this.labelX.ForeColor = Color.Black;
            this.labelO.BackColor = Color.LightGreen;
            this.labelO.ForeColor = Color.Black;
            this.labelR.BackColor = Color.LightGreen;
            this.labelR.ForeColor = Color.Black;
            this.button1.BackColor = Color.DarkGreen;
            this.button1.ForeColor = Color.White;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.DimGray;
            this.labelX.BackColor = Color.DimGray;
            this.labelX.ForeColor = Color.White;
            this.labelO.BackColor = Color.DimGray;
            this.labelO.ForeColor = Color.White;
            this.labelR.BackColor = Color.DimGray;
            this.labelR.ForeColor = Color.White;
            this.button1.BackColor = Color.White;
            this.button1.ForeColor = Color.Black;
        }

        private void cuPrieteniiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameMode = 0;
            x = 0;
            scoro = 0;
            scorx = 0;
            scorr = 0;
            Resetare();
        }

        private void singurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameMode = 1;
            scoro = 0;
            scorx = 0;
            scorr = 0;
            Resetare();
        }

        private void dificultateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void schimbaJucatoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            Jucator1 = Form2.Jucator1;
            Jucator2 = Form2.Jucator2;
            GameMode = 0;
            x = 0;
            scoro = 0;
            scorx = 0;
            scorr = 0;
            Resetare();
        }

        private void resetareScorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x = 0;
            scoro = 0;
            scorx = 0;
            scorr = 0;
            Resetare();
        }
    }
}