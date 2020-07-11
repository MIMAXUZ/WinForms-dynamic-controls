using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicControls
{
    public partial class MainForm : Form
    {
        // Global Variables
        List<ProcessInfo> lstProcInfo = new List<ProcessInfo>();
        //Form1 result;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            this.panelProcessInfo.VerticalScroll.Value = 0;
            int LastNumber = this.lstProcInfo.Count;
            lstProcInfo.Add(new ProcessInfo(LastNumber + 1, new Point(3, 7 + (46 * LastNumber))));
            this.panelProcessInfo.Controls.Add(lstProcInfo[LastNumber].mainPanel);
            LastNumber++;
            this.lblNumProcess.Text = LastNumber.ToString();
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            if (lstProcInfo.Count > 1) // minimum exist process is 1
            {
                this.panelProcessInfo.Controls.Remove(lstProcInfo[lstProcInfo.Count - 1].mainPanel);
                this.lstProcInfo.RemoveAt(lstProcInfo.Count - 1);
                this.lblNumProcess.Text = lstProcInfo.Count.ToString();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }
    }
}
