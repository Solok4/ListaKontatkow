using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolka
{
    public partial class Kontrolka : UserControl
    {
        int StrStart = 120;
        int StrEnd = 500;

        int dlugosc = 0;

        
        public Kontrolka()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Brush czarnyBrush = new SolidBrush(Color.Black);
            Pen kwkolorPen = new Pen(this.KWKolor);
            Brush kwkolorBrush = new SolidBrush(this.KWKolor);

            Pen kokolorPen = new Pen(this.KOKolor);
            Brush kokolorBrush = new SolidBrush(this.KOKolor);

            Font font = this.Font;

            Graphics g;
            g = e.Graphics;

            string imna = Imie + "  " + Nazwisko;
            dlugosc = TextRenderer.MeasureText(imna, font).Width;
            StrEnd = StrStart + dlugosc;
            if (this.Width < StrEnd + 32)
            {
                    string temp = string.Empty;
                    int ile = 0;
                    ile = ((this.Width-60) - StrStart) / ((dlugosc) / imna.Length);
                    temp = imna;
                    if (ile > 2)
                    {
                        temp = temp.Remove(ile, temp.Length - ile);
                        temp = temp + "...";
                    }
                    else
                    {
                        temp = temp.Remove(2, temp.Length - 2);
                        temp = temp + "...";
                    }
                    TextRenderer.DrawText(e.Graphics, temp, font, new Point(StrStart, 20), Color.Black);
            }
            else
            {
                TextRenderer.DrawText(e.Graphics, imna, font, new Point(StrStart, 20), Color.Black);
            }

            Rectangle rect = new Rectangle(110, 140, 10, 10);
            g.DrawRectangle(kwkolorPen, rect);
            g.FillRectangle(kwkolorBrush, rect);

            rect = new Rectangle(170, 140, 10, 10);
            g.DrawRectangle(kwkolorPen, rect);
            g.FillRectangle(kwkolorBrush, rect);

            rect = new Rectangle(130, 140, 10, 10);
            g.DrawEllipse(kokolorPen, rect);
            g.FillEllipse(kokolorBrush, rect);

            rect = new Rectangle(150, 140, 10, 10);
            g.DrawEllipse(kokolorPen, rect);
            g.FillEllipse(kokolorBrush, rect);

            if (this.MyZdjecie != null)
            {
                Image myImage = new Bitmap(this.Zdjecie);
                rect = new Rectangle(10, 10, 100, 100);
                g.DrawImage(myImage, rect);
            }
        }
        string MyImie;
        [Browsable(true), Category("Dane")]
        public string Imie
        {
            get
            {
                return MyImie; 
            }
            set
            {
                MyImie = value;
                this.Refresh();
            }
        }
        string MyNazwisko;
        [Category("Dane")]
        public string Nazwisko
        {
            get
            {
                return MyNazwisko;
            }
            set
            {
                MyNazwisko = value;
                this.Refresh();
            }
        }
        
        Color MYKwkolor;
        [Category("Dane")]
        public Color KWKolor
        {
            get
            {
                return MYKwkolor;
            }
            set
            {
                MYKwkolor = value;
                this.Refresh();
            }
        }
        Color MyKokolor;
        [Category("Dane")]
        public Color KOKolor
        {
            get
            {
                return MyKokolor;
            }
            set
            {
                MyKokolor = value;
                this.Refresh();
            }
        }
        Image MyZdjecie;
        [Category("Dane")]
        public Image Zdjecie
        {
            get
            {
                return MyZdjecie; 
            }
            set
            {
                MyZdjecie = value;
                this.Refresh();
            }
        }

        private void Kontrolka_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
