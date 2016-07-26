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
    public partial class ButtonForm : Form
    {
        public bool Captured = false;
        public ButtonForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.FormClosing += this.ButtonForm_FormClosing; 
        }
        public void SomeButton_Click(object sender, EventArgs e)
        {
            ServerMachine.pressed = ((Control)sender).Text;
        }

        private void ButtonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            ServerMachine.button_button.Image = Properties.Resources.button1;
        }

        private void ButtonForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonForm_Move(object sender, EventArgs e)
        {
            if (this.Location.X >= this.Owner.Location.X - 15 && this.Location.X <= this.Owner.Location.X + 25)
            {
                this.Location = new Point(this.Owner.Location.X + 11, this.Location.Y);
                Captured = true;
            }
            if (this.Location.Y >= this.Owner.Location.Y - 5 && this.Location.Y <= this.Owner.Location.Y + 39)
            {
                this.Location = new Point(this.Location.X, this.Owner.Location.Y + 35);
                Captured = true;
            }
            if (this.Location.X + this.Width >= this.Owner.Location.X - 25 + this.Owner.Width && this.Location.X + this.Width <= this.Owner.Location.X + this.Owner.Width + 15)
            {
                this.Location = new Point( this.Owner.Location.X + this.Owner.Width - this.Width - 11, this.Location.Y);
                Captured = true;
            }
            if (this.Location.Y + this.Height >= this.Owner.Location.Y - 25 + this.Owner.Height && this.Location.Y + this.Height <= this.Owner.Location.Y + this.Owner.Height + 15)
            {
                this.Location = new Point(this.Location.X, this.Owner.Location.Y + this.Owner.Height - this.Height - 11);
                Captured = true;
            }
        }
    }
}
