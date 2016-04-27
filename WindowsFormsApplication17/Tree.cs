using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    class Tree
    {
        public string value;
        public Tree leftTree;
        public Tree rightTree;
        public int step;
        public int length
        {
            get
            {
                TextBox test = new TextBox();
                test.Text = value;
                return test.Width;
            }
        }
        public Tree(Tree leftTree, string value, Tree rightTree)
        {
            this.leftTree = leftTree;
            this.value = value;
            this.rightTree = rightTree;
        }
        public Tree()
        {
        }
    }
}
