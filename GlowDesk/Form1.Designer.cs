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
            recentListBox = new ListBox();
            titleLabel = new Label();
            scanButton = new Button();
            autoScanCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // recentListBox
            // 
            recentListBox.FormattingEnabled = true;
            recentListBox.Location = new Point(129, 146);
            recentListBox.Name = "recentListBox";
            recentListBox.Size = new Size(571, 260);
            recentListBox.TabIndex = 0;
            recentListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(119, 46);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(617, 50);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "GlowDesk- Recent Activity Tracker";
            titleLabel.Click += label1_Click;
            // 
            // scanButton
            // 
            scanButton.Location = new Point(129, 514);
            scanButton.Name = "scanButton";
            scanButton.Size = new Size(150, 46);
            scanButton.TabIndex = 2;
            scanButton.Text = "Scan Now";
            scanButton.UseVisualStyleBackColor = true;
            scanButton.Click += button1_Click;
            // 
            // autoScanCheckbox
            // 
            autoScanCheckbox.AutoSize = true;
            autoScanCheckbox.Location = new Point(393, 515);
            autoScanCheckbox.Name = "autoScanCheckbox";
            autoScanCheckbox.Size = new Size(315, 36);
            autoScanCheckbox.TabIndex = 3;
            autoScanCheckbox.Text = "Auto Scan in Background";
            autoScanCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 707);
            Controls.Add(autoScanCheckbox);
            Controls.Add(scanButton);
            Controls.Add(titleLabel);
            Controls.Add(recentListBox);
            Name = "MainForm";
            Text = "GlowDesk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox recentListBox;
        private Label titleLabel;
        private Button scanButton;
        private CheckBox autoScanCheckbox;
    }
}
