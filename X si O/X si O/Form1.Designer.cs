namespace X_si_O
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            dificultateToolStripMenuItem = new ToolStripMenuItem();
            singurToolStripMenuItem = new ToolStripMenuItem();
            cuPrieteniiToolStripMenuItem = new ToolStripMenuItem();
            tematiciToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            rosuToolStripMenuItem = new ToolStripMenuItem();
            verdeToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            jucatoriToolStripMenuItem = new ToolStripMenuItem();
            schimbaJucatoriiToolStripMenuItem = new ToolStripMenuItem();
            resetareScorToolStripMenuItem = new ToolStripMenuItem();
            labelX = new Label();
            labelR = new Label();
            labelO = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(11, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 299);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(11, 31);
            button1.Name = "button1";
            button1.Size = new Size(122, 47);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 46);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 2;
            label1.Text = "Timp runda: ";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dificultateToolStripMenuItem, tematiciToolStripMenuItem, jucatoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(356, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // dificultateToolStripMenuItem
            // 
            dificultateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { singurToolStripMenuItem, cuPrieteniiToolStripMenuItem });
            dificultateToolStripMenuItem.Name = "dificultateToolStripMenuItem";
            dificultateToolStripMenuItem.Size = new Size(79, 20);
            dificultateToolStripMenuItem.Text = "Mod de joc";
            dificultateToolStripMenuItem.Click += dificultateToolStripMenuItem_Click;
            // 
            // singurToolStripMenuItem
            // 
            singurToolStripMenuItem.Name = "singurToolStripMenuItem";
            singurToolStripMenuItem.Size = new Size(135, 22);
            singurToolStripMenuItem.Text = "Singur";
            singurToolStripMenuItem.Click += singurToolStripMenuItem_Click;
            // 
            // cuPrieteniiToolStripMenuItem
            // 
            cuPrieteniiToolStripMenuItem.Name = "cuPrieteniiToolStripMenuItem";
            cuPrieteniiToolStripMenuItem.Size = new Size(135, 22);
            cuPrieteniiToolStripMenuItem.Text = "Cu prietenii";
            cuPrieteniiToolStripMenuItem.Click += cuPrieteniiToolStripMenuItem_Click;
            // 
            // tematiciToolStripMenuItem
            // 
            tematiciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blueToolStripMenuItem, rosuToolStripMenuItem, verdeToolStripMenuItem, defaultToolStripMenuItem });
            tematiciToolStripMenuItem.Name = "tematiciToolStripMenuItem";
            tematiciToolStripMenuItem.Size = new Size(63, 20);
            tematiciToolStripMenuItem.Text = "Tematici";
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 255);
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(118, 22);
            blueToolStripMenuItem.Text = "Albastru";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // rosuToolStripMenuItem
            // 
            rosuToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 128);
            rosuToolStripMenuItem.Name = "rosuToolStripMenuItem";
            rosuToolStripMenuItem.Size = new Size(118, 22);
            rosuToolStripMenuItem.Text = "Rosu";
            rosuToolStripMenuItem.Click += rosuToolStripMenuItem_Click;
            // 
            // verdeToolStripMenuItem
            // 
            verdeToolStripMenuItem.BackColor = Color.FromArgb(128, 255, 128);
            verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            verdeToolStripMenuItem.Size = new Size(118, 22);
            verdeToolStripMenuItem.Text = "Verde";
            verdeToolStripMenuItem.Click += verdeToolStripMenuItem_Click;
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(118, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // jucatoriToolStripMenuItem
            // 
            jucatoriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { schimbaJucatoriiToolStripMenuItem, resetareScorToolStripMenuItem });
            jucatoriToolStripMenuItem.Name = "jucatoriToolStripMenuItem";
            jucatoriToolStripMenuItem.Size = new Size(60, 20);
            jucatoriToolStripMenuItem.Text = "Jucatori";
            // 
            // schimbaJucatoriiToolStripMenuItem
            // 
            schimbaJucatoriiToolStripMenuItem.Name = "schimbaJucatoriiToolStripMenuItem";
            schimbaJucatoriiToolStripMenuItem.Size = new Size(167, 22);
            schimbaJucatoriiToolStripMenuItem.Text = "Schimba Jucatorii";
            schimbaJucatoriiToolStripMenuItem.Click += schimbaJucatoriiToolStripMenuItem_Click;
            // 
            // resetareScorToolStripMenuItem
            // 
            resetareScorToolStripMenuItem.Name = "resetareScorToolStripMenuItem";
            resetareScorToolStripMenuItem.Size = new Size(167, 22);
            resetareScorToolStripMenuItem.Text = "Resetare Scor";
            resetareScorToolStripMenuItem.Click += resetareScorToolStripMenuItem_Click;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.BackColor = Color.DimGray;
            labelX.ForeColor = Color.White;
            labelX.Location = new Point(33, 394);
            labelX.Name = "labelX";
            labelX.Size = new Size(31, 15);
            labelX.TabIndex = 5;
            labelX.Text = "X - 0";
            labelX.TextAlign = ContentAlignment.TopCenter;
            labelX.Click += label2_Click;
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.BackColor = Color.DimGray;
            labelR.ForeColor = Color.White;
            labelR.Location = new Point(139, 394);
            labelR.Name = "labelR";
            labelR.Size = new Size(62, 15);
            labelR.TabIndex = 6;
            labelR.Text = "Remize - 0";
            labelR.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelO
            // 
            labelO.AutoSize = true;
            labelO.BackColor = Color.DimGray;
            labelO.ForeColor = Color.White;
            labelO.Location = new Point(276, 394);
            labelO.Name = "labelO";
            labelO.Size = new Size(33, 15);
            labelO.TabIndex = 7;
            labelO.Text = "O - 0";
            labelO.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(356, 418);
            Controls.Add(labelO);
            Controls.Add(labelR);
            Controls.Add(labelX);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "X si O";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tematiciToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem rosuToolStripMenuItem;
        private ToolStripMenuItem verdeToolStripMenuItem;
        private ToolStripMenuItem dificultateToolStripMenuItem;
        private ToolStripMenuItem cuPrieteniiToolStripMenuItem;
        private Label labelX;
        private Label labelR;
        private Label labelO;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem singurToolStripMenuItem;
        private ToolStripMenuItem jucatoriToolStripMenuItem;
        private ToolStripMenuItem schimbaJucatoriiToolStripMenuItem;
        private ToolStripMenuItem resetareScorToolStripMenuItem;
    }
}