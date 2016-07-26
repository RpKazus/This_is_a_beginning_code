using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        Point beforeLoc;
        object FakeSender = new object();
        EventArgs FakE = new EventArgs();
        public Form1()
        {
            InitializeComponent();
            ServerMachine.Invalidate = this.Invalidate;
            //this.IsMdiContainer = true;
            tabCon.Location = new Point(tabCon.Location.X, -22);
            switcher1.LinkLabel = label_proschet;
            foreach (Control i in NotePage.Controls)
            {
                i.Controls[0].Text = i.Tag.ToString();
                AdvancedButton o = (AdvancedButton)i;
                o.tabControl = tabCon;
                o.beginPoint = o.Location;
                ServerMachine.MethodToMath = MethodToMath;
            }
            tabCon.SelectedIndex = 1;
            PolishBox.SelectedIndex = 4;
            journal1.cont = contextMenuStrip1;
            journal1.method = ending1;
            journal1.textBox = textBox1;
            journal2.cont = contextMenuStrip1;
            journal2.method = ending1;
            journal2.textBox = textBox2;
            journal3.cont = contextMenuStrip1;
            journal3.method = ending3;
            journal3.textBox = text1;
            vif.Owner = this;
            btf.Owner = this;
            beforeLoc = this.Location;
            ServerMachine.button_button = button_button;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox3.SelectedValueChanged += MakeBackGround;
            comboBox1.SelectedValueChanged += ChangeLists;
            AddList(new Point(10, 10));
        }
        private void ExceptionTimer_Tick(object sender, EventArgs e)
        {
            int ChangeTime = 15;
            if (textBox1.BackColor.G < 254)
            {
                textBox1.BackColor = Color.FromArgb(255, textBox1.BackColor.G + 2, textBox1.BackColor.B + 2);
                textBox1.SelectAll();
                textBox1.SelectionBackColor = textBox1.BackColor;
            }
            if (textBox2.BackColor.G < 254)
            {
                textBox2.BackColor = Color.FromArgb(255, textBox2.BackColor.G + 2, textBox2.BackColor.B + 2);
                textBox2.SelectAll();
                textBox2.SelectionBackColor = textBox2.BackColor;
            }
            if (text1.BackColor.G < 254 && text1.BackColor.R == 255)
            {
                text1.BackColor = Color.FromArgb(255, text1.BackColor.G + 2, text1.BackColor.B + 2);
                text1.SelectAll();
                text1.SelectionBackColor = text1.BackColor;
            }
            if (text2.BackColor.G < 254 && text2.BackColor.R == 255)
            {
                text2.BackColor = Color.FromArgb(255, text2.BackColor.G + 2, text2.BackColor.B + 2);
                text2.SelectAll();
                text2.SelectionBackColor = text2.BackColor;
            }
            if (pictureBox4.Tag == "open" && Switcher.Compare(pictureBox4.BackColor.R, Switcher.CountPath(NdColor.R - StColor.R, ChangeTime), NdColor.R))
            {

                pictureBox4.BackColor = Color.FromArgb(Switcher.Compare(GrayMass[0], Switcher.CountPath(NdColor.R - StColor.R, ChangeTime), NdColor.R) ? Convert.ToInt32(GrayMass[0] += Switcher.CountPath(NdColor.R - StColor.R, ChangeTime)) : Convert.ToInt32(GrayMass[0] += NdColor.R - GrayMass[0]),
                        Switcher.Compare(GrayMass[1], Switcher.CountPath(NdColor.G - StColor.G, ChangeTime), NdColor.G) ? Convert.ToInt32(GrayMass[1] -= Switcher.CountPath(StColor.G - NdColor.G, ChangeTime)) : Convert.ToInt32(GrayMass[1] += NdColor.G - GrayMass[1]),
                        Switcher.Compare(GrayMass[2], Switcher.CountPath(NdColor.B - StColor.B, ChangeTime), NdColor.B) ? Convert.ToInt32(GrayMass[2] -= Switcher.CountPath(StColor.B - NdColor.B, ChangeTime)) : Convert.ToInt32(GrayMass[2] += NdColor.B - GrayMass[2]));
                pictureBox4.BackColor = Color.FromArgb(pictureBox4.BackColor.R, pictureBox4.BackColor.G, pictureBox4.BackColor.B);
            }
            if (!panel3.Enabled && panel3.Location.Y <= this.Height - 20)
            {
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + 1);
                //button41.Location = new Point(button41.Location.X, button41.Location.Y + 1);
                if (textPan.Height < this.Height - 200)
                {
                    textPan.Height++;
                    button41.Location = new Point(button41.Location.X, button41.Location.Y - 1);
                }
                else
                    textPan.AutoScroll = true;
                     if(textPan.Controls.Count == 1);
            }
            else if (panel3.Enabled && panel3.Location.Y > 131)
            {
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y - 1);
                //button41.Location = new Point(button41.Location.X, button41.Location.Y + 1);
                if (textPan.Height >= 65)
                { 
                    textPan.Height--;
                    button41.Location = new Point(button41.Location.X, button41.Location.Y + 1);
                }
                if (panel3.Enabled && panel3.Location.Y == 132)
                {
                    foreach (Label lab in labeList)
                        textPan.Controls.Remove(lab);
                    labeList.Clear();
                    button49.Enabled = true;
                }
            }
            if(ServerMachine.pressed != "")
            {
                switch(tabCon.SelectedIndex)
                {
                    case 0:
                        foreach (Control b in panel1.Controls)
                            if (b.Text == ServerMachine.pressed && b.GetType().Name == "Button")
                                button_Calc_Click((object)b, e);
                        break;
                    case 1:
                        foreach (Control b in panel2.Controls)
                            if (b.Text == ServerMachine.pressed && b.GetType().Name == "Button")
                                button_Parce_Click((object)b, e);
                        break;
                    case 2:
                        foreach (Control b in panel3.Controls)
                            if (b.Text == ServerMachine.pressed && b.GetType().Name == "Button")
                                buttonMath_Click((object)b, e);
                        break;
                    case 3:
                        foreach (Control b in panel4.Controls)
                            if (b.Text == ServerMachine.pressed && b.GetType().Name == "Button")
                                button_Notes_Click((object)b, e);
                        break;
                }
                ServerMachine.pressed = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        public void button_button_Click(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Calculator.Count_Paint(12, '*', 589);
            if (!btf.Visible)
            {
                btf.Show();
                button_button.Image = Properties.Resources.button_on;
                this.Focus();
            }
            else
            {
                btf.Hide();
                button_button.Image = Properties.Resources.button1;
            }
        }
        public void MethodToMath()
        {

        }
        ViewForm vif = new ViewForm();
        ButtonForm btf = new ButtonForm();
        #region Calculator
        Resume check;
        Color StColor = Color.Silver;
        Color NdColor = Color.FromArgb(255, 128, 0);
        double[] GrayMass = new double[3] { 191, 191, 191 };
        string DataString;
        bool isWorked = false;
        DataTable dt = new DataTable();
        List<Resume> Journal = new List<Resume>();
        List<Point> Clist = new List<Point>();
        List<int> ExtraClist = new List<int>();
        public void SetPoints()
        {
            int lenght = 0;
            char lastchar = '0';
            foreach (char ch in textBox1.Text)
            {
                if ((ch == '*' || ch == '/' || ch == '-' || ch == '+') && (lastchar != '*' && lastchar != '/' && lastchar != '-' && lastchar != '+'))
                {
                    ExtraClist.Add(lenght);
                    Clist.Add(new Point(Lenght(textBox1.Text.Substring(0, lenght), textBox1.Font), 0));
                    //Cursor.Position = new Point(Lenght(textBox1.Text.Substring(0, lenght)) - 50, 0);
                }
                lastchar = ch;
                lenght++;
            }
        }
        private int Lenght(string str, Font font)
        {
            PaintEventArgs e = new PaintEventArgs(this.CreateGraphics(), new Rectangle(0, 0, 1000, 1000));
            return (int)e.Graphics.MeasureString(str, font, 1000000).Width - 1 * str.Length;
            //return (int)(str.Length * font.Size / (35 / 33));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataString = textBox1.Text;
            ServerMachine.type = DataString;
            textBox1.Text = textBox1.Text.Replace(',', '.');
            journal1.AddResume(textBox1.Text);
            try
            {
                dt.Compute(textBox1.Text, string.Empty);
                if (ShowAnswers.Checked)
                    SetPoints();
                textBox1.Text += "=" + dt.Compute(textBox1.Text, string.Empty);
                button11.Enabled = true;
                textBox1.ReadOnly = true;
                foreach (Control c in panel1.Controls)
                    c.Enabled = false;
                isWorked = true;
            }
            catch (Exception)
            {
                textBox1.BackColor = Color.FromArgb(255, 0, 0);
            }
            textBox1.Text = textBox1.Text.Replace('.', ',');
            button37.Enabled = true;
        }
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isWorked)
            {
                int step = 0;
                foreach (Point pp in Clist)
                {
                    Point pp1 = new Point(pp.X + textBox1.Location.X + tabCon.Location.X + 7 + this.Location.X, pp.Y + textBox1.Location.Y + tabCon.Location.Y + 32 + this.Location.Y);
                    Rectangle rect1 = new Rectangle(pp1, new Size(Lenght("+", textBox1.Font), textBox1.Height));
                    //Rectangle rect2 = new Rectangle(new Point(MousePosition.X - textBox1.Location.Y - tabControl1.Location.X - 6 - this.Location.X, MousePosition.Y - 31 - tabControl1.Location.Y - textBox1.Location.Y - this.Location.Y), new Size(1, 1));
                    Rectangle rect2 = new Rectangle(new Point(MousePosition.X, MousePosition.Y), new Size(1, 1));
                    if (rect1.IntersectsWith(rect2))
                    {

                        textBox1.SelectAll();
                        textBox1.SelectionBackColor = Color.White;
                        textBox1.Select(ExtraClist[step], 1);
                        textBox1.SelectionBackColor = Color.Yellow;
                        label1.Font = textBox1.Font;
                        label1.Text = Calculator.Compute(DataString, ExtraClist[step]).ToString();
                        label1.Location = new Point(rect1.Location.X - this.Location.X - 14 - tabCon.Location.X, rect1.Location.Y - this.Location.Y - label1.PreferredHeight - 62 - tabCon.Location.Y);
                        label1.BringToFront();
                        textBox1.DeselectAll();
                    }
                    step++;
                }
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (isWorked)
            {
                textBox1.SelectAll();
                textBox1.SelectionBackColor = Color.White;
                label1.Text = "";
                textBox1.DeselectAll();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            while (Lenght(textBox1.Text, textBox1.Font) >= textBox1.Width)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size - 1, textBox1.Font.Style);
            }
            while (Lenght(textBox1.Text, textBox1.Font) < textBox1.Width - 30 && textBox1.Font.Size < 33)
            {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size + 1, textBox1.Font.Style);
            }
            //textBox1.Text = textBox1.Text.Replace("/n", "");
        }
        private void button_Calc_Click(object sender, EventArgs e)
        {
            foreach (Control p in panel1.Controls)
                if (sender.Equals(p))
                {
                    var selectionIndex = textBox1.SelectionStart;
                    textBox1.Text = textBox1.Text.Insert(selectionIndex, p.Text);
                    textBox1.SelectionStart = selectionIndex + p.Text.Length;
                }
        }
        public void ending1()
        {
            isWorked = false;
            foreach (Control c in panel1.Controls)
                if (c != button10)
                    c.Enabled = true;
            button11.Enabled = false;
            Clist.Clear();
            ExtraClist.Clear();
            textBox1.ReadOnly = false;
            button37.Enabled = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '=')
                    textBox1.Text = textBox1.Text.Substring(i + 1, textBox1.Text.Length - 1 - i);
            }
            ending1();
            textBox2.Focus();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            кToolStripMenuItem.Enabled = true;
            check = (Resume)((ContextMenuStrip)sender).SourceControl;
            try
            {
                dt.Compute(check.Link, string.Empty);
            }
            catch (Exception)
            {
                кToolStripMenuItem.Enabled = false;
            }
        }

        private void кРешениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += check.Link;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ending1();
            textBox1.Text = "";
            textBox1.Font = new Font(textBox1.Font.FontFamily, 34, textBox1.Font.Style);
        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += dt.Compute(check.Link, string.Empty);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (button11.Visible)
            {
                panel1.Location = new Point(panel1.Location.X, button79.Location.Y - 3);
                panel1.Height = 16;
            }
            else
            {
                panel1.Location = new Point(panel1.Location.X, 131);
                panel1.Height = 365;
            }
            button11.Visible = !button11.Visible;
            button10.Visible = !button10.Visible;
        }
        #endregion
        #region Deductions
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            while (Lenght(textBox2.Text, textBox2.Font) >= textBox1.Width)
            {
                textBox2.Font = new Font(textBox2.Font.FontFamily, textBox2.Font.Size - 1, textBox2.Font.Style);
            }
            while (Lenght(textBox2.Text, textBox2.Font) < textBox2.Width - 30 && textBox2.Font.Size < 33)
            {
                textBox2.Font = new Font(textBox2.Font.FontFamily, textBox2.Font.Size + 1, textBox2.Font.Style);
            }
            //textBox1.Text = textBox1.Text.Replace("/n", "");
        }
        private void button_Parce_Click(object sender, EventArgs e)
        {
            foreach (Control p in panel2.Controls)
                if (sender.Equals(p))
                {
                    var selectionIndex = textBox2.SelectionStart;
                    textBox2.Text = textBox2.Text.Insert(selectionIndex, p.Text);
                    textBox2.SelectionStart = selectionIndex + p.Text.Length;
                }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }
        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                //textBox2.Text = Calculator.Compute(textBox2.Text, 'x', (double)dt.Compute(PolishBox.SelectedItem.ToString(), string.Empty)).ToString();
                Calculator.Begin();
                journal2.AddResume(textBox2.Text);
                textBox2.Text = textBox2.Text.Replace(',', '.');
                textBox2.Text = Calculator.MakeX('+' + textBox2.Text);
                textBox2.Text = textBox2.Text.Replace('.', ',');
                //textBox2.Text = Calculator.Simpler('+' + textBox2.Text, 6, 11, 1, true);
            }
            catch (Exception)
            {
                textBox2.BackColor = Color.Red;
            }
        }
        private void button31_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "посчитать");
            label3.Width = label3.PreferredWidth;
            //button1.Text = dt.Compute("7+((5/7-3)*18-(35-4/3))/9", string.Empty).ToString();
        }

        private void switcher1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void switcher1_Click(object sender, EventArgs e)
        {
            Calculator.Polish = switcher1.Enable;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            StColor = Color.Silver;
            NdColor = Color.FromArgb(255, 128, 0);
            GrayMass = new double[3] { 191, 191, 191 };
            pictureBox4.Tag = "open";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            StColor = Color.FromArgb(255, 128, 0);
            NdColor = Color.Silver;
            GrayMass = new double[3] { 255, 128, 0 };
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += "(";
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += ")";
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            ServerMachine.primer = textBox1.Text;
            vif.ShowDialog();
        }
        #endregion
        #region Math
        int step = -1;
        string anchor;
        List<Label> labeList = new List<Label>();
        List<Label>[] moves = new List<Label>[5] {new List<Label>(), new List<Label>(), new List<Label>(), new List<Label>(), new List<Label>() };
        private void buttonMath_Click(object sender, EventArgs e)
        {
            if (text2.Tag == null)
                text2.Tag = string.Empty;
            foreach (Control p in panel3.Controls)
                if (sender.Equals(p))
                {
                    var selectionIndex = 0;
                    selectionIndex = (text2.Tag == string.Empty) ? text1.SelectionStart : Convert.ToInt16(text2.Tag);
                    if (text2.Tag != string.Empty)
                    {
                        text2.Text = text2.Text.Insert(selectionIndex, p.Text);
                        text2.SelectionStart = selectionIndex + p.Text.Length;
                    }
                    else
                    {
                        text1.Text = text1.Text.Insert(selectionIndex, p.Text);
                        text1.SelectionStart = selectionIndex + p.Text.Length;

                    }
                }
        }
        private Label SetLabel(string text, Font font, Point location, Size size, Control.ControlCollection labelist)
        {
            Label name = new Label();
            name.Font = font;
            name.Location = location;
            name.Text = text;
            name.Size = size;
            name.BringToFront();
            labelist.Add(name);
            return name;
        }
        private void Plussing(string st, string nd)
        {
            if (st == "" || nd == "")
                throw new FormatException();
                journal3.AddResume(st + prusbutton.Text + nd);
                panel3.Enabled = false;
                //
                int path = 125;
                int stLength = Calculator.Find(st, ',');
                int ndLength = Calculator.Find(nd, ',');
                    while (st.Length - (stLength == -1 ? st.Length : stLength) > nd.Length - (ndLength == -1 ? nd.Length : ndLength))
                    {
                        if (ndLength == -1)
                        {
                            ndLength = nd.Length;
                            nd += ',';
                        }
                        nd += '0';
                    }
                    while (st.Length - (stLength == -1 ? st.Length : stLength) < nd.Length - (ndLength == -1 ? nd.Length : ndLength))
                    {
                        if (stLength == -1)
                        {
                            stLength = st.Length;
                            st += ',';
                        }
                        st += '0';
                    }
                foreach (char ch in st)
                {
                    labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(path, text1.Height + 75), new Size(33, 50), textPan.Controls));
                    if (labeList[labeList.Count - 1].Text != ",")
                    {
                        moves[0].Add(labeList[labeList.Count - 1]);
                        Label lab = new Label();
                        lab.Text = "1";
                        lab.Font = new Font("", 12);
                        lab.AutoSize = true;
                        lab.BackColor = Color.Yellow;
                        lab.Visible = false;
                        int b = 0;
                        if(path >= 175)
                            b = labeList[labeList.Count - 2].Text == "," ? labeList[labeList.Count - 1].Location.X - 40 : labeList[labeList.Count - 1].Location.X - 15;
                        lab.Location = new Point(b, labeList[labeList.Count - 1].Location.Y - 22);
                        textPan.Controls.Add(lab);
                        labeList.Add(lab);
                        moves[3].Add(labeList[labeList.Count - 1]);
                        lab.BringToFront();
                    }
                    path += 25;
                }
                //
                path = 125// - ((st.Length - (stLenght == -1 ? st.Length : (stLenght + 1))) - (nd.Length - (ndLenght == -1 ? nd.Length : (ndLenght + 1)))) * 22;
                ;
                foreach (char ch in nd)
                {
                    labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(Lenght(st, new Font("", 35)) - Lenght(nd, new Font("", 35)) + path, text1.Height + 125), new Size(33, 50), textPan.Controls));
                    if(labeList[labeList.Count - 1].Text != ",")
                        moves[1].Add(labeList[labeList.Count - 1]);
                    path += 25;
                }
                //
                string answer = "___";
                string real_answer = (Convert.ToDouble(st) + Convert.ToDouble(nd)).ToString();
                int rdLength = Calculator.Find(real_answer, ',');
                while (real_answer.Length - (rdLength == -1 ? real_answer.Length : rdLength) < nd.Length - (ndLength == -1 ? nd.Length : ndLength))
                {
                    if (rdLength == -1)
                    {
                        rdLength = real_answer.Length;
                        real_answer += ',';
                    }
                    real_answer += '0';
                }
                foreach (char ch in real_answer)
                    answer += '_';
                labeList.Add(SetLabel("+", new Font("", 35), new Point((labeList[0].Location.X <= labeList[st.Length * 2].Location.X) ? labeList[0].Location.X - 33 : labeList[st.Length * 2].Location.X - 33, text1.Height + 100), new Size(33, 50), textPan.Controls));
                labeList.Add(SetLabel(answer, new Font("", 35), new Point((labeList[0].Location.X <= labeList[st.Length * 2].Location.X) ? labeList[0].Location.X - 33 : labeList[st.Length * 2].Location.X - 33, labeList[st.Length * 2].Location.Y + 10), new Size(Lenght(answer, text1.Font), 50), textPan.Controls));
                //SetLabel(real_answer.ToString(), new Font("", 35), new Point(labeList[labeList.Count - 1].Location.X, labeList[labeList.Count - 1].Location.Y + 60), new Size(Lenght(answer, text1.Font), 50), textPan.Controls);
                path = (moves[0][moves[0].Count - 1].Location.X + moves[0][moves[0].Count - 1].Width) - Lenght(real_answer, new Font("", 35));
                foreach (char ch in real_answer.ToString())
                {
                    labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(path, text1.Height + 180), new Size(33, 50), textPan.Controls));
                    //if (labeList[labeList.Count - 1].Text != ",")
                        moves[2].Add(labeList[labeList.Count - 1]);
                    labeList[labeList.Count - 1].Visible = false;
                    path += 25;
                }
                moves[0].Reverse();
                moves[1].Reverse();
                moves[2].Reverse();
                moves[3].Reverse();
        }
        private void Mnossing(string st, string nd)
        {
            if (st == "" || nd == "")
                throw new FormatException();
            journal3.AddResume(st + prusbutton.Text + nd);
            panel3.Enabled = false;
            //
            int path = 125;
            int stLength = Calculator.Find(st, ',');
            int ndLength = Calculator.Find(nd, ',');
            while (st.Length - (stLength == -1 ? st.Length : stLength) > nd.Length - (ndLength == -1 ? nd.Length : ndLength))
            {
                if (ndLength == -1)
                {
                    ndLength = nd.Length;
                    nd += ',';
                }
                nd += '0';
            }
            while (st.Length - (stLength == -1 ? st.Length : stLength) < nd.Length - (ndLength == -1 ? nd.Length : ndLength))
            {
                if (stLength == -1)
                {
                    stLength = st.Length;
                    st += ',';
                }
                st += '0';
            }
            string[] strack = new string[nd.Length];
            foreach (char ch in st)
            {
                labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(path, nd.Length > 6 ? text1.Height + 22 * nd.Length : text1.Height + 125), new Size(33, 50), textPan.Controls));
                if (labeList[labeList.Count - 1].Text != ",")
                {
                    moves[0].Add(labeList[labeList.Count - 1]);
                    foreach(char cho in nd)
                    {
                        int length = 22;
                        Label lab = new Label();
                        lab.Text = "1";
                        lab.Font = new Font("", 12);
                        lab.AutoSize = true;
                        lab.BackColor = Color.Yellow;
                        //lab.Visible = false;
                        int b = 0;
                            b = moves[0][moves[0].Count - 1].Location.X - 15;
                        lab.Location = new Point(b, labeList[labeList.Count - 1].Location.Y - length);
                        length += 22;
                        textPan.Controls.Add(lab);
                        labeList.Add(lab);
                        moves[3].Add(labeList[labeList.Count - 1]);
                        lab.BringToFront();
                    }
                }
                path += 25;
            }
            //
            path = 125// - ((st.Length - (stLenght == -1 ? st.Length : (stLenght + 1))) - (nd.Length - (ndLenght == -1 ? nd.Length : (ndLenght + 1)))) * 22;
            ;
            foreach (char ch in nd)
            {
                labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(Lenght(st, new Font("", 35)) - Lenght(nd, new Font("", 35)) + path, text1.Height + moves[0][0].Location.Y ), new Size(33, 50), textPan.Controls));
                if (labeList[labeList.Count - 1].Text != ",")
                    moves[1].Add(labeList[labeList.Count - 1]);
                path += 25;
            }
            //
            string answer = "___";
            string nully = "";
            int bath = moves[1][0].Location.Y + 60;
            for(int i = nd.Length - 1; i >= 0; i--)
            {
                strack[nd.Length - 1 - i] = (Convert.ToInt32(nd[i].ToString()) * Convert.ToInt32(st.Replace(",", "."))).ToString().Replace(".", "") + nully;
                path = 125;
                foreach (char ch in (Convert.ToInt32(nd[i].ToString()) * Convert.ToInt32(st.Replace(",", "."))).ToString().Replace(".", "") + nully)
                {
                    labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(Lenght(st, new Font("", 35)) - Lenght((Convert.ToInt32(nd[i].ToString()) * Convert.ToInt32(st.Replace(",", "."))).ToString().Replace(".", "") + nully, new Font("", 35)) + path, bath), new Size(33, 50), textPan.Controls));
                    if (labeList[labeList.Count - 1].Text != ",")
                        moves[4].Add(labeList[labeList.Count - 1]);
                    path += 25;
                }
                bath += 50;
                nully += "0";
            }
            string real_answer = (Convert.ToDouble(st) * Convert.ToDouble(nd)).ToString();
            int rdLength = Calculator.Find(real_answer, ',');
            while (real_answer.Length - (rdLength == -1 ? real_answer.Length : rdLength) < nd.Length - (ndLength == -1 ? nd.Length : ndLength))
            {
                if (rdLength == -1)
                {
                    rdLength = real_answer.Length;
                    real_answer += ',';
                }
                real_answer += '0';
            }
            foreach (char ch in real_answer)
                answer += '_';
            labeList.Add(SetLabel("×", new Font("", 35), new Point((moves[0][0].Location.X <= moves[1][0].Location.X) ? moves[0][0].Location.X - 33 : moves[1][0].Location.X - 33, moves[0][0].Location.Y + 25), new Size(33, 50), textPan.Controls));
            labeList.Add(SetLabel(answer, new Font("", 35), new Point((moves[0][moves[0].Count - 1].Location.X <= moves[1][moves[1].Count - 1].Location.X) ? moves[0][moves[0].Count - 1].Location.X + 99 - Lenght(answer, new Font("", 35)) : moves[1][moves[1].Count - 1].Location.X + 99 -Lenght(answer, new Font("", 35)), moves[1][0].Location.Y + 10), new Size(Lenght(answer, text1.Font), 50), textPan.Controls));
            labeList.Add(SetLabel(answer, new Font("", 35), new Point((moves[0][moves[0].Count - 1].Location.X <= moves[1][moves[1].Count - 1].Location.X) ? moves[0][moves[0].Count - 1].Location.X + 99 - Lenght(answer, new Font("", 35)) : moves[1][moves[1].Count - 1].Location.X + 99 - Lenght(answer, new Font("", 35)), moves[4][moves[4].Count - 1].Location.Y + 10), new Size(Lenght(answer, text1.Font), 50), textPan.Controls));
            //SetLabel(real_answer.ToString(), new Font("", 35), new Point(labeList[labeList.Count - 1].Location.X, labeList[labeList.Count - 1].Location.Y + 60), new Size(Lenght(answer, text1.Font), 50), textPan.Controls);
            path = (moves[0][moves[0].Count - 1].Location.X + moves[0][moves[0].Count - 1].Width) - Lenght(real_answer, new Font("", 35));
            foreach (char ch in real_answer.ToString())
            {
                labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(path, moves[4][moves[4].Count - 1].Location.Y + 60), new Size(33, 50), textPan.Controls));
                //if (labeList[labeList.Count - 1].Text != ",")
                moves[2].Add(labeList[labeList.Count - 1]);
                labeList[labeList.Count - 1].Visible = false;
                path += 25;
            }
            moves[0].Reverse();
            moves[1].Reverse();
            moves[2].Reverse();
            moves[3].Reverse();
            moves[4].Reverse();
            foreach(Control ctrl in labeList)
                if (ctrl.Location.X < 0)
                    foreach (Control con in textPan.Controls)
                        con.Location = new Point(con.Location.X - ctrl.Location.X, con.Location.Y);
        }
        private void button49_Click(object sender, EventArgs e)
        {
            try
            {
                switch(prusbutton.Text)
                {
                    case "+":
                        Plussing(dt.Compute(text1.Text.Replace(',', '.'), string.Empty).ToString(), dt.Compute(text2.Text.Replace(',', '.'), string.Empty).ToString());
                    break;
                    case "-":
                        Minussing(dt.Compute(text1.Text.Replace(',', '.'), string.Empty).ToString(), dt.Compute(text2.Text.Replace(',', '.'), string.Empty).ToString());
                    break;
                    case "*":
                    Mnossing(dt.Compute(text1.Text.Replace(',', '.'), string.Empty).ToString(), dt.Compute(text2.Text.Replace(',', '.'), string.Empty).ToString());
                    break;
                }
                button49.Enabled = false;
                anchor = prusbutton.Text;
            }
            catch (Exception)
            {
                text1.BackColor = Color.Red;
                text2.BackColor = Color.Red;
            }
        }
        private void Minussing(string st, string nd)
        {
            if (st == "" || nd == "")
                throw new FormatException();
            journal3.AddResume(st + prusbutton.Text + nd);
            panel3.Enabled = false;
            //
            int path = 125;
            int stLength = Calculator.Find(st, ',');
            int ndLength = Calculator.Find(nd, ',');
            while (st.Length - (stLength == -1 ? st.Length : stLength) > nd.Length - (ndLength == -1 ? nd.Length : ndLength))
            {
                if (ndLength == -1)
                {
                    ndLength = nd.Length;
                    nd += ',';
                }
                nd += '0';
            }
            while (st.Length - (stLength == -1 ? st.Length : stLength) < nd.Length - (ndLength == -1 ? nd.Length : ndLength))
            {
                if (stLength == -1)
                {
                    stLength = st.Length;
                    st += ',';
                }
                st += '0';
            }
            foreach (char ch in st)
            {
                labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(path, text1.Height + 75), new Size(33, 50), textPan.Controls));
                if (labeList[labeList.Count - 1].Text != ",")
                {
                    moves[0].Add(labeList[labeList.Count - 1]);
                    Label lab = new Label();
                    lab.Text = "•";
                    lab.Font = new Font("", 12);
                    lab.AutoSize = true;
                    lab.BackColor = Color.Yellow;
                    lab.Visible = false;
                    int b = moves[0][moves[0].Count - 1].Location.X - 15;
                    lab.Location = new Point(b, labeList[labeList.Count - 1].Location.Y - 22);
                    textPan.Controls.Add(lab);
                    labeList.Add(lab);
                    moves[3].Add(labeList[labeList.Count - 1]);
                    lab.BringToFront();
                }
                if (labeList[labeList.Count - 2].Text == ",")
                    moves[3][moves[3].Count - 1].Location = new Point(moves[3][moves[3].Count - 1].Location.X - path, moves[3][moves[3].Count - 1].Location.Y);
                path += 25;
            }
            //
            path = 125// - ((st.Length - (stLenght == -1 ? st.Length : (stLenght + 1))) - (nd.Length - (ndLenght == -1 ? nd.Length : (ndLenght + 1)))) * 22;
            ;
            foreach (char ch in nd)
            {
                labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(Lenght(st, new Font("", 35)) - Lenght(nd, new Font("", 35)) + path, text1.Height + 125), new Size(33, 50), textPan.Controls));
                if (labeList[labeList.Count - 1].Text != ",")
                    moves[1].Add(labeList[labeList.Count - 1]);
                path += 25;
            }
            //
            string answer = "___";
            string real_answer = (Convert.ToDouble(st) - Convert.ToDouble(nd)).ToString();
            int rdLength = Calculator.Find(real_answer, ',');
            while (real_answer.Length - (rdLength == -1 ? real_answer.Length : rdLength) < nd.Length - (ndLength == -1 ? nd.Length : ndLength))
            {
                if (rdLength == -1)
                {
                    rdLength = real_answer.Length;
                    real_answer += ',';
                }
                real_answer += '0';
            }
            foreach (char ch in real_answer)
                answer += '_';
            labeList.Add(SetLabel("+", new Font("", 35), new Point((labeList[0].Location.X <= labeList[st.Length * 2].Location.X) ? labeList[0].Location.X - 33 : labeList[st.Length * 2].Location.X - 33, text1.Height + 100), new Size(33, 50), textPan.Controls));
            labeList.Add(SetLabel(answer, new Font("", 35), new Point((labeList[0].Location.X <= labeList[st.Length * 2].Location.X) ? labeList[0].Location.X - 33 : labeList[st.Length * 2].Location.X - 33, labeList[st.Length * 2].Location.Y + 10), new Size(Lenght(answer, text1.Font), 50), textPan.Controls));
            //SetLabel(real_answer.ToString(), new Font("", 35), new Point(labeList[labeList.Count - 1].Location.X, labeList[labeList.Count - 1].Location.Y + 60), new Size(Lenght(answer, text1.Font), 50), textPan.Controls);
            path = (moves[0][moves[0].Count - 1].Location.X + moves[0][moves[0].Count - 1].Width) - Lenght(real_answer, new Font("", 35));
            foreach (char ch in real_answer.ToString())
            {
                labeList.Add(SetLabel(ch.ToString(), new Font("", 35), new Point(path, text1.Height + 180), new Size(33, 50), textPan.Controls));
                //if (labeList[labeList.Count - 1].Text != ",")
                moves[2].Add(labeList[labeList.Count - 1]);
                labeList[labeList.Count - 1].Visible = false;
                path += 25;
            }
            moves[0].Reverse();
            moves[1].Reverse();
            moves[2].Reverse();
            moves[3].Reverse();
        }
        private void ButtonMath_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ending3()
        {
            EventArgs e = new EventArgs();
            object sender = new object();
            button41_Click(sender, e);
            int ch = Calculator.GetChar(text1.Text);
            text2.Text = text1.Text.Substring(ch + 1, text1.Text.Length - 1 - ch);
            prusbutton.Text = text1.Text[ch].ToString();
            text1.Text = text1.Text.Substring(0, ch);

        }
        private void button41_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            textPan.AutoScroll = false;
            step = -1;
            moves[0].Clear();
            moves[1].Clear();
            moves[2].Clear();
            moves[3].Clear();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            switch(prusbutton.Text)
            {
                case "+":
                    prusbutton.Text = "-";
                    break;
                case "-":
                    prusbutton.Text = "*";
                    break;
                case "*":
                    prusbutton.Text = "/";
                    break;
                case "/":
                    prusbutton.Text = "+";
                    break;
            }
        }
        #region dop
        private void text2_Enter(object sender, EventArgs e)
        {
            text2.Tag = text2.SelectionStart;
        }

        private void text2_Leave(object sender, EventArgs e)
        {
            if(text1.Focused)
                text2.Tag = string.Empty;
            else
                text2.Focus();
        }

        private void text1_Leave(object sender, EventArgs e)
        {
            if (text2.Focused)
                text1.Tag = string.Empty;
            else
                text1.Focus();
        }

        private void toodit_MouseEnter(object sender, EventArgs e)
        {
            toodit.BackgroundImage = Properties.Resources.тудыть_вкл;
        }

        private void toodit_MouseLeave(object sender, EventArgs e)
        {
            toodit.BackgroundImage = Properties.Resources.тудыть;
        }

        private void untoodit_MouseEnter(object sender, EventArgs e)
        {
            untoodit.BackgroundImage = Properties.Resources.оттудыть_вкл;
        }

        private void untoodit_MouseLeave(object sender, EventArgs e)
        {
            untoodit.BackgroundImage = Properties.Resources.оттудыть;
        }
        #endregion
        private void toodit_MouseDown(object sender, MouseEventArgs e)
        {
            if (anchor == "+" || anchor == "-")
            {
                #region plussing
                if (step < moves[2].Count)
                {
                    toodit.BackgroundImage = Properties.Resources.тудыть;
                    step++;
                }
                try
                {
                    moves[2][step].BackColor = Color.Silver;
                    moves[2][step].Visible = true;
                    if (step > 1)
                        moves[2][step - 2].BackColor = Color.Transparent;
                    if (moves[2][step].Text == ",")
                    {
                        moves[2][step + 1].Visible = true;
                        moves[2].Remove(moves[2][step]);
                    }
                }
                catch(Exception)
                {
                }
                untoodit.Enabled = true;
                try
                {
                    moves[0][step].BackColor = Color.Yellow;
                }
                catch (Exception)
                {
                }
                try
                {
                    moves[1][step].BackColor = Color.Yellow;
                }
                catch (Exception)
                {
                }
                if (step > 0)
                {
                    try
                    {
                        moves[0][step - 1].BackColor = Color.Transparent;
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        moves[1][step - 1].BackColor = Color.Transparent;
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        moves[2][step - 1].BackColor = Color.Transparent;
                        moves[3][step - 1].BackColor = Color.Yellow;
                        moves[3][step - 1].ForeColor = Color.Black;
                        if(step > 1)
                            moves[3][step - 2].BackColor = Color.Transparent;
                    }
                    catch (Exception)
                    {
                    }
                }
                try
                {
                    if ((anchor == "-" && Convert.ToInt16(moves[0][step].Text) - Convert.ToInt16(moves[3][step - 1].Enabled) - Convert.ToInt16(moves[1][step].Text) < 0) || (anchor == "+" && Convert.ToInt16(moves[0][step].Text) + Convert.ToInt16(moves[3][step - 1].Enabled) + Convert.ToInt16(moves[1][step].Text) >= 10))
                    {
                        moves[3][step].Visible = true;
                        moves[3][step].BackColor = Color.Transparent;
                        moves[3][step].ForeColor = Color.Gray;

                        if (step >= 0)
                            moves[3][step - 1].BackColor = Color.Transparent;
                    }
                }
                catch (Exception)
                {
                }
                #endregion
            }
            else if (anchor == "*")
            {
                #region mnossing
                if (step < moves[2].Count)
                {
                    toodit.BackgroundImage = Properties.Resources.тудыть;
                    step++;
                }
                Label activeLabel0 = moves[0][step % moves[0].Count];
                Label activeLabel1 = moves[1][step / moves[0].Count + (step % moves[0].Count)];
                Label activeLabel2 = moves[2][step];
                Label activeLabel3 = moves[3][(step % moves[0].Count) * moves[1].Count + (step / moves[0].Count + (step % moves[0].Count))];
                try
                {
                    moves[2][step].BackColor = Color.Silver;
                    moves[2][step].Visible = true;
                    if (step > 1)
                        moves[2][step - 2].BackColor = Color.Transparent;
                    if (moves[2][step].Text == ",")
                    {
                        moves[2][step + 1].Visible = true;
                        moves[2].Remove(moves[2][step]);
                    }
                }
                catch (Exception)
                {
                }
                untoodit.Enabled = true;
                try
                {
                    moves[0][step].BackColor = Color.Yellow;
                }
                catch (Exception)
                {
                }
                try
                {
                    moves[1][step].BackColor = Color.Yellow;
                }
                catch (Exception)
                {
                }
                if (step > 0)
                {
                    try
                    {
                        moves[0][step - 1].BackColor = Color.Transparent;
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        moves[1][step - 1].BackColor = Color.Transparent;
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        moves[2][step - 1].BackColor = Color.Transparent;
                        moves[3][step - 1].BackColor = Color.Yellow;
                        moves[3][step - 1].ForeColor = Color.Black;
                        if (step > 1)
                            moves[3][step - 2].BackColor = Color.Transparent;
                    }
                    catch (Exception)
                    {
                    }
                }
                try
                {
                    if ((anchor == "-" && Convert.ToInt16(moves[0][step].Text) - Convert.ToInt16(moves[3][step - 1].Enabled) - Convert.ToInt16(moves[1][step].Text) < 0) || (anchor == "+" && Convert.ToInt16(moves[0][step].Text) + Convert.ToInt16(moves[3][step - 1].Enabled) + Convert.ToInt16(moves[1][step].Text) >= 10))
                    {
                        moves[3][step].Visible = true;
                        moves[3][step].BackColor = Color.Transparent;
                        moves[3][step].ForeColor = Color.Gray;

                        if (step >= 0)
                            moves[3][step - 1].BackColor = Color.Transparent;
                    }
                }
                catch (Exception)
                {
                }
                #endregion
            }
        }

        private void toodit_MouseUp(object sender, MouseEventArgs e)
        {
            toodit.BackgroundImage = Properties.Resources.тудыть_вкл;
        }

        private void untoodit_MouseDown(object sender, MouseEventArgs e)
        {
            if (anchor == "+" || anchor == "-")
            {
                #region plussing
            //step--;
            if (step > 0)
            {
                step--;
                untoodit.BackgroundImage = Properties.Resources.оттудыть;
            }
            try
            {
                moves[0][step].BackColor = Color.Yellow;
            }
            catch (Exception)
            {
            }
            try
            {
                moves[1][step].BackColor = Color.Yellow;
            }
            catch (Exception)
            {
            }
            if (step > 0)
            {
                try
                {
                    moves[0][step + 1].BackColor = Color.Transparent;
                }
                catch (Exception)
                {
                }
                try
                {
                    moves[1][step + 1].BackColor = Color.Transparent;
                }
                catch (Exception)
                {
                }
            }
            if ((anchor == "-" && Convert.ToInt16(moves[0][step].Text) - Convert.ToInt16(moves[1][step].Text) < 0) || (anchor == "+" && Convert.ToInt16(moves[0][step].Text) + Convert.ToInt16(moves[1][step].Text) >= 10))
            {
                moves[3][step].Visible = true;
                if (step > 0)
                    moves[3][step + 1].BackColor = Color.Transparent;
            }
            #endregion
            }
        }

        private void untoodit_MouseUp(object sender, MouseEventArgs e)
        {
            untoodit.BackgroundImage = Properties.Resources.оттудыть_вкл;
        }

        private void textPan_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (button31.Visible)
            {
                panel2.Location = new Point(panel2.Location.X, button79.Location.Y - 3);
                panel2.Height = 16;
            }
            else
            {
                panel2.Location = new Point(panel2.Location.X, 131);
                panel2.Height = 365;
            }
            //button11.Visible = !button11.Visible;
            button31.Visible = !button31.Visible;
        }
        #endregion
        #region Notes
        List<Panel> Lists = new List<Panel>();
        private void AddList(Point Location)
        {
            Panel p = new Panel();
            p.Location = Location;
            p.Size = new Size(Convert.ToInt16((Convert.ToDouble(comboBox1.Text) / (0.026458333333339 / Count_Scale))), Convert.ToInt16((Convert.ToDouble(comboBox2.Text) / (0.026458333333339 / Count_Scale))));
            p.BackColor = Color.White;
            PictureBox pp = new PictureBox();
            pp.Parent = p;
            pp.Size = p.Size;
            pp.BackgroundImage = Properties.Resources.листок_2;
            pp.BackgroundImageLayout = ImageLayout.Stretch;
            //pp.Visible = false;
            pp.BackColor = Color.Transparent;
            Lists.Add(p);
            NotePanel.Controls.Add(p);
            MakeBackGround(FakeSender, FakE);
        }
        private void ChangeLists(object sender, EventArgs e)
        {
            foreach (Panel p in Lists)
            {
                p.Size = new Size(Convert.ToInt16((Convert.ToDouble(comboBox1.Text) / (0.026458333333339 / Count_Scale))), Convert.ToInt16((Convert.ToDouble(comboBox2.Text) / (0.026458333333339 / Count_Scale))));
                p.Controls[0].Size = p.Size;
            }
        }
        private void MakeBackGround(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Convert.ToInt16((Convert.ToDouble(comboBox3.Text) / (0.026458333333339 / Count_Scale))), Convert.ToInt16((Convert.ToDouble(comboBox4.Text) / (0.026458333333339 / Count_Scale))));
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawLine(new Pen(new SolidBrush(Color.FromArgb(126, 0, 34, 254)), 1), bmp.Width / 2, 0, bmp.Width / 2, bmp.Height - 1);
            gr.DrawLine(new Pen(new SolidBrush(Color.FromArgb(126, 0, 34, 254)), 1), 0, bmp.Height / 2, bmp.Width - 1, bmp.Height / 2);
            foreach (Panel p in Lists)
                p.BackgroundImage = bmp;
            gr.Dispose();
        }
        private void button_Notes_Click(object sender, EventArgs e)
        {
            foreach (Control p in panel4.Controls)
                if (sender.Equals(p))
                {
                    var selectionIndex = textBox4.SelectionStart;
                    textBox4.Text = textBox4.Text.Insert(selectionIndex, p.Text);
                    textBox4.SelectionStart = selectionIndex + p.Text.Length;
                }
        }
        private void button81_Click(object sender, EventArgs e)
        {
            if (panel4.Location.Y == 131)
            {
                panel4.Location = new Point(panel4.Location.X, button81.Location.Y - 3);
                panel4.Height = 16;
                button48.Location = new Point(button48.Location.X + 7, button48.Location.Y - 1);
            }
            else
            {
                panel4.Location = new Point(panel4.Location.X, 131);
                panel4.Height = 365;
                button48.Location = new Point(button48.Location.X - 7, button48.Location.Y + 1);
            }
        }

        private void tabCon_Selected(object sender, TabControlEventArgs e)
        {
            ServerMachine.ActivePage = tabCon.SelectedTab;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (btf.Captured)
            {
                btf.Location = new Point(btf.Location.X + (this.Location.X - beforeLoc.X), btf.Location.Y + (this.Location.Y - beforeLoc.Y));
                //btf.BringToFront();
                this.BringToFront();
            }
            beforeLoc = this.Location;
        }
        private double Count_Scale
        {
            get
            {
                if (trackBar1.Value >= 0)
                    return trackBar1.Value + 1;
                else
                    return 1.0 / (-trackBar1.Value + 1);
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ChangeLists(sender, e);
            MakeBackGround(sender, e);
            ProLabel.Text = "МАСШТАБ: " + Convert.ToInt16(Count_Scale * 100) +"%";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
        #endregion
}
