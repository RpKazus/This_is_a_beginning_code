using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using WindowsFormsApplication17;

namespace WindowsFormsApplication17
{
    class AdvancedButton : Panel
    {
        Dictionary<char, char> opposits = new Dictionary<char, char>();
        public Image image = WindowsFormsApplication17.Properties.Resources.button;
        public Image image_lighted = WindowsFormsApplication17.Properties.Resources.button_light;
        public Label NameBox = new Label();
        public bool vertical;
        public TabControl tabControl;
        public Point beginPoint;
        public bool dir = true;
        public int speed = 2;
        public Timer timer = new Timer();
        public AdvancedButton()
        {
            opposits.Add('w', 's');
            opposits.Add('s', 'w');
            NameBox.Parent = this;
            NameBox.Location = new Point(10, 10);
            NameBox.Size = new Size(200, 200);
            timer.Tick += timer_Tick;
            this.BackgroundImage = image;
            this.Size = image.Size;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            NameBox.BackColor = Color.Transparent;
            this.MouseEnter += AdvancedButton_MouseEnter;
            this.MouseLeave += AdvancedButton_MouseLeave;
            timer.Interval = 1;
            NameBox.Font = new Font(NameBox.Font.FontFamily, 11, NameBox.Font.Style);
            NameBox.ForeColor = Color.Black;
            NameBox.MouseEnter += AdvancedButton_MouseEnter;
            NameBox.MouseLeave += AdvancedButton_MouseLeave;
            this.MouseClick += AdvancedButton_MouseClick;
            NameBox.MouseClick += AdvancedButton_MouseClick;
        }
        void AdvancedButton_MouseClick(object sender, MouseEventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[this.TabIndex];
        }

        void AdvancedButton_MouseLeave(object sender, EventArgs e)
        {
            dir = false;
            timer.Enabled = true;
            this.BackgroundImage = image;
        }

        void AdvancedButton_MouseEnter(object sender, EventArgs e)
        {
            dir = true;
            timer.Enabled = true;
            this.BackgroundImage = image_lighted;
        }
        public AdvancedButton(Image background, Image background_lighted, bool vertical)
        {
            image = background;
            image_lighted = background_lighted;
            NameBox.Parent = this;
            NameBox.Location = new Point(10, 10);
            this.vertical = vertical;
            timer.Tick += timer_Tick;
            this.BackgroundImage = image;
            this.Size = image.Size;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            NameBox.BackColor = Color.Transparent;
            timer.Interval = 1;
            this.MouseEnter += AdvancedButton_MouseEnter;
            this.MouseLeave += AdvancedButton_MouseLeave;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (dir)
                if (this.Location.Y > beginPoint.Y - 6)
                            this.Location = new Point(this.Location.X, this.Location.Y - speed);
                else
                    timer.Enabled = false;
            else
                if (this.Location.Y < beginPoint.Y)
                        this.Location = new Point(this.Location.X, this.Location.Y + speed);
                else
                    timer.Enabled = false;
        }
    }
}
