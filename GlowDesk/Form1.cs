using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GlowDesk
{
    public partial class MainForm : Form
    {
        ToolTip fileToolTip = new ToolTip();
        private string customPath = string.Empty;
        private ContextMenuStrip contextMenu;

        public MainForm()
        {
            InitializeComponent();
            InitializeContextMenu();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            recentListBox.DrawMode = DrawMode.OwnerDrawFixed;

            fileToolTip.SetToolTip(recentListBox, "Double-click to open");

            if (checkBoxAutoScan.Checked)
            {
                timer1.Enabled = true;
                ScanRecentFiles();
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Setup watcher
            fileWatcher.Path = desktopPath;
            fileWatcher.IncludeSubdirectories = false;
            fileWatcher.EnableRaisingEvents = checkBoxAutoScan.Checked;

            // Event hooks
            fileWatcher.Created += fileWatcher_Changed;
            fileWatcher.Changed += fileWatcher_Changed;
            fileWatcher.Renamed += fileWatcher_Changed;
            fileWatcher.Deleted += fileWatcher_Changed;

            // Hook up the right-click mouse event for the ListBox
            recentListBox.MouseDown += recentListBox_MouseDown;
        }

        private void buttonScanNow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(customPath))
                ScanRecentFiles(customPath);
            else
                ScanRecentFiles(); // default desktop
        }

        private void ScanRecentFiles(string folderPath = null)
        {
            try
            {
                string pathToScan = folderPath ?? Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filesAndDirs = Directory.GetFileSystemEntries(pathToScan);

                int threshold = (int)numericThreshold.Value;

                var recentItems = filesAndDirs
                    .Select(path => new FileInfo(path))
                    .OrderByDescending(f => f.LastAccessTime)
                    .Take(threshold)
                    .ToList();

                recentListBox.Items.Clear();

                foreach (var item in recentItems)
                {
                    string displayText = $"{item.Name}  (Accessed: {item.LastAccessTime})";
                    recentListBox.Items.Add(new ListBoxItemWithPath(displayText, item.FullName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading files: " + ex.Message);
            }
        }

        private void recentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: handle selection change if needed
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void MainForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form clicked!");
        }

        private void recentListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var item = recentListBox.Items[e.Index] as ListBoxItemWithPath;
            string text = item?.ToString() ?? recentListBox.Items[e.Index].ToString();

            // 1. Set background manually
            Color backgroundColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? Color.LightSkyBlue
                : recentListBox.BackColor;
            using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            // 2. Set text color
            Color textColor;
            if (e.Index == 0)
                textColor = Color.Green;
            else if (e.Index <= 2)
                textColor = Color.Goldenrod;
            else
                textColor = Color.OrangeRed;

            // 3. Draw text with a slight left and top padding
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds.Left + 5, e.Bounds.Top + 2);
            }

            // 4. Optional focus rectangle
            e.DrawFocusRectangle();
        }





        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            int index = recentListBox.IndexFromPoint(e.Location);
            if (index >= 0 && index < recentListBox.Items.Count)
            {
                if (recentListBox.Items[index] is ListBoxItemWithPath item)
                {
                    fileToolTip.SetToolTip(recentListBox, item.FullPath);
                }
            }
        }

        private void recentListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = recentListBox.SelectedIndex;
            if (index >= 0 && recentListBox.Items[index] is ListBoxItemWithPath item)
            {
                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", item.FullPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open item: " + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScanRecentFiles();
        }

        private void checkBoxAutoScan_CheckedChanged(object sender, EventArgs e)
        {
            fileWatcher.EnableRaisingEvents = checkBoxAutoScan.Checked;

            if (checkBoxAutoScan.Checked)
                timer1.Start();
            else
                timer1.Stop();
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void fileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new Action(() => ScanRecentFiles()));
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder to scan";
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    customPath = folderDialog.SelectedPath;
                    ScanRecentFiles(customPath);
                }
            }
        }
        private void InitializeContextMenu()
        {
            // Initialize ContextMenuStrip
            contextMenu = new ContextMenuStrip();

            // Create the "Copy Path" menu item
            var copyPathMenuItem = new ToolStripMenuItem("Copy Path");

            // Hook up the event handler for the click event
            copyPathMenuItem.Click += CopyPathItem_Click;

            // Add the item to the context menu
            contextMenu.Items.Add(copyPathMenuItem);

            // Set the ListBox's ContextMenuStrip property
            recentListBox.ContextMenuStrip = contextMenu;
        }


        private void recentListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Ensure contextMenu is initialized
                if (contextMenu == null)
                {
                    InitializeContextMenu();  // Make sure it's initialized before using it
                }

                // Get the index of the item under the mouse pointer
                int index = recentListBox.IndexFromPoint(e.Location);
                if (index >= 0 && index < recentListBox.Items.Count)
                {
                    // Set the selected item to the right-clicked item
                    recentListBox.SelectedIndex = index;

                    // Show the context menu at the mouse pointer location
                    contextMenu.Show(recentListBox, e.Location);
                }
            }
        }


        private void CopyPathItem_Click(object sender, EventArgs e)
        {
            int index = recentListBox.SelectedIndex;
            if (index >= 0 && recentListBox.Items[index] is ListBoxItemWithPath item)
            {
                // Copy the full path to the clipboard
                Clipboard.SetText(item.FullPath);
            }
        }

        public class ListBoxItemWithPath
        {
            public string DisplayText { get; set; }
            public string FullPath { get; set; }

            public ListBoxItemWithPath(string displayText, string fullPath)
            {
                DisplayText = displayText;
                FullPath = fullPath;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }
    }

}