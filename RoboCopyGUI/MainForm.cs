using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCopyGUI
{
    public partial class MainForm : Form
    {
        private bool copyInProgress = false;
        private int totalFiles = 0;
        private int copiedFiles = 0;
        private Random random = new Random(); // Reuse Random instance

        public MainForm()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(800, 1000);
            InitializeForm();
            copyTimer.Tick += copyTimer_Tick;
            statusTimer.Tick += statusTimer_Tick;
            Panel mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.AutoScroll = true;
            this.Controls.Add(mainPanel);
        }

        private void InitializeForm()
        {
            // Initialize form settings
            this.Text = "Robocopy File Copier";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(118, 75, 162);
            this.Padding = new Padding(20);

            // Initialize controls
            filePatternGroup.Visible = false;
            advancedOptions.Visible = false;
            progressContainer.Visible = false;
            logContainer.Visible = false;
            statusPanel.Visible = false;

            // Set default values
            copyTypeComboBox.SelectedIndex = 0; // Single File
            threadsComboBox.SelectedIndex = 3; // 8 threads
            retriesComboBox.SelectedIndex = 2; // 3 retries
            waitTimeComboBox.SelectedIndex = 2; // 30 seconds
            copyFlagsComboBox.SelectedIndex = 0; // DAT

            sourcePathTextBox.TextChanged += control_Changed;
            destPathTextBox.TextChanged += control_Changed;

            // Style the form
            StyleControls();

            // Update command preview
            UpdateCommandPreview();
        }

        private void StyleControls()
        {
            // Style all controls consistently
            mainContainer.BackColor = Color.White;
            mainContainer.Padding = new Padding(30);
            mainContainer.BorderStyle = BorderStyle.None;
            mainContainer.BorderRadius = 20; // Custom property for rounded corners

            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(102, 126, 234);

            // Style buttons
            foreach (Control c in mainContainer.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.BackColor = Color.FromArgb(102, 126, 234);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    btn.Padding = new Padding(5);
                }
                else if (c is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.BackColor = Color.FromArgb(240, 240, 245);
                }
            }

            // Special style for copy button
            startCopyButton.BackColor = Color.FromArgb(17, 153, 142);
            startCopyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 133, 123);
            startCopyButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            startCopyButton.Height = 50;

            // Style status panel
            statusPanel.BorderRadius = 10;
        }

        private void UpdateCommandPreview()
        {
            // Check for null selection
            if (copyTypeComboBox.SelectedItem == null) return;

            string command = "robocopy ";

            if (copyTypeComboBox.SelectedItem.ToString() == "Single File")
            {
                if (string.IsNullOrWhiteSpace(sourcePathTextBox.Text))
                {
                    command += "\"source\" \"destination\"";
                }
                else
                {
                    string sourceDir = Path.GetDirectoryName(sourcePathTextBox.Text);
                    string fileName = Path.GetFileName(sourcePathTextBox.Text);
                    command += $"\"{sourceDir}\" \"{destPathTextBox.Text}\" \"{fileName}\"";
                }
            }
            else
            {
                command += $"\"{sourcePathTextBox.Text}\" \"{destPathTextBox.Text}\"";
                if (!string.IsNullOrEmpty(filePatternTextBox.Text))
                {
                    command += $" \"{filePatternTextBox.Text}\"";
                }
            }

            // Add options
            if (includeSubdirsCheckBox.Checked && copyTypeComboBox.SelectedItem.ToString() == "Entire Folder")
                command += " /E";
            if (mirrorModeCheckBox.Checked) command += " /MIR";
            if (moveFilesCheckBox.Checked) command += " /MOVE";
            command += $" /MT:{threadsComboBox.SelectedItem}";
            command += $" /R:{retriesComboBox.SelectedItem}";
            command += $" /W:{waitTimeComboBox.SelectedItem}";
            command += $" /COPY:{copyFlagsComboBox.SelectedItem}";

            commandPreviewLabel.Text = $"Command: {command.Replace("(Default)","").Replace("(Recommended)", "")}";
        }

        private void browseSourceButton_Click(object sender, EventArgs e)
        {
            if (copyTypeComboBox.SelectedItem.ToString() == "Single File")
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        sourcePathTextBox.Text = dialog.FileName;
                    }
                }
            }
            else
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        sourcePathTextBox.Text = dialog.SelectedPath;
                    }
                }
            }
            UpdateCommandPreview();
        }

        private void browseDestButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    destPathTextBox.Text = dialog.SelectedPath;
                }
            }
            UpdateCommandPreview();
        }

        private void copyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filePatternGroup.Visible = copyTypeComboBox.SelectedItem.ToString() == "Entire Folder";
            UpdateCommandPreview();
        }

        private async void startCopyButton_Click(object sender, EventArgs e)
        {
            if (copyInProgress) return;

            if (string.IsNullOrWhiteSpace(sourcePathTextBox.Text))
            {
                ShowStatus("Please select source path", StatusType.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(destPathTextBox.Text))
            {
                ShowStatus("Please select destination path", StatusType.Error);
                return;
            }

            if (!Directory.Exists(Path.GetDirectoryName(sourcePathTextBox.Text)))
            {
                ShowStatus("Source path does not exist", StatusType.Error);
                return;
            }

            copyInProgress = true;
            startCopyButton.Enabled = false;
            startCopyButton.Text = "⏳ Copying...";

            progressContainer.Visible = true;
            progressFill.Width = 0;
            progressLabel.Text = "Preparing to copy...";

            if (enableLoggingCheckBox.Checked)
            {
                logContainer.Visible = true;
                logOutputTextBox.Text = "→ Starting copy operation..." + Environment.NewLine;
            }

            // Estimate total files for progress simulation
            totalFiles = EstimateFileCount(sourcePathTextBox.Text);
            copiedFiles = 0;
            copyTimer.Start();
            string fullCommand = commandPreviewLabel.Text;
            string arguments = fullCommand.Substring("Command: robocopy ".Length);

            await Task.Run(() => RunRobocopy(arguments));
            copyInProgress = false;
            startCopyButton.Enabled = true;
            startCopyButton.Text = "🚀 Start Copy Operation";
        }

        private int EstimateFileCount(string path)
        {
            try
            {
                if (File.Exists(path)) return 1;
                return Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
            }
            catch
            {
                return 100; // Default estimate
            }
        }

        private void copyTimer_Tick(object sender, EventArgs e)
        {
            if (copiedFiles >= totalFiles)
            {
                CompleteCopy();
                return;
            }

            // Simulate progress
            copiedFiles += 1 + random.Next(5);
            if (copiedFiles > totalFiles) copiedFiles = totalFiles;

            int progress = (int)((double)copiedFiles / totalFiles * 100);
            progressFill.Width = (int)(progressBar.Width * progress / 100);
            progressLabel.Text = $"Progress: {progress}% completed";

            // Simulate log output
            if (enableLoggingCheckBox.Checked)
            {
                if (copiedFiles < totalFiles * 0.2 && logOutputTextBox.Lines.Length < 3)
                    logOutputTextBox.AppendText("→ Scanning source files..." + Environment.NewLine);
                else if (copiedFiles < totalFiles * 0.4 && logOutputTextBox.Lines.Length < 4)
                    logOutputTextBox.AppendText("→ Creating destination directories..." + Environment.NewLine);
                else if (copiedFiles < totalFiles * 0.6 && logOutputTextBox.Lines.Length < 5)
                    logOutputTextBox.AppendText("→ Copying files..." + Environment.NewLine);
                else if (copiedFiles < totalFiles * 0.8 && logOutputTextBox.Lines.Length < 6)
                    logOutputTextBox.AppendText("→ Verifying copied files..." + Environment.NewLine);

                logOutputTextBox.SelectionStart = logOutputTextBox.Text.Length;
                logOutputTextBox.ScrollToCaret();
            }
        }

        private void CompleteCopy()
        {
            copyTimer.Stop();
            copyInProgress = false;
            startCopyButton.Enabled = true;
            startCopyButton.Text = "🚀 Start Copy Operation";

            if (enableLoggingCheckBox.Checked)
            {
                logOutputTextBox.AppendText("→ Copy operation completed successfully!" + Environment.NewLine);
                logOutputTextBox.AppendText("→ All files copied without errors." + Environment.NewLine);
            }

            ShowStatus("Copy operation completed successfully! ✅", StatusType.Success);
        }

        private void ShowStatus(string message, StatusType type)
        {
            statusLabel.Text = message;
            statusPanel.Visible = true;

            switch (type)
            {
                case StatusType.Success:
                    statusPanel.BackColor = Color.FromArgb(230, 245, 243);
                    statusLabel.ForeColor = Color.FromArgb(17, 153, 142);
                    statusPanel.BorderColor = Color.FromArgb(17, 153, 142);
                    break;
                case StatusType.Error:
                    statusPanel.BackColor = Color.FromArgb(255, 235, 235);
                    statusLabel.ForeColor = Color.FromArgb(255, 82, 82);
                    statusPanel.BorderColor = Color.FromArgb(255, 82, 82);
                    break;
            }

            statusTimer.Stop();
            statusTimer.Start();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            statusPanel.Visible = false;
            statusTimer.Stop();
        }

        private void control_Changed(object sender, EventArgs e)
        {
            UpdateCommandPreview();
        }

        private void RunRobocopy(string arguments)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "robocopy.exe",
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (var proc = new Process { StartInfo = psi })
            {
                proc.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        this.Invoke(new Action(() =>
                        {
                            logOutputTextBox.AppendText(e.Data + Environment.NewLine);
                            logOutputTextBox.ScrollToCaret();
                        }));
                    }
                };

                proc.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        this.Invoke(new Action(() =>
                        {
                            logOutputTextBox.AppendText("ERROR: " + e.Data + Environment.NewLine);
                            logOutputTextBox.ScrollToCaret();
                        }));
                    }
                };

                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                proc.WaitForExit();
            }
        }

        private void mirrorModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string prefix = "Command: robocopy ";
            string command = commandPreviewLabel.Text.Substring(prefix.Length);

            if (mirrorModeCheckBox.Checked)
            {
                if (!command.Contains("/MIR"))
                    command = command + "/MIR ";
            }
            else
            {
                command = command.Replace("/MIR ", "");
                command = command.Replace("/MIR", "");
            }

            commandPreviewLabel.Text = prefix + command.Trim();
            UpdateCommandPreview();
        }

        public enum StatusType
        {
            Success,
            Error
        }

        private void moveFilesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string prefix = "Command: robocopy ";
            string command = commandPreviewLabel.Text.Substring(prefix.Length);

            if (moveFilesCheckBox.Checked)
            {
                if (!command.Contains("/MOVE"))
                    command = command + "/MOVE ";
            }
            else
            {
                command = command.Replace("/MOVE ", "");
                command = command.Replace("/MOVE", "");
            }

            commandPreviewLabel.Text = prefix + command.Trim();
            UpdateCommandPreview();
        }

        private void commandPreviewLabel_Click(object sender, EventArgs e)
        {
            string textToCopy = commandPreviewLabel.Text.Replace("Command: ","");

            if (!string.IsNullOrEmpty(textToCopy))
            {
                Clipboard.SetText(textToCopy);
                MessageBox.Show("Command copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void threadsComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string prefix = "Command: robocopy ";
            string currentCommand = commandPreviewLabel.Text;

            if (!currentCommand.StartsWith(prefix))
                return; // unexpected format

            // Extract the command part after prefix
            string command = currentCommand.Substring(prefix.Length);

            // Use regex to replace /MT:<number> with new value
            string pattern = @"/MT:\d+";
            string newMtValue = threadsComboBox.SelectedItem?.ToString() ?? "8";

            if (System.Text.RegularExpressions.Regex.IsMatch(command, pattern))
            {
                command = System.Text.RegularExpressions.Regex.Replace(command, pattern, $"/MT:{newMtValue}");
            }
            commandPreviewLabel.Text = prefix + command;
            UpdateCommandPreview();
        }

        private void retriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prefix = "Command: robocopy ";
            string currentCommand = commandPreviewLabel.Text;

            if (!currentCommand.StartsWith(prefix))
                return; // unexpected format

            // Extract the command part after prefix
            string command = currentCommand.Substring(prefix.Length);

            // Use regex to replace /MT:<number> with new value
            string pattern = @"/R:\d+";
            string newRvalue = threadsComboBox.SelectedItem?.ToString() ?? "3";

            if (System.Text.RegularExpressions.Regex.IsMatch(command, pattern))
            {
                command = System.Text.RegularExpressions.Regex.Replace(command, pattern, $"/R:{newRvalue}");
            }
            commandPreviewLabel.Text = prefix + command;
            UpdateCommandPreview();
        }

        private void waitTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prefix = "Command: robocopy ";
            string currentCommand = commandPreviewLabel.Text;

            if (!currentCommand.StartsWith(prefix))
                return; // unexpected format

            // Extract the command part after prefix
            string command = currentCommand.Substring(prefix.Length);

            // Use regex to replace /MT:<number> with new value
            string pattern = @"/W:\d+";
            string newRvalue = threadsComboBox.SelectedItem?.ToString() ?? "30";

            if (System.Text.RegularExpressions.Regex.IsMatch(command, pattern))
            {
                command = System.Text.RegularExpressions.Regex.Replace(command, pattern, $"/W:{newRvalue}");
            }
            commandPreviewLabel.Text = prefix + command;
            UpdateCommandPreview();
        }

        private void toggleAdvancedButton_Click(object sender, EventArgs e)
        {
            advancedOptions.Visible = !advancedOptions.Visible;
            toggleAdvancedButton.Text = advancedOptions.Visible ?
                "⚙️ Hide Advanced Options" : "⚙️ Show Advanced Options";
            UpdateCommandPreview();
        }

        private void copyFlagsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prefix = "Command: robocopy ";
            string currentCommand = commandPreviewLabel.Text;

            if (!currentCommand.StartsWith(prefix))
                return; // unexpected format

            // Extract the command part after prefix
            string command = currentCommand.Substring(prefix.Length);

            // Use regex to replace /MT:<number> with new value
            string pattern = @"/COPY:\s+";
            string newRvalue = threadsComboBox.SelectedItem?.ToString() ?? "30";

            if (System.Text.RegularExpressions.Regex.IsMatch(command, pattern))
            {
                command = System.Text.RegularExpressions.Regex.Replace(command, pattern, $"/COPY:{newRvalue}");
            }
            commandPreviewLabel.Text = prefix + command;
            UpdateCommandPreview();
        }
    }
}
