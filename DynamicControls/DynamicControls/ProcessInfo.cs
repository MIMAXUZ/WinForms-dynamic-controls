using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicControls
{
    class ProcessInfo
    {
        /*
         * This class generates dynamic panels, textbox, labels and ec
         */
         // Objects 
        public Panel mainPanel;
        public Label lblProcessName;
        public TextBox txtArrivalTime;
        public TextBox txtProcessDuration;
        public TextBox txtQym1;

        //Number of rows (labels, textbox)
        public int processNumber;

        private ToolTip TT;

        // all the members of the struct has to be initialized in this way
        public ProcessInfo(int procNumber, Point panelLocation)
        {
            processNumber = procNumber;
            TT = initialize_ToolTipTT();
            mainPanel = initialize_Panel(panelLocation);
            lblProcessName = initialize_Label();
            txtArrivalTime = initialize_TextBoxArrivalTime();
            txtProcessDuration = initialize_TextBoxProcessDuration();
            //set values
            txtQym1 = initialize_txtQym1();
            this.mainPanel.Controls.AddRange(new Control[] { lblProcessName, txtQym1 });
            this.mainPanel.ResumeLayout(false);
        }
        private TextBox initialize_txtQym1()
        {
            TextBox txtAT = new TextBox();
            txtAT.ForeColor = System.Drawing.Color.Gray;
            txtAT.Location = new System.Drawing.Point(154, 11);
            txtAT.Name = "txtQym1";
            txtAT.Size = new System.Drawing.Size(700, 20);
            txtAT.TabIndex = 1;
            txtAT.Text = "0";
            txtAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            return txtAT;
        }

        /// <summary>
        /// key Press event for Numerical textbox
        /// </summary>
        /// <param name="sender">A TextBox</param>
        /// <param name="e">key Press Event Arguments</param>
       
        private void txtNumerical_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != '') // this char is Backspace and not A SPACE!
                {
                    e.Handled = true;
                }
        }

        private Panel initialize_Panel(Point position)
        {
            Panel pnlMain = new Panel();

            pnlMain.BackColor = System.Drawing.Color.Honeydew;
            pnlMain.Location = position;
            pnlMain.Name = "pnlMain" + processNumber.ToString();
            pnlMain.Size = new System.Drawing.Size(980, 40);
            pnlMain.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

            pnlMain.TabIndex = 0;

            return pnlMain;
        }

        private Label initialize_Label()
        {
            Label lblPN = new Label();

            lblPN.AutoSize = true;
            lblPN.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPN.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblPN.Location = new System.Drawing.Point(12, 8);
            lblPN.Name = "lblPN";
            lblPN.Size = new System.Drawing.Size(98, 24);
            lblPN.TabIndex = 0;
            lblPN.Text = String.Format("Process {0}: ", processNumber.ToString());

            return lblPN;
        }

        private TextBox initialize_TextBoxArrivalTime()
        {
            TextBox txtAT = new TextBox();

            txtAT.ForeColor = System.Drawing.Color.Gray;
            txtAT.Location = new System.Drawing.Point(154, 11);
            txtAT.Name = "txtArrivalTime";
            txtAT.Size = new System.Drawing.Size(56, 20);
            txtAT.TabIndex = 1;
            txtAT.Text = "0";
            txtAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            return txtAT;
        }

        private TextBox initialize_TextBoxProcessDuration()
        {
            TextBox txtPD = new TextBox();

            txtPD.ForeColor = System.Drawing.Color.Gray;
            txtPD.Location = new System.Drawing.Point(220, 11);
            txtPD.Name = "txtProcessDuration";
            txtPD.Size = new System.Drawing.Size(56, 20);
            txtPD.TabIndex = 1;
            txtPD.Text = "0";
            txtPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            return txtPD;
        }

        private ToolTip initialize_ToolTipTT()
        {
            ToolTip toolTipTT = new ToolTip();

            toolTipTT.AutomaticDelay = 100;
            toolTipTT.AutoPopDelay = 10000;
            toolTipTT.InitialDelay = 100;
            toolTipTT.ReshowDelay = 20;
            toolTipTT.ShowAlways = true;
            toolTipTT.StripAmpersands = true;
            return toolTipTT;
        }
    }
}
