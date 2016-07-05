using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    class Journal : Panel
    {
        public List<Resume> journal = new List<Resume>();
        public RichTextBox textBox;
        public MethodInvoker method;
        public ContextMenuStrip cont;
        public void AddResume(string Link)
        {
            Resume i = new Resume("Запись " + (this.Controls.Count + 1).ToString(), Link, Parent, new Size(128, 60));
            i.Location = new Point(10, this.Controls.Count * i.Height + 5);
            i.deleteButton.Click += deleteButton_Click;
            i.NameLabel.MouseClick += NameLabel_MouseClick;
            i.ContextMenuStrip = cont;
            i.Parent = this;
            journal.Add(i);
        }
        void deleteButton_Click(object sender, EventArgs e)
        {
            journal.Reverse();
            bool b = false;
            for (int i = 0; i < this.journal.Count; i++)
                if (!b)
                    if (sender.Equals(journal[i].deleteButton))
                    {
                        journal[i].Dispose();
                        journal.Remove(journal[i]);
                        b = true;
                    }
                    else
                        journal[i].Location = new Point(journal[i].Location.X, journal[i].Location.Y - journal[i].Height);
            journal.Reverse();
        }
        void NameLabel_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < journal.Count; i++)
                if (sender.Equals(journal[i].NameLabel))
                {
                    textBox.Text = journal[i].Link;
                    method();
                }
        }
    }
}
