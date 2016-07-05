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
    public partial class ViewForm : Form
    {
        Graphics gr;
        //Bitmap bmp = new Bitmap(100000, 100000);
        public ViewForm()
        {
            InitializeComponent();
            gr = pictureBox1.CreateGraphics();
            Setch(15, 15, pictureBox1.CreateGraphics());
        }
        private void ViewForm_Load(object sender, EventArgs e)
        {
            foreach (TreeNode tr in pictureBox1.Nodes)
                tr.ForeColor = Color.DarkGray;
            TreeNode treen = new TreeNode();
            treen.Text = ServerMachine.primer;
            pictureBox1.Nodes.Add(treen);
        }
        public void Setch(int xsize, int ysize, Graphics egr)
        {
            int x = -2;
            int y = -2;
            Pen pp = new Pen(new SolidBrush(Color.FromArgb(27, 0, 36, 254)), 1);
            for (int i = 0; i < pictureBox1.Height / xsize; i++)
            {
                egr.DrawLine(pp, new Point(x + xsize, -1), new Point(x += xsize, pictureBox1.Height));
                egr.DrawLine(pp, new Point(-1, y + ysize), new Point(pictureBox1.Width, y += ysize));
            }
        }
        private void Uravn(Control ctrl, Graphics e, Font fnt)
        {
            if (ctrl.Width <= e.MeasureString(ServerMachine.primer, fnt, 1000000).Width)
                ctrl.Width = (int)e.MeasureString(ServerMachine.primer, fnt, 1000000).Width + 20;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculator.Sort();
            foreach (string stora in Calculator.MakePrimer(ServerMachine.type))
            {
                TreeNode treen = new TreeNode();
                treen.ContextMenuStrip = contextMenuStrip1;
                treen.Text = stora;
                treen.NodeFont = new Font(pictureBox1.Font.Name, 15);
                treen.BackColor = Color.Transparent;
                pictureBox1.Nodes[pictureBox1.Nodes.Count - 1].Nodes.Add(treen);
            }
            Calculator.timeList.Clear();
            Calculator.move = 1;
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Setch(15, 15, pictureBox1.CreateGraphics());
        }

        private void послатьВМатематическийВводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerMachine.MethodToMath();
        }
    }
}
