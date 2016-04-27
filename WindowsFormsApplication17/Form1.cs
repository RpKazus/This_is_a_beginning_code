using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control i in tabPanel.Controls)
            {
                i.Controls[0].Text = i.Tag.ToString();
                AdvancedButton o = (AdvancedButton)i;
                o.tabControl = tabControl1;
                o.beginPoint = o.Location;
            }
            tabControl1.SelectedIndex = 1;
            PolishBox.SelectedIndex = 4;
        }
        #region Calculator
        Resume check;
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
            foreach(char ch in textBox1.Text)
            {
                if ((ch == '*' || ch == '/' || ch == '-' || ch == '+') && (lastchar != '*' && lastchar != '/' && lastchar != '-' && lastchar != '+'))
                {
                        ExtraClist.Add(lenght);
                        Clist.Add(new Point(Lenght(textBox1.Text.Substring(0, lenght)) + 5, 0));
                }
                lastchar = ch;
                lenght++;
            }
        }
        private int Lenght(string str)
        {
            Label test = new Label();
            test.Text = str;
            test.Font = textBox1.Font;
            return test.PreferredWidth;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataString = textBox1.Text;
            AddResume(textBox1.Text, Journal1);
            try
            {
                dt.Compute(textBox1.Text, string.Empty);
                if(ShowAnswers.Checked)
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
        }
        public void AddResume(string Link, Control Parent)
        {
            Resume i = new Resume("Запись " + (Journal.Count + 1).ToString(), Link, Parent, new Size(128, 60));
            i.Location = new Point(10, Journal.Count * i.Height + 5);
            i.deleteButton.Click += deleteButton_Click;
            i.NameLabel.MouseClick += NameLabel_MouseClick;
            i.ContextMenuStrip = contextMenuStrip1;
            Journal.Add(i);
        }

        void NameLabel_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Journal.Count; i++)
                if (sender.Equals(Journal[i].NameLabel))
                {
                    textBox1.Text = Journal[i].Link;
                    ending();
                }
        }

        void deleteButton_Click(object sender, EventArgs e)
        {
            Journal.Reverse();
            bool b = false;
            for (int i = 0; i < Journal.Count; i++)
                if (!b)
                    if (sender.Equals(Journal[i].deleteButton))
                    {
                        Journal[i].Dispose();
                        Journal.Remove(Journal[i]);
                        b = true;
                    }
                else
                    Journal[i].Location = new Point(Journal[i].Location.X, Journal[i].Location.Y - Journal[i].Height);
            Journal.Reverse();
        }
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isWorked)
            { 
                int step = 0;
                foreach (Point pp in Clist)
                {
                    Point pp1 = pp;
                    pp1.Offset(textBox1.Location);
                    pp1.Offset(tabControl1.Location);
                    pp1.Offset(new Point(this.Location.X - 7, this.Location.Y + 62));
                    Rectangle rect1 = new Rectangle(pp1, new Size(Lenght("+"), textBox1.PreferredHeight));
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
                        label1.Location = new Point(rect1.Location.X - this.Location.X - 14 - tabControl1.Location.X, rect1.Location.Y - this.Location.Y - label1.PreferredHeight - 62 - tabControl1.Location.Y);
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void Parce_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void Mnoj_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void ExceptionTimer_Tick(object sender, EventArgs e)
        {
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
        }
        public void ending()
        {
            isWorked = false;
            foreach (Control c in panel1.Controls)
                if(c != button10)
                    c.Enabled = true;
            button11.Enabled = false;
            Clist.Clear();
            ExtraClist.Clear();
            textBox1.ReadOnly = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '=')
                    textBox1.Text = textBox1.Text.Substring(i + 1, textBox1.Text.Length - 1 - i);
            }
            ending();
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

        private void добавитьКToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ending();
            textBox1.Text = "";
            textBox1.Font = new Font(textBox1.Font.FontFamily, 34, textBox1.Font.Style);
        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += dt.Compute(check.Link, string.Empty);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
        #endregion
        #region Deductions
        string DataValue;
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
            //try
            {
                textBox2.Text = Calculator.Compute(textBox2.Text, 'x', (double)dt.Compute(PolishBox.SelectedItem.ToString(), string.Empty)).ToString();
            }
            /*catch (Exception)
            {
                textBox2.BackColor = Color.Red;
            }*/
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
    }
        #endregion
}
