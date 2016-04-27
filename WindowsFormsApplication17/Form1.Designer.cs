namespace WindowsFormsApplication17
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPanel = new System.Windows.Forms.Panel();
            this.ExceptionTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кРешениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParcePage = new System.Windows.Forms.TabPage();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.CalculatorPage = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Journal1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.Mnoj = new System.Windows.Forms.Button();
            this.Parce = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Ravno = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OptionsPage = new System.Windows.Forms.TabPage();
            this.PolishBox = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowAnswers = new System.Windows.Forms.CheckBox();
            this.button33 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.advancedButton2 = new WindowsFormsApplication17.AdvancedButton();
            this.advancedButton1 = new WindowsFormsApplication17.AdvancedButton();
            this.tabPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.ParcePage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CalculatorPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.OptionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.Silver;
            this.tabPanel.BackgroundImage = global::WindowsFormsApplication17.Properties.Resources.BackImage;
            this.tabPanel.Controls.Add(this.advancedButton2);
            this.tabPanel.Controls.Add(this.advancedButton1);
            this.tabPanel.Location = new System.Drawing.Point(-271, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(500, 517);
            this.tabPanel.TabIndex = 1;
            // 
            // ExceptionTimer
            // 
            this.ExceptionTimer.Enabled = true;
            this.ExceptionTimer.Interval = 1;
            this.ExceptionTimer.Tick += new System.EventHandler(this.ExceptionTimer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.добавитьКToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // добавитьКToolStripMenuItem
            // 
            this.добавитьКToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кРешениюToolStripMenuItem,
            this.кToolStripMenuItem});
            this.добавитьКToolStripMenuItem.Name = "добавитьКToolStripMenuItem";
            this.добавитьКToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.добавитьКToolStripMenuItem.Text = "Добавить к примеру..";
            this.добавитьКToolStripMenuItem.Click += new System.EventHandler(this.добавитьКToolStripMenuItem_Click);
            // 
            // кРешениюToolStripMenuItem
            // 
            this.кРешениюToolStripMenuItem.Name = "кРешениюToolStripMenuItem";
            this.кРешениюToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.кРешениюToolStripMenuItem.Text = "Решение";
            this.кРешениюToolStripMenuItem.Click += new System.EventHandler(this.кРешениюToolStripMenuItem_Click);
            // 
            // кToolStripMenuItem
            // 
            this.кToolStripMenuItem.Name = "кToolStripMenuItem";
            this.кToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.кToolStripMenuItem.Text = "Ответ";
            this.кToolStripMenuItem.Click += new System.EventHandler(this.кToolStripMenuItem_Click);
            // 
            // ParcePage
            // 
            this.ParcePage.BackColor = System.Drawing.Color.Silver;
            this.ParcePage.Controls.Add(this.button32);
            this.ParcePage.Controls.Add(this.button31);
            this.ParcePage.Controls.Add(this.panel3);
            this.ParcePage.Controls.Add(this.textBox2);
            this.ParcePage.Controls.Add(this.panel2);
            this.ParcePage.Location = new System.Drawing.Point(4, 22);
            this.ParcePage.Name = "ParcePage";
            this.ParcePage.Padding = new System.Windows.Forms.Padding(3);
            this.ParcePage.Size = new System.Drawing.Size(550, 585);
            this.ParcePage.TabIndex = 0;
            this.ParcePage.Text = "ParcePage";
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(443, 6);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 23);
            this.button32.TabIndex = 22;
            this.button32.Text = "Настройки";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button31.ForeColor = System.Drawing.Color.Red;
            this.button31.Location = new System.Drawing.Point(287, 418);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(64, 60);
            this.button31.TabIndex = 21;
            this.button31.Text = "✖";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(386, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 451);
            this.panel3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(20, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBox2.Size = new System.Drawing.Size(336, 64);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "30*x-20=x+20";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button30);
            this.panel2.Controls.Add(this.button29);
            this.panel2.Controls.Add(this.button28);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Controls.Add(this.button23);
            this.panel2.Controls.Add(this.button24);
            this.panel2.Controls.Add(this.button25);
            this.panel2.Controls.Add(this.button26);
            this.panel2.Controls.Add(this.button27);
            this.panel2.Location = new System.Drawing.Point(-31, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 365);
            this.panel2.TabIndex = 16;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button30.FlatAppearance.BorderSize = 2;
            this.button30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button30.Location = new System.Drawing.Point(187, 88);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(60, 60);
            this.button30.TabIndex = 23;
            this.button30.Tag = "Controls";
            this.button30.Text = "...";
            this.button30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button29.FlatAppearance.BorderSize = 2;
            this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button29.Location = new System.Drawing.Point(120, 88);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(60, 60);
            this.button29.TabIndex = 22;
            this.button29.Tag = "Controls";
            this.button29.Text = "Y";
            this.button29.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button28.FlatAppearance.BorderSize = 2;
            this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.Location = new System.Drawing.Point(54, 88);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(60, 60);
            this.button28.TabIndex = 21;
            this.button28.Tag = "Controls";
            this.button28.Text = "X";
            this.button28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(253, 286);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 60);
            this.button13.TabIndex = 20;
            this.button13.Tag = "Controls";
            this.button13.Text = ",";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(253, 220);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(129, 60);
            this.button14.TabIndex = 19;
            this.button14.Tag = "Controls";
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(253, 154);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(129, 60);
            this.button15.TabIndex = 18;
            this.button15.Tag = "Controls";
            this.button15.Text = ":";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(253, 88);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(129, 60);
            this.button16.TabIndex = 17;
            this.button16.Tag = "Controls";
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(253, 22);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(129, 60);
            this.button17.TabIndex = 16;
            this.button17.Tag = "Controls";
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Yellow;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button18.FlatAppearance.BorderSize = 2;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(51, 18);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(129, 60);
            this.button18.TabIndex = 15;
            this.button18.Tag = "Controls";
            this.button18.Text = "=>";
            this.button18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(54, 220);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 60);
            this.button19.TabIndex = 9;
            this.button19.Tag = "Controls";
            this.button19.Text = "4";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(186, 286);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(60, 60);
            this.button20.TabIndex = 14;
            this.button20.Tag = "Controls";
            this.button20.Text = "9";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(54, 154);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 60);
            this.button21.TabIndex = 6;
            this.button21.Tag = "Controls";
            this.button21.Text = "1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(120, 286);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(60, 60);
            this.button22.TabIndex = 13;
            this.button22.Tag = "Controls";
            this.button22.Text = "8";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(120, 154);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(60, 60);
            this.button23.TabIndex = 7;
            this.button23.Tag = "Controls";
            this.button23.Text = "2";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(54, 286);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(60, 60);
            this.button24.TabIndex = 12;
            this.button24.Tag = "Controls";
            this.button24.Text = "7";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button25.Location = new System.Drawing.Point(186, 154);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(60, 60);
            this.button25.TabIndex = 8;
            this.button25.Tag = "Controls";
            this.button25.Text = "3";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.Location = new System.Drawing.Point(186, 220);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(60, 60);
            this.button26.TabIndex = 11;
            this.button26.Tag = "Controls";
            this.button26.Text = "6";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.Location = new System.Drawing.Point(120, 220);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(60, 60);
            this.button27.TabIndex = 10;
            this.button27.Tag = "Controls";
            this.button27.Text = "5";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // CalculatorPage
            // 
            this.CalculatorPage.BackColor = System.Drawing.Color.Silver;
            this.CalculatorPage.Controls.Add(this.button10);
            this.CalculatorPage.Controls.Add(this.button11);
            this.CalculatorPage.Controls.Add(this.Journal1);
            this.CalculatorPage.Controls.Add(this.panel1);
            this.CalculatorPage.Controls.Add(this.textBox1);
            this.CalculatorPage.Controls.Add(this.label1);
            this.CalculatorPage.Location = new System.Drawing.Point(4, 22);
            this.CalculatorPage.Name = "CalculatorPage";
            this.CalculatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalculatorPage.Size = new System.Drawing.Size(550, 585);
            this.CalculatorPage.TabIndex = 1;
            this.CalculatorPage.Text = "CalculatorPage";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(287, 420);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(64, 60);
            this.button10.TabIndex = 20;
            this.button10.Text = "✖";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Yellow;
            this.button11.Enabled = false;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(22, 221);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(129, 60);
            this.button11.TabIndex = 21;
            this.button11.Tag = "Controls";
            this.button11.Text = "↩\t";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Journal1
            // 
            this.Journal1.AutoScroll = true;
            this.Journal1.BackColor = System.Drawing.Color.DarkGray;
            this.Journal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Journal1.Location = new System.Drawing.Point(386, 45);
            this.Journal1.Name = "Journal1";
            this.Journal1.Size = new System.Drawing.Size(140, 451);
            this.Journal1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.Mnoj);
            this.panel1.Controls.Add(this.Parce);
            this.panel1.Controls.Add(this.Minus);
            this.panel1.Controls.Add(this.Plus);
            this.panel1.Controls.Add(this.Ravno);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(-31, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 365);
            this.panel1.TabIndex = 15;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(253, 286);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 20;
            this.button12.Tag = "Controls";
            this.button12.Text = ",";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Mnoj
            // 
            this.Mnoj.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mnoj.Location = new System.Drawing.Point(253, 220);
            this.Mnoj.Name = "Mnoj";
            this.Mnoj.Size = new System.Drawing.Size(129, 60);
            this.Mnoj.TabIndex = 19;
            this.Mnoj.Tag = "Controls";
            this.Mnoj.Text = "*";
            this.Mnoj.UseVisualStyleBackColor = true;
            this.Mnoj.Click += new System.EventHandler(this.Mnoj_Click);
            // 
            // Parce
            // 
            this.Parce.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parce.Location = new System.Drawing.Point(253, 154);
            this.Parce.Name = "Parce";
            this.Parce.Size = new System.Drawing.Size(129, 60);
            this.Parce.TabIndex = 18;
            this.Parce.Tag = "Controls";
            this.Parce.Text = ":";
            this.Parce.UseVisualStyleBackColor = true;
            this.Parce.Click += new System.EventHandler(this.Parce_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(253, 88);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(129, 60);
            this.Minus.TabIndex = 17;
            this.Minus.Tag = "Controls";
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(253, 22);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(129, 60);
            this.Plus.TabIndex = 16;
            this.Plus.Tag = "Controls";
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Ravno
            // 
            this.Ravno.BackColor = System.Drawing.Color.Yellow;
            this.Ravno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ravno.FlatAppearance.BorderSize = 2;
            this.Ravno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Ravno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.Ravno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ravno.Location = new System.Drawing.Point(51, 18);
            this.Ravno.Name = "Ravno";
            this.Ravno.Size = new System.Drawing.Size(129, 60);
            this.Ravno.TabIndex = 15;
            this.Ravno.Tag = "Controls";
            this.Ravno.Text = "=>";
            this.Ravno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ravno.UseVisualStyleBackColor = true;
            this.Ravno.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(54, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 9;
            this.button4.Tag = "Controls";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(186, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 14;
            this.button9.Tag = "Controls";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(54, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 6;
            this.button1.Tag = "Controls";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(120, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 13;
            this.button8.Tag = "Controls";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(120, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 7;
            this.button2.Tag = "Controls";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(54, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 12;
            this.button7.Tag = "Controls";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(186, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 8;
            this.button3.Tag = "Controls";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(186, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 11;
            this.button6.Tag = "Controls";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(120, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 10;
            this.button5.Tag = "Controls";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(20, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBox1.Size = new System.Drawing.Size(336, 64);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CalculatorPage);
            this.tabControl1.Controls.Add(this.ParcePage);
            this.tabControl1.Controls.Add(this.OptionsPage);
            this.tabControl1.Location = new System.Drawing.Point(205, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(558, 611);
            this.tabControl1.TabIndex = 2;
            // 
            // OptionsPage
            // 
            this.OptionsPage.BackColor = System.Drawing.Color.Silver;
            this.OptionsPage.Controls.Add(this.PolishBox);
            this.OptionsPage.Controls.Add(this.label2);
            this.OptionsPage.Controls.Add(this.ShowAnswers);
            this.OptionsPage.Controls.Add(this.button33);
            this.OptionsPage.Controls.Add(this.pictureBox1);
            this.OptionsPage.Location = new System.Drawing.Point(4, 22);
            this.OptionsPage.Name = "OptionsPage";
            this.OptionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsPage.Size = new System.Drawing.Size(550, 585);
            this.OptionsPage.TabIndex = 2;
            this.OptionsPage.Text = "tabPage1";
            // 
            // PolishBox
            // 
            this.PolishBox.BackColor = System.Drawing.Color.White;
            this.PolishBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolishBox.Items.Add("1/1");
            this.PolishBox.Items.Add("1/10");
            this.PolishBox.Items.Add("1/100");
            this.PolishBox.Items.Add("1/1000");
            this.PolishBox.Items.Add("1/10000");
            this.PolishBox.Items.Add("1/100000");
            this.PolishBox.Items.Add("1/1000000");
            this.PolishBox.Items.Add("1/10000000");
            this.PolishBox.Items.Add("1/100000000");
            this.PolishBox.Items.Add("1/1000000000");
            this.PolishBox.Items.Add("1/10000000000");
            this.PolishBox.Location = new System.Drawing.Point(35, 187);
            this.PolishBox.Name = "PolishBox";
            this.PolishBox.Size = new System.Drawing.Size(209, 23);
            this.PolishBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Сглаживание";
            // 
            // ShowAnswers
            // 
            this.ShowAnswers.AutoSize = true;
            this.ShowAnswers.BackColor = System.Drawing.Color.DarkGray;
            this.ShowAnswers.Checked = true;
            this.ShowAnswers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAnswers.Location = new System.Drawing.Point(28, 109);
            this.ShowAnswers.Name = "ShowAnswers";
            this.ShowAnswers.Size = new System.Drawing.Size(216, 21);
            this.ShowAnswers.TabIndex = 23;
            this.ShowAnswers.Text = "Показывать промежуточные";
            this.ShowAnswers.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button33.Location = new System.Drawing.Point(340, 415);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(157, 67);
            this.button33.TabIndex = 22;
            this.button33.Text = "Сохранить";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(26, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 407);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // advancedButton2
            // 
            this.advancedButton2.BackColor = System.Drawing.Color.Transparent;
            this.advancedButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("advancedButton2.BackgroundImage")));
            this.advancedButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.advancedButton2.Location = new System.Drawing.Point(298, 80);
            this.advancedButton2.Name = "advancedButton2";
            this.advancedButton2.Size = new System.Drawing.Size(168, 45);
            this.advancedButton2.TabIndex = 1;
            this.advancedButton2.Tag = "   КАЛЬКУЛЬ";
            // 
            // advancedButton1
            // 
            this.advancedButton1.BackColor = System.Drawing.Color.Transparent;
            this.advancedButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("advancedButton1.BackgroundImage")));
            this.advancedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.advancedButton1.Location = new System.Drawing.Point(312, 26);
            this.advancedButton1.Name = "advancedButton1";
            this.advancedButton1.Size = new System.Drawing.Size(168, 44);
            this.advancedButton1.TabIndex = 0;
            this.advancedButton1.Tag = "   КАЛЬКУЛЯТОР";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(739, 516);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ParcePage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.CalculatorPage.ResumeLayout(false);
            this.CalculatorPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.OptionsPage.ResumeLayout(false);
            this.OptionsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private WindowsFormsApplication17.AdvancedButton advancedButton1;
        private WindowsFormsApplication17.AdvancedButton advancedButton2;
        private System.Windows.Forms.Timer ExceptionTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кРешениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.TabPage ParcePage;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TabPage CalculatorPage;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel Journal1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Mnoj;
        private System.Windows.Forms.Button Parce;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Ravno;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OptionsPage;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.CheckBox ShowAnswers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown PolishBox;
    }
}

