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
    public partial class Wizytowka : Form
    {
        public Wizytowka()
        {
            InitializeComponent();
        }

        public string[] Dane(ListViewItem i)
        {
            string[] s = new string[2];

           this.kontrolka1.Imie =  s[0] = i.SubItems[0].Text;
           this.kontrolka1.Nazwisko =  s[1] = i.SubItems[1].Text;
            return s;
        }
    }
}
