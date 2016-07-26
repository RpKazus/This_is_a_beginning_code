using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    class Resume : Panel
    {
        public string Link;
        public Label NameLabel = new Label();
        public Button deleteButton = new Button();
        public Rectangle rect;
        //public Dictionary<Control, string> textDictionary;
        public Resume(string Name, string Link, Control parent, Size size)
        {
            NameLabel.Text = Name;
            NameLabel.Location = new Point(10, 4);
            NameLabel.Parent = this;
            this.Size = size;
            deleteButton.Text = "✖";
            deleteButton.Size = new Size(30, 30);
            deleteButton.Location = new Point(9, 27);
            this.Parent = parent;
            deleteButton.Parent = this;
            this.Link = Link;
            NameLabel.ForeColor = Color.Black;
            NameLabel.BorderStyle = BorderStyle.FixedSingle;
            NameLabel.BackColor = Color.Silver;
            NameLabel.Font = new Font(NameLabel.Font.FontFamily, 10, NameLabel.Font.Style);
            this.BackColor = Color.WhiteSmoke;
            this.BorderStyle = BorderStyle.FixedSingle;
            rect = new Rectangle(this.Location, this.Size);
            NameLabel.MouseEnter += NameLabel_MouseEnter;
            NameLabel.MouseLeave += NameLabel_MouseLeave;
            this.MouseEnter += Resume_MouseEnter;
            this.MouseLeave += Resume_MouseLeave;
        }

        void Resume_MouseLeave(object sender, EventArgs e)
        {
                this.Tag = "";
        }

        void Resume_MouseEnter(object sender, EventArgs e)
        {
            this.Tag = "Checked";
        }

        void NameLabel_MouseLeave(object sender, EventArgs e)
        {
            NameLabel.ForeColor = Color.Black;
        }

        void NameLabel_MouseEnter(object sender, EventArgs e)
        {
            NameLabel.ForeColor = Color.Gold;
        }
        
    }
}
