namespace DynamicControls
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumProcess = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.panelProcessInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNumProcess
            // 
            this.lblNumProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumProcess.AutoSize = true;
            this.lblNumProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProcess.ForeColor = System.Drawing.Color.Red;
            this.lblNumProcess.Location = new System.Drawing.Point(977, 684);
            this.lblNumProcess.Name = "lblNumProcess";
            this.lblNumProcess.Size = new System.Drawing.Size(19, 20);
            this.lblNumProcess.TabIndex = 13;
            this.lblNumProcess.Text = "0";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.Location = new System.Drawing.Point(270, 680);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(123, 30);
            this.btnClearAll.TabIndex = 12;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveProcess.Location = new System.Drawing.Point(141, 680);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(123, 30);
            this.btnRemoveProcess.TabIndex = 11;
            this.btnRemoveProcess.Text = "Remove";
            this.btnRemoveProcess.UseVisualStyleBackColor = true;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProcess.Location = new System.Drawing.Point(12, 680);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(123, 30);
            this.btnAddProcess.TabIndex = 10;
            this.btnAddProcess.Text = "Add a new";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // panelProcessInfo
            // 
            this.panelProcessInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProcessInfo.AutoScroll = true;
            this.panelProcessInfo.BackColor = System.Drawing.Color.Bisque;
            this.panelProcessInfo.Location = new System.Drawing.Point(12, 19);
            this.panelProcessInfo.Name = "panelProcessInfo";
            this.panelProcessInfo.Size = new System.Drawing.Size(984, 655);
            this.panelProcessInfo.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblNumProcess);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveProcess);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.panelProcessInfo);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumProcess;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Panel panelProcessInfo;
    }
}

