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

        int Dlugosc = 0;

        
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

            Dlugosc = TextRenderer.MeasureText(imna, font).Width-(int)((this.Font.Size*3)/4);
            StrEnd = StrStart + Dlugosc;
            if (this.Width < StrEnd + 32)
            {
                string temp = string.Empty;
                int ile = 0;
                int szer = 0;
                //bool koniec = false;

                int start = 0;
                //int srodek = 0;
                int end = imna.Length;
                temp = string.Copy(imna);
                ile = Fit(start, end, temp);

                /* while (!koniec)
                 {
                     int tmp = 0;
                     temp = string.Copy(imna);
                     temp = temp.Substring(start, end-start);
                     tmp = TextRenderer.MeasureText(temp, font).Width -(int)(this.Font.Size*3)/4;

                     srodek = (end - start) / 2;

                     if ((szer + tmp+StrStart) < (this.Width-32))
                     {
                         szer += tmp;
                         if (end != imna.Length)
                         {
                             start = end;
                             end = start + srodek;
                         }
                         else
                         {
                             start = srodek + 1;
                         }
                     }
                     else
                     {
                         end = srodek + start;
                     }

                     if(start==end)
                     {
                         koniec = true;
                     }
                 }*/
                 //ile = end;
                temp = imna;

                if (ile > 2)
                {
                    if(ile<imna.Length)
                    {
                        temp = temp.Remove(ile, temp.Length - ile);
                        temp = temp + "...";
                    }
                        
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

        public int Fit(int start,int stop,string str)
        {
            if (start == stop) return start-1;
            if ((TextRenderer.MeasureText(str.Substring(0, (stop+start)/2), this.Font).Width - (int)(this.Font.Size * 3) / 4) < this.Width - 64 - StrStart)
                return Fit((start + (stop - start) / 2)+1, stop, str);
            else return Fit(start, start+ (stop - start) / 2, str);
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
