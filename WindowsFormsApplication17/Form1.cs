using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabCon.Location = new Point(tabCon.Location.X, -22);
            switcher1.LinkLabel = label_proschet;
            foreach (Control i in tabPanel.Controls)
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
            vif.Owner = this;
        }
        public void MethodToMath()
        {

        }
        ViewForm vif = new ViewForm();
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
                    Clist.Add(new Point(Lenght(textBox1.Text.Substring(0, lenght)), 0));
                    //Cursor.Position = new Point(Lenght(textBox1.Text.Substring(0, lenght)) - 50, 0);
                }
                lastchar = ch;
                lenght++;
            }
        }
        private int Lenght(string str)
        {
            PaintEventArgs e = new PaintEventArgs(this.CreateGraphics(), new Rectangle(0, 0, 1000, 1000));
            return (int)e.Graphics.MeasureString(str, textBox1.Font, 1000000).Width;
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
                    Rectangle rect1 = new Rectangle(pp1, new Size(Lenght("+"), textBox1.Height));
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
            while (Lenght(textBox1.Text) >= textBox1.Width)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size - 1, textBox1.Font.Style);
            }
            while (Lenght(textBox1.Text) < textBox1.Width - 30 && textBox1.Text.Length > 10)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size + 1, textBox1.Font.Style);
            }
            //textBox1.Text = textBox1.Text.Replace("/n", "");
        }
        private void button_Calc_Click(object sender, EventArgs e)
        {
            foreach (Control p in panel1.Controls)
                if (sender.Equals(p))
                    textBox1.Text += p.Text;
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
            if (pictureBox4.Tag == "open" && Switcher.Compare(pictureBox4.BackColor.R, Switcher.CountPath(NdColor.R - StColor.R, ChangeTime), NdColor.R))
            {

                pictureBox4.BackColor = Color.FromArgb(Switcher.Compare(GrayMass[0], Switcher.CountPath(NdColor.R - StColor.R, ChangeTime), NdColor.R) ? Convert.ToInt32(GrayMass[0] += Switcher.CountPath(NdColor.R - StColor.R, ChangeTime)) : Convert.ToInt32(GrayMass[0] += NdColor.R - GrayMass[0]),
                        Switcher.Compare(GrayMass[1], Switcher.CountPath(NdColor.G - StColor.G, ChangeTime), NdColor.G) ? Convert.ToInt32(GrayMass[1] -= Switcher.CountPath(StColor.G - NdColor.G, ChangeTime)) : Convert.ToInt32(GrayMass[1] += NdColor.G - GrayMass[1]),
                        Switcher.Compare(GrayMass[2], Switcher.CountPath(NdColor.B - StColor.B, ChangeTime), NdColor.B) ? Convert.ToInt32(GrayMass[2] -= Switcher.CountPath(StColor.B - NdColor.B, ChangeTime)) : Convert.ToInt32(GrayMass[2] += NdColor.B - GrayMass[2]));
                pictureBox4.BackColor = Color.FromArgb(pictureBox4.BackColor.R, pictureBox4.BackColor.G, pictureBox4.BackColor.B);
            }
            if(!panel3.Enabled && panel3.Location.Y <= this.Height - 20)
            {
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + 1);
                //button41.Location = new Point(button41.Location.X, button41.Location.Y + 1);
                if(textPan.Height < this.Height - 150)
                textPan.Height++;
            }
            else if (panel3.Enabled && panel3.Location.Y > 131)
            {
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y - 1);
                //button41.Location = new Point(button41.Location.X, button41.Location.Y + 1);
                if (textPan.Height >= 65)
                textPan.Height--;
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
        #endregion
        #region Deductions
        string DataValue;
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

        private void button25_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text += ",";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text += "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text += "+";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox2.Text += "y";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox2.Text += "x";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
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
        List<Label> picList = new List<Label>();
        private void buttonMath_Click(object sender, EventArgs e)
        {
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
        private void button49_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            for(int i = 0; i < text1.Text.Length; i++)
            {
                
            }
        }
        private void ButtonMath_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            Label name = new Label();
            //name.Text = dt.Compute();
            name.Location = new Point(10, 100);
            textPan.Controls.Add(name);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            switch(button61.Text)
            {
                case "+":
                    button61.Text = "-";
                    break;
                case "-":
                    button61.Text = "*";
                    break;
                case "*":
                    button61.Text = "/";
                    break;
                case "/":
                    button61.Text = "+";
                    break;
            }
        }

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
    }
        #endregion
}
