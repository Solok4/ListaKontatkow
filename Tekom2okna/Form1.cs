using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Aplikacja
{
    public partial class Form1 : Form
    {
        private List<Kontakt> Kontakty = new List<Kontakt>();
        char Sep = ';';
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                Kontakty.Add(new Kontakt
                {
                    Imie = i.ToString(),
                    Nazwisko = Convert.ToString(2 * i),
                    Telefon = Convert.ToString(3 * i),
                    Email = Convert.ToString(4 * i),
                    Wiek = i
                });
            }

            ShowItemsVirtual(Kontakty);
        }

        private void ShowItemsVirtual(List<Kontakt> infos)
        {
            ListaKontaktow.VirtualListSize = infos.Count; // Set number of items in list view
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm(this);
            ef.Show(this);
        }

        private void EdytujButton_Click(object sender, EventArgs e)
        {
            for (int i = ListaKontaktow.Items.Count - 1; i >= 0; i--)
            {
                if (ListaKontaktow.Items[i].Selected)
                {
                    EditForm ef = new EditForm(this);
                    ef.Edycja(ListaKontaktow.Items[i], i);
                    ef.Show(this);
                    break;
                }
            }
        }

        public void WstawDoListy(string[] i,int x)
        {
            if (i[4] == "") i[4] = "0";
            Kontakty.RemoveAt(x);
            Kontakty.Insert(x, new Kontakt { Imie = i[0], Nazwisko = i[1], Telefon = i[2], Email = i[3],Wiek = Convert.ToInt32(i[4]) });
            ListaKontaktow.Refresh();
        }

        public void DodajDoListyV2(string [] s)
        {
            if (s[4] == "") s[4] = "0";
            Kontakty.Add(new Kontakt { Imie = s[0], Nazwisko = s[1], Telefon = s[2], Email = s[3], Wiek = Convert.ToInt32(s[4])});
            ListaKontaktow.VirtualListSize++;
        }

        private void UsunButton_Click(object sender, EventArgs e)
        {

            for (int i = ListaKontaktow.Items.Count - 1; i >= 0; i--)
            {
                if (ListaKontaktow.Items[i].Selected)
                {
                    Kontakty.RemoveAt(i);
                    ListaKontaktow.VirtualListSize--;
                }
            }
        }

        private void ListaKontaktow_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var newSortOrder = myToggle[MySortOrderMap[e.Column]];
            MySortOrderMap[e.Column] = newSortOrder;     // Store sort order for current column
            SortBy(newSortOrder, MyComparers[e.Column]); // Do the actual sorting
        }

        Dictionary<int, SortOrder> MySortOrderMap = new Dictionary<int, SortOrder>
        {
            {0,SortOrder.None},
            {1,SortOrder.None},
            {2,SortOrder.None},
            {3,SortOrder.None}

        };

        Dictionary<int, Comparison<Kontakt>> MyComparers = new Dictionary<int, Comparison<Kontakt>>
        {
            {0,(a,b) => a.Imie.CompareTo(b.Imie)},
            {1,(a,b) => a.Nazwisko.CompareTo(b.Nazwisko)},
            {2,(a,b) => a.Telefon.CompareTo(b.Telefon)},
            {3,(a,b) => a.Email.CompareTo(b.Email)}
        };

        Dictionary<SortOrder, SortOrder> myToggle = new Dictionary<SortOrder, SortOrder>
        {
            {SortOrder.None,SortOrder.Ascending},
            {SortOrder.Ascending,SortOrder.Descending},
            {SortOrder.Descending,SortOrder.Ascending}
        };

        void SortBy(SortOrder order, Comparison<Kontakt> comparer)
        {
            Kontakty.Sort((a, b) =>
            {
                int lret = comparer(a, b); // Do the actual comparison
                if (order == SortOrder.Descending) // reverse when necessary
                {
                    lret *= -1;
                }
                return lret;
            });

            ListaKontaktow.Refresh();
        }

        private void ListaKontaktow_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var acc = Kontakty[e.ItemIndex];
            // hand out new item
            e.Item = new ListViewItem(
                new string[] { acc.Imie,
                    acc.Nazwisko,
                    acc.Telefon,
                    acc.Email,
                    acc.Wiek.ToString()}) 
                    { Tag = acc }; // Set Tag object property to our actual AccountInfo object

            if (TelefonCheck.Checked)
                if (e.Item.SubItems[2].Text == "")
                    e.Item.BackColor = Color.Red;
            if (EmailCheck.Checked)
                if (e.Item.SubItems[3].Text == "")
                    e.Item.BackColor = Color.Green;
            if (EmailCheck.Checked && TelefonCheck.Checked)
                if ((e.Item.SubItems[3].Text == "") && (e.Item.SubItems[2].Text == ""))
                    e.Item.BackColor = Color.Blue;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ListaKontaktow.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ListaKontaktow.Refresh();
        }

        private void ZapiszBtn_Click(object sender, EventArgs e)
        {
            Stream str;
            string line;
            
            ZapiszWnd.Filter = "csv files (.csv)|*.csv| txt files (.txt)|*.txt";
            ZapiszWnd.RestoreDirectory = true;

            if (ZapiszWnd.ShowDialog() == DialogResult.OK)
            {
                if((str = ZapiszWnd.OpenFile()) !=null)
                {
                  using(StreamWriter sw = new StreamWriter(str))
                  {
                      foreach (Kontakt i in Kontakty)
                      {
                          line = i.Imie + Sep;
                          line += i.Nazwisko + Sep;
                          line += i.Email + Sep;
                          line += i.Telefon + Sep;
                          line += i.Wiek;
                          sw.WriteLine(line);
                      }
                    }

                        str.Close();
                }
            }

        }

        private void WczytajBtn_Click(object sender, EventArgs e)
        {
            Stream str;
            string line;
            WczytajWnd.Filter = "csv files (.csv)|*.csv| txt files (.txt)|*.txt";
            WczytajWnd.RestoreDirectory = true;
            WczytajWnd.FilterIndex = 2;

            if (WczytajWnd.ShowDialog() == DialogResult.OK)
            {
                if ((str = WczytajWnd.OpenFile()) != null)
                {
                    Kontakty.Clear();
                    ListaKontaktow.VirtualListSize = 0;
                    string[] buff = new string[5];
                    using(StreamReader sr = new StreamReader(str))
                    {
                        while((line = sr.ReadLine()) !=null)
                        {
                            buff = line.Split(Sep);
                            DodajDoListyV2(buff);
                        }
                        
                    }
                }

            }
        }

        private void ZapisBButton_Click(object sender, EventArgs e)
        {
            Stream str;
            ZapiszWnd.Filter = "csv files (.csv)|*.csv| txt files (.txt)|*.txt";
            ZapiszWnd.RestoreDirectory = true;
            ZapiszWnd.FilterIndex = 2;

            if (ZapiszWnd.ShowDialog() == DialogResult.OK)
            {
                if ((str = ZapiszWnd.OpenFile()) != null)
                {
                    using (BinaryWriter bw = new BinaryWriter(str))
                    {
                        foreach (Kontakt i in Kontakty)
                        {
                            bw.Write(i.Imie);
                            bw.Write(i.Nazwisko);
                            bw.Write(i.Email);
                            bw.Write(i.Telefon);
                            bw.Write(i.Wiek);
                        }
                    }
                }

            }
        }

        private void OdczytBBtn_Click(object sender, EventArgs e)
        {
            Stream str;
            WczytajWnd.Filter = "csv files (.csv)|*.csv| txt files (.txt)|*.txt";
            WczytajWnd.RestoreDirectory = true;
            WczytajWnd.FilterIndex = 2;

            if (WczytajWnd.ShowDialog() == DialogResult.OK)
            {
                if ((str = WczytajWnd.OpenFile()) != null)
                {
                    string []temp = new string [5];
                    Kontakty.Clear();
                    ListaKontaktow.VirtualListSize = 0;
                    string[] buff = new string[5];
                    using (BinaryReader br = new BinaryReader(str))
                    {
                        while(br.PeekChar() != -1)
                        {
                        temp[0] = br.ReadString();
                        temp[1] = br.ReadString();
                        temp[2] = br.ReadString();
                        temp[3] = br.ReadString();
                        temp[4] = Convert.ToString( br.ReadInt32());

                        DodajDoListyV2(temp);
                        }
                           
                    }
                }

            }
        }

        private void XMLZapBtn_Click(object sender, EventArgs e)
        {
            Stream str;
            ZapiszWnd.Filter = "XML files (.xml)|*.xml";
            ZapiszWnd.RestoreDirectory = true;

            if (ZapiszWnd.ShowDialog() == DialogResult.OK)
            {
                if ((str = ZapiszWnd.OpenFile()) != null)
                {
                    XmlDocument doc = new XmlDocument();
                    XmlElement kontakt;
                    XmlNode node;
                    node = doc.AppendChild(doc.CreateElement("Kontakty"));
                    foreach (Kontakt i in Kontakty)
                    {
                        kontakt = (XmlElement)node.AppendChild(doc.CreateElement("Kontakt"));
                        kontakt.AppendChild(doc.CreateElement("Imie")).InnerText = i.Imie;
                        kontakt.AppendChild(doc.CreateElement("Nazwisko")).InnerText = i.Nazwisko;
                        kontakt.AppendChild(doc.CreateElement("Telefon")).InnerText = i.Telefon;
                        kontakt.AppendChild(doc.CreateElement("Email")).InnerText = i.Email;
                        kontakt.AppendChild(doc.CreateElement("Wiek")).InnerText = i.Wiek.ToString();
                    }
                    doc.Save(str);
                }

            }
        }

        private void XMLOdBtn_Click(object sender, EventArgs e)
        {
            Stream str;
            WczytajWnd.Filter = "XML files (.xml)|*.xml";
            WczytajWnd.RestoreDirectory = true;

            if (WczytajWnd.ShowDialog() == DialogResult.OK)
            {
                if ((str = WczytajWnd.OpenFile()) != null)
                {
                    Kontakty.Clear();
                    ListaKontaktow.VirtualListSize = 0;
                    Kontakt nowy = new Kontakt();
                    int i = 0;
                    using (XmlTextReader xr = new XmlTextReader(str))
                    {
                        xr.MoveToContent();
                        while (xr.Read())
                        {
                            if (xr.IsStartElement())
                            {
                                if (xr.Name == "Kontakt")
                                {
                                    for (; ; )
                                    {
                                        if (xr.IsStartElement())
                                        {
                                            xr.Read();
                                            if (xr.Value != "\r\n    ")
                                            {
                                                switch (i)
                                                {
                                                    case 0: nowy.Imie = xr.Value;
                                                        break;
                                                    case 1: nowy.Nazwisko = xr.Value;
                                                        break;
                                                    case 2: nowy.Telefon = xr.Value;
                                                        break;
                                                    case 3: nowy.Email = xr.Value;
                                                        break;
                                                    case 4: nowy.Wiek = Convert.ToInt32(xr.Value);
                                                        break;
                                                }
                                                i++;
                                                xr.Read();
                                                xr.Read();
                                                if (i == 5)
                                                {
                                                    i = 0;
                                                    Kontakty.Add(nowy);
                                                    nowy = new Kontakt();
                                                    ListaKontaktow.VirtualListSize++;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                } 
                            }
                        }
                    }
                   /* XmlDataDocument doc = new XmlDataDocument();
                    XmlTextReader xr = new XmlTextReader(str);
                    XmlNodeList node;
                    Kontakt nowy = new Kontakt();
                    ListaKontaktow.VirtualListSize = 0;
                    Kontakty.Clear();
                    //doc.DataSet.ReadXmlSchema(".\\schem.xsd");
                    xr.MoveToContent();
                    doc.Load(xr);
                    node = doc.SelectNodes("//Kontakt");

                    for (int i = 0; i < node.Count; i++)
                    {
                        nowy.Imie = node.Item(i).ChildNodes.Item(0).InnerText;
                        nowy.Nazwisko = node.Item(i).ChildNodes.Item(1).InnerText;
                        nowy.Telefon = node.Item(i).ChildNodes.Item(2).InnerText;
                        nowy.Email = node.Item(i).ChildNodes.Item(3).InnerText;
                        nowy.Wiek = Convert.ToInt32(node.Item(i).ChildNodes.Item(4).InnerText);
                        Kontakty.Add(nowy);
                        nowy = new Kontakt();
                        ListaKontaktow.VirtualListSize++;

                    }*/
                   /* for (int x = 0; x < doc.ChildNodes.Count; x++)
                    {
                        node = doc.DocumentElement.ChildNodes.Item(x);
                    }*/
                    //node = i;

                    /*var custs = from c in XElement.Load(str).Elements("Kontakty")
                                select c;*/

                }

            }
        }

        private void WizBTN_Click(object sender, EventArgs e)
        {
            for (int i = ListaKontaktow.Items.Count - 1; i >= 0; i--)
            {
                if (ListaKontaktow.Items[i].Selected)
                {
                    Wizytowka w = new Wizytowka();
                    w.Dane(ListaKontaktow.Items[i]);
                    w.Show(this);
                    break;
                }
            }
        }

        private void BTNProcesy_Click(object sender, EventArgs e)
        {
            Procesy proc = new Procesy();
            proc.Show();
        }
    }

    class Kontakt
    {
        public string Imie
        {
            get;
            set;
        }
        public string Nazwisko
        {
            get;
            set;
        }
        public string Telefon
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public int Wiek
        {
            get;
            set;
        }
    }
}
