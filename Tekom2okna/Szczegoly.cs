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

namespace Aplikacja
{
    public partial class Szczegoly : Form
    {
        Process Proc;
        public Szczegoly()
        {
            InitializeComponent();
        }

        public Process GetSzczegoly(Process i)
        {
            Proc = i;
            LBLID.Text = Proc.Id.ToString();
            LBLNazwaProcesu.Text = Proc.ProcessName;
            //LBLGlownyModul.Text = Proc.MainModule.ModuleName;
            LBLRespond.Text = Proc.Responding.ToString();
            LBLIdSesji.Text = Proc.SessionId.ToString();
            LBLStartInfo.Text = Proc.StartInfo.FileName;
            //LBLStartTime.Text = Proc.StartTime.ToString();
            return i;
        }
    }
}
