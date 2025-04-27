namespace GlowDesk
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            recentListBox = new ListBox();
            label1 = new Label();
            buttonScanNow = new Button();
            checkBoxAutoScan = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            numericThreshold = new NumericUpDown();
            label3 = new Label();
            fileWatcher = new FileSystemWatcher();
            buttonBrowse = new Button();
            contextMenuStrip = new ContextMenuStrip(components);
            copyPathMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileWatcher).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // recentListBox
            // 
            recentListBox.ContextMenuStrip = contextMenuStrip;
            recentListBox.DrawMode = DrawMode.OwnerDrawFixed;
            recentListBox.FormattingEnabled = true;
            recentListBox.Location = new Point(46, 129);
            recentListBox.Name = "recentListBox";
            recentListBox.Size = new Size(1035, 388);
            recentListBox.TabIndex = 0;
            recentListBox.DrawItem += recentListBox_DrawItem;
            recentListBox.SelectedIndexChanged += recentListBox_SelectedIndexChanged;
            recentListBox.DoubleClick += recentListBox_DoubleClick;
            recentListBox.MouseDown += recentListBox_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(617, 50);
            label1.TabIndex = 1;
            label1.Text = "GlowDesk- Recent Activity Tracker";
            label1.Click += label1_Click;
            // 
            // buttonScanNow
            // 
            buttonScanNow.Location = new Point(579, 600);
            buttonScanNow.Name = "buttonScanNow";
            buttonScanNow.Size = new Size(150, 46);
            buttonScanNow.TabIndex = 2;
            buttonScanNow.Text = "Scan Now";
            buttonScanNow.UseVisualStyleBackColor = true;
            buttonScanNow.Click += buttonScanNow_Click;
            // 
            // checkBoxAutoScan
            // 
            checkBoxAutoScan.AutoSize = true;
            checkBoxAutoScan.Location = new Point(778, 606);
            checkBoxAutoScan.Name = "checkBoxAutoScan";
            checkBoxAutoScan.Size = new Size(315, 36);
            checkBoxAutoScan.TabIndex = 3;
            checkBoxAutoScan.Text = "Auto Scan in Background";
            checkBoxAutoScan.UseVisualStyleBackColor = true;
            checkBoxAutoScan.CheckedChanged += checkBoxAutoScan_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 602);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 4;
            label2.Text = "Show Top";
            // 
            // numericThreshold
            // 
            numericThreshold.Location = new Point(170, 600);
            numericThreshold.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericThreshold.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericThreshold.Name = "numericThreshold";
            numericThreshold.Size = new Size(84, 39);
            numericThreshold.TabIndex = 5;
            numericThreshold.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 602);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 6;
            label3.Text = "Items";
            label3.Click += label3_Click;
            // 
            // fileWatcher
            // 
            fileWatcher.EnableRaisingEvents = true;
            fileWatcher.IncludeSubdirectories = true;
            fileWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastAccess;
            fileWatcher.SynchronizingObject = this;
            fileWatcher.Changed += fileWatcher_Changed;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(359, 600);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(173, 46);
            buttonBrowse.TabIndex = 7;
            buttonBrowse.Text = "Browse Folder";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(32, 32);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { copyPathMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(197, 42);
            // 
            // copyPathMenuItem
            // 
            copyPathMenuItem.Name = "copyPathMenuItem";
            copyPathMenuItem.Size = new Size(300, 38);
            copyPathMenuItem.Text = "Copy Path";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 707);
            Controls.Add(buttonBrowse);
            Controls.Add(label3);
            Controls.Add(numericThreshold);
            Controls.Add(label2);
            Controls.Add(checkBoxAutoScan);
            Controls.Add(buttonScanNow);
            Controls.Add(label1);
            Controls.Add(recentListBox);
            Name = "MainForm";
            Text = "GlowDesk";
            Load += MainForm_Load;
            Click += MainForm_Click;
            MouseMove += MainForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)numericThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileWatcher).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox recentListBox;
        private Label label1;
        private Button buttonScanNow;
        private CheckBox checkBoxAutoScan;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private NumericUpDown numericThreshold;
        private Label label3;
        private FileSystemWatcher fileWatcher;
        private Button buttonBrowse;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem copyPathMenuItem;
    }
}
