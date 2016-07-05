using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    class ToolBox : Panel
    {
        private Button button28;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
    
        public ToolBox()
        {
            this.Paint += ToolBox_Paint;
        }

        void ToolBox_Paint(object sender, PaintEventArgs e)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button28 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.SuspendLayout();
            // 
            // this
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            //this.Location = new System.Drawing.Point(-31, 131);
            this.Name = "panel2";
            this.Size = new System.Drawing.Size(387, 365);
            this.TabIndex = 16;
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.Location = new System.Drawing.Point(55, 87);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(60, 60);
            this.button28.TabIndex = 21;
            this.button28.Tag = "Controls";
            this.button28.Text = "(";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(253, 286);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 60);
            this.button13.TabIndex = 20;
            this.button13.Tag = "Controls";
            this.button13.Text = ",";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(253, 220);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(129, 60);
            this.button14.TabIndex = 19;
            this.button14.Tag = "Controls";
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(253, 154);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(129, 60);
            this.button15.TabIndex = 18;
            this.button15.Tag = "Controls";
            this.button15.Text = ":";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(253, 88);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(129, 60);
            this.button16.TabIndex = 17;
            this.button16.Tag = "Controls";
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(253, 22);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(129, 60);
            this.button17.TabIndex = 16;
            this.button17.Tag = "Controls";
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Yellow;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button18.FlatAppearance.BorderSize = 2;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(51, 18);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(129, 60);
            this.button18.TabIndex = 15;
            this.button18.Tag = "Controls";
            this.button18.Text = "=>";
            this.button18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(54, 220);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 60);
            this.button19.TabIndex = 9;
            this.button19.Tag = "Controls";
            this.button19.Text = "4";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(186, 286);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(60, 60);
            this.button20.TabIndex = 14;
            this.button20.Tag = "Controls";
            this.button20.Text = "9";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(54, 154);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 60);
            this.button21.TabIndex = 6;
            this.button21.Tag = "Controls";
            this.button21.Text = "1";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(120, 286);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(60, 60);
            this.button22.TabIndex = 13;
            this.button22.Tag = "Controls";
            this.button22.Text = "8";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(120, 154);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(60, 60);
            this.button23.TabIndex = 7;
            this.button23.Tag = "Controls";
            this.button23.Text = "2";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(54, 286);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(60, 60);
            this.button24.TabIndex = 12;
            this.button24.Tag = "Controls";
            this.button24.Text = "7";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button25.Location = new System.Drawing.Point(186, 154);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(60, 60);
            this.button25.TabIndex = 8;
            this.button25.Tag = "Controls";
            this.button25.Text = "3";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.Location = new System.Drawing.Point(186, 220);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(60, 60);
            this.button26.TabIndex = 11;
            this.button26.Tag = "Controls";
            this.button26.Text = "6";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.Location = new System.Drawing.Point(120, 220);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(60, 60);
            this.button27.TabIndex = 10;
            this.button27.Tag = "Controls";
            this.button27.Text = "5";
            this.button27.UseVisualStyleBackColor = true;
            this.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
