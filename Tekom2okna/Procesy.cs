using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Aplikacja
{
    public partial class Procesy : Form
    {
        List<Process> ListaProcesow = new List<Process>();
        List<MyProcess> LProcesy = new List<MyProcess>();
        private PerformanceCounter cpuCounter;
        public Procesy()
        {
            InitializeComponent();
            ListaProcesow = Process.GetProcesses().ToList();
            LVProcesy.VirtualListSize = ListaProcesow.Count;
            for(int i=0;i<ListaProcesow.Count;i++)
            {
                //cpuCounter = new PerformanceCounter("Process", "% Processor Time", ListaProcesow[i].ProcessName);
                //cpuCounter.NextValue();
                //Thread.Sleep(50);
                

                LProcesy.Add(new MyProcess { ID = ListaProcesow[i].Id, Nazwa = ListaProcesow[i].ProcessName, Procesor = 0/*Math.Round(cpuCounter.NextValue()/Environment.ProcessorCount,2)*/, Pamiec=ListaProcesow[i].PrivateMemorySize64/1024 });

            }
            
        }

        private void LVProcesy_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            var proc = LProcesy[e.ItemIndex];

            e.Item = new ListViewItem(new string[] { proc.ID.ToString(), proc.Nazwa,proc.Procesor.ToString(),proc.Pamiec.ToString() });
            Tag = proc;
        }

        private void BTNOdswiez_Click(object sender, EventArgs e)
        {
            ListaProcesow.Clear();
            LVProcesy.VirtualListSize = 0;
            LProcesy.Clear();
            ListaProcesow = Process.GetProcesses().ToList();
            LVProcesy.VirtualListSize = ListaProcesow.Count;
            for (int i = 0; i < ListaProcesow.Count; i++)
            {
                //cpuCounter = new PerformanceCounter("Process", "% Processor Time", ListaProcesow[i].ProcessName);
                //cpuCounter.NextValue();
                //Thread.Sleep(50);

                LProcesy.Add(new MyProcess { ID = ListaProcesow[i].Id, Nazwa = ListaProcesow[i].ProcessName, Procesor = 0/*Math.Round(cpuCounter.NextValue() / Environment.ProcessorCount, 2)*/, Pamiec = ListaProcesow[i].WorkingSet64 / 1024 });

            }
        }

        private void BTNSzczegoly_Click(object sender, EventArgs e)
        {
            for (int i = LVProcesy.Items.Count - 1; i >= 0; i--)
            {
                if (LVProcesy.Items[i].Selected)
                {
                    Szczegoly sz = new Szczegoly();
                    Process result = ListaProcesow.Find(x => x.Id == Convert.ToInt32(LVProcesy.Items[i].SubItems[0].Text));
                    sz.GetSzczegoly(result);
                    sz.Show(this);
                    break;
                }
            }
        }

        private void BTNKill_Click(object sender, EventArgs e)
        {
            for (int i = LVProcesy.Items.Count - 1; i >= 0; i--)
            {
                if (LVProcesy.Items[i].Selected)
                {
                    Process result = ListaProcesow.Find(x => x.Id == Convert.ToInt32(LVProcesy.Items[i].SubItems[0].Text));
                    result.Kill();
                    BTNOdswiez_Click(sender, e);
                    break;
                }
            }
        }

        private void BTNNowy_Click(object sender, EventArgs e)
        {
            NowyProces nproc = new NowyProces();
            nproc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(MyProcess proc in LProcesy)
            {
                cpuCounter = new PerformanceCounter("Process", "% Processor Time", proc.Nazwa);
                cpuCounter.NextValue();
                Thread.Sleep(50);
                proc.Procesor = Math.Round( cpuCounter.NextValue() / Environment.ProcessorCount,2);
            }
            LVProcesy.Refresh();
        }
    }

    class MyProcess
    {
        public int ID
        {
            get;
            set;
        }

        public string Nazwa
        {
            get;
            set;
        }

        public double Procesor
        {
            get;
            set;
        }

        public double Pamiec
        {
            get;
            set;
        }
    }
}
