using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class EditForm : Form
    {

        bool edycja = false;
        int miejsce = 0;
        private Form1 f = null;
        public EditForm()
        {
            InitializeComponent();
            
        }

        public EditForm(Form call)
        {
            InitializeComponent();
            f = call as Form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = new string[] {textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text, textBox5.Text };
            if (edycja)
            {
                f.WstawDoListy(str, this.miejsce);
            }
            else
            {
                f.DodajDoListyV2(str);
            }
            edycja = false;
            this.Close();

        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string [] Edycja(ListViewItem i,int n)
        {
            string[] s=new string[5];
            for (int x = 0; x < 5; x++)
            {
                s[x] = i.SubItems[x].Text;
            }
            this.textBox1.Text = s[0];
            this.textBox2.Text = s[1];
            this.textBox3.Text = s[2];
            this.textBox4.Text = s[3];
            this.textBox5.Text = s[4];

            this.miejsce = n;
            this.edycja = true;

                return s;
        }
    }
}
