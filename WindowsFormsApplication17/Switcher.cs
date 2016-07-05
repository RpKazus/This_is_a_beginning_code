using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    class Switcher : PictureBox
    {
        int con;
        public bool Enable = true;
        public int ChangeTime = 17;
        Point switcher;
        SolidBrush brush = new SolidBrush(Color.DarkGray);
        SolidBrush brush_white = new SolidBrush(Color.Gold);
        Color GrayColor = Color.FromArgb(140, 140, 140);
        Color GoldColor = Color.FromArgb(255, 128, 0);
        public Label LinkLabel;
        public Timer timer = new Timer();
        double xloc;
        double[] GrayMass;
        double[] GoldMass;
        Color StColor;
        Color NdColor;
        public Switcher()
        {
            this.Paint += Switcher_Paint;
            this.Click += Switcher_Click;
            this.SizeChanged += Switcher_SizeChanged;
            this.Size = new Size(75, 26);
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            switcher = new Point(this.Size.Height / 2, this.Size.Height / 2);
            Set(false);
        }

        void Switcher_SizeChanged(object sender, EventArgs e)
        {
            con = this.Height / 11;
            switcher = new Point(this.Size.Height / 2 + con, this.Size.Height / 2 + con);
            Drawing(this.CreateGraphics());
        }
        public static bool Compare(double item1, double item2, double result)
        {
            if (item2 > 0)
                return item1 + item2 < result;
            if (item2 < 0)
                return item1 + item2 > result;
            else
                return false;
        }
        int path = 0;
        void timer_Tick(object sender, EventArgs e)
        {
                switcher = (!Enable) ? new Point(Convert.ToInt32((xloc - CountPath(this.Width - this.Height, ChangeTime) > this.Height / 2 + 2) ? xloc -= CountPath(this.Width - this.Height, ChangeTime) : xloc += this.Height / 2 + 2 - xloc), switcher.Y) : new Point(Convert.ToInt32((xloc + CountPath(this.Width - this.Height, ChangeTime) < this.Width - this.Height / 2) ? xloc += CountPath(this.Width - this.Height, ChangeTime) : xloc += this.Width - this.Height / 2 - xloc), switcher.Y);
                    GrayColor = Color.FromArgb(Compare(GrayMass[0], CountPath(NdColor.R - StColor.R, ChangeTime), NdColor.R) ? Convert.ToInt32(GrayMass[0] += CountPath(NdColor.R - StColor.R, ChangeTime)) : Convert.ToInt32(GrayMass[0] += NdColor.R - GrayMass[0]),
                        Compare(GrayMass[1], CountPath(NdColor.G - StColor.G, ChangeTime), NdColor.G) ? Convert.ToInt32(GrayMass[1] -= CountPath(StColor.G - NdColor.G, ChangeTime)) : Convert.ToInt32(GrayMass[1] += NdColor.G - GrayMass[1]),
                        Compare(GrayMass[2], CountPath(NdColor.B - StColor.B, ChangeTime), NdColor.B) ? Convert.ToInt32(GrayMass[2] -= CountPath(StColor.B - NdColor.B, ChangeTime)) : Convert.ToInt32(GrayMass[2] += NdColor.B - GrayMass[2]));
                    GoldColor = Color.FromArgb(Compare(GoldMass[0],CountPath(StColor.R - NdColor.R, ChangeTime),StColor.R) ? Convert.ToInt32(GoldMass[0] += CountPath(StColor.R - NdColor.R, ChangeTime)) : Convert.ToInt32(GoldMass[0] += StColor.R - GoldMass[0]),
                        Compare(GoldMass[1], CountPath(StColor.G - NdColor.G, ChangeTime), StColor.G) ? Convert.ToInt32(GoldMass[1] -= CountPath(NdColor.G - StColor.G, ChangeTime)) : Convert.ToInt32(GoldMass[1] += StColor.G - GoldMass[1]),
                        Compare(GoldMass[2], CountPath(StColor.B - NdColor.B, ChangeTime), StColor.B) ? Convert.ToInt32(GoldMass[2] -= CountPath(NdColor.B - StColor.B, ChangeTime)) : Convert.ToInt32(GoldMass[2] += StColor.B - GoldMass[2]));
            this.Invalidate();
            if (path < ChangeTime)
                path++;
            else
            {
                timer.Enabled = false;
                path = 0;
                Color SaveColor = StColor;
                StColor = NdColor;
                NdColor = SaveColor;
            }
        }
        public static double CountPath(double path, double time)
        {
            return path / time;
        }
        void Switcher_Click(object sender, EventArgs e)
        {
            Enable = !Enable;
            timer.Enabled = true;
            if(LinkLabel != null && Enable)
                LinkLabel.Text = LinkLabel.Text.Replace(": Выкл", ": Вкл");
            else if(LinkLabel != null)
                LinkLabel.Text = LinkLabel.Text.Replace(": Вкл", ": Выкл");
        }
        public void Set(bool b)
        {
            if(b)
            {
                Enable = true;
                if (LinkLabel != null)
                    LinkLabel.Text = LinkLabel.Text.Replace(": Выкл", ": Вкл");
                switcher = new Point(this.Width - this.Height / 2, switcher.Y);
                GoldColor = Color.FromArgb(140, 140, 140);
                GrayColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                Enable = false;
                if (LinkLabel != null)
                    LinkLabel.Text = LinkLabel.Text.Replace(": Вкл", ": Выкл");
                switcher = new Point(this.Height / 2, switcher.Y);
                GoldColor = Color.FromArgb(255, 128, 0);
                GrayColor = Color.FromArgb(140, 140, 140);
            }
            StColor = GrayColor;
            NdColor = GoldColor;
            GrayMass = new double[3] { StColor.R, StColor.G, StColor.B };
            GoldMass = new double[3] { NdColor.R, NdColor.G, NdColor.B };
            xloc = switcher.X;
        }
        void Switcher_Paint(object sender, PaintEventArgs e)
        {
            Drawing(e.Graphics);
        }
        public void Drawing(Graphics gr)
        {
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gr.FillEllipse(new SolidBrush(GrayColor), new Rectangle(con, con, this.Size.Height - con * 2, this.Size.Height - con * 2));
            gr.FillEllipse(new SolidBrush(GrayColor), new Rectangle(this.Width - this.Height + con, con, this.Size.Height - con * 2, this.Size.Height - con * 2));
            gr.DrawEllipse(new Pen(new SolidBrush(Color.Black), con), new Rectangle(con, con, this.Size.Height - con * 2, this.Size.Height - con * 2));
            gr.DrawEllipse(new Pen(new SolidBrush(Color.Black), con), new Rectangle(this.Width - this.Height + con, con, this.Size.Height - con * 2, this.Size.Height - con * 2));
            gr.FillRectangle(new SolidBrush(GrayColor), new Rectangle(this.Height / 2 + con, con, this.Width - this.Height - con * 2, this.Size.Height - con * 2));
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), con), this.Height / 2, con, this.Width - this.Height/2, con);
            gr.DrawLine(new Pen(new SolidBrush(Color.Black), con), this.Height / 2, this.Height - con, this.Width - this.Height / 2, this.Height - con);
            gr.FillEllipse(new SolidBrush(GoldColor), new Rectangle(switcher.X - this.Height / 2 + con, switcher.Y - this.Height / 2 + con, this.Size.Height - 8, this.Size.Height - 8));
        }
    }
}
