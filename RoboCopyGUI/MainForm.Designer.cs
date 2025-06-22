using RoboCopyGUI;
using System.Drawing;
using System.Windows.Forms;

namespace RoboCopyGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private RoundedPanel mainContainer;
        private Label titleLabel;
        private Label copyTypeLabel;
        private ComboBox copyTypeComboBox;
        private Label sourcePathLabel;
        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.Button browseSourceButton;
        private Label destPathLabel;
        private System.Windows.Forms.TextBox destPathTextBox;
        private System.Windows.Forms.Button browseDestButton;
        private Panel filePatternGroup;
        private Label filePatternLabel;
        private System.Windows.Forms.TextBox filePatternTextBox;
        private CheckBox includeSubdirsCheckBox;
        private CheckBox mirrorModeCheckBox;
        private CheckBox moveFilesCheckBox;
        private CheckBox enableLoggingCheckBox;
        private Label threadsLabel;
        private ComboBox threadsComboBox;
        private Label retriesLabel;
        private ComboBox retriesComboBox;
        private System.Windows.Forms.Button toggleAdvancedButton;
        private Panel advancedOptions;
        private Label waitTimeLabel;
        private ComboBox waitTimeComboBox;
        private Label copyFlagsLabel;
        private ComboBox copyFlagsComboBox;
        private Label commandPreviewLabel;
        private System.Windows.Forms.Button startCopyButton;
        private Panel progressContainer;
        private Label progressHeaderLabel;
        private Panel progressBar;
        private Panel progressFill;
        private Label progressLabel;
        private Panel logContainer;
        private Label logHeaderLabel;
        private System.Windows.Forms.TextBox logOutputTextBox;
        private RoundedPanel statusPanel;
        private Label statusLabel;
        private System.Windows.Forms.Timer copyTimer;
        private System.Windows.Forms.Timer statusTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            copyTimer = new System.Windows.Forms.Timer(components);
            statusTimer = new System.Windows.Forms.Timer(components);
            mainContainer = new RoundedPanel();
            titleLabel = new Label();
            copyTypeLabel = new Label();
            copyTypeComboBox = new ComboBox();
            sourcePathLabel = new Label();
            sourcePathTextBox = new TextBox();
            browseSourceButton = new Button();
            destPathLabel = new Label();
            destPathTextBox = new TextBox();
            browseDestButton = new Button();
            filePatternGroup = new Panel();
            filePatternLabel = new Label();
            filePatternTextBox = new TextBox();
            includeSubdirsCheckBox = new CheckBox();
            mirrorModeCheckBox = new CheckBox();
            moveFilesCheckBox = new CheckBox();
            enableLoggingCheckBox = new CheckBox();
            threadsLabel = new Label();
            threadsComboBox = new ComboBox();
            retriesLabel = new Label();
            retriesComboBox = new ComboBox();
            toggleAdvancedButton = new Button();
            advancedOptions = new Panel();
            waitTimeLabel = new Label();
            waitTimeComboBox = new ComboBox();
            copyFlagsLabel = new Label();
            copyFlagsComboBox = new ComboBox();
            commandPreviewLabel = new Label();
            startCopyButton = new Button();
            progressContainer = new Panel();
            progressHeaderLabel = new Label();
            progressBar = new Panel();
            progressFill = new Panel();
            progressLabel = new Label();
            logContainer = new Panel();
            logHeaderLabel = new Label();
            logOutputTextBox = new TextBox();
            statusPanel = new RoundedPanel();
            statusLabel = new Label();
            mainContainer.SuspendLayout();
            filePatternGroup.SuspendLayout();
            advancedOptions.SuspendLayout();
            progressContainer.SuspendLayout();
            progressBar.SuspendLayout();
            logContainer.SuspendLayout();
            statusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // copyTimer
            // 
            copyTimer.Interval = 200;
            // 
            // statusTimer
            // 
            statusTimer.Interval = 5000;
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.White;
            mainContainer.BorderColor = Color.White;
            mainContainer.BorderRadius = 20;
            mainContainer.BorderSize = 0;
            mainContainer.Controls.Add(titleLabel);
            mainContainer.Controls.Add(copyTypeLabel);
            mainContainer.Controls.Add(copyTypeComboBox);
            mainContainer.Controls.Add(sourcePathLabel);
            mainContainer.Controls.Add(commandPreviewLabel);
            mainContainer.Controls.Add(sourcePathTextBox);
            mainContainer.Controls.Add(browseSourceButton);
            mainContainer.Controls.Add(destPathLabel);
            mainContainer.Controls.Add(destPathTextBox);
            mainContainer.Controls.Add(browseDestButton);
            mainContainer.Controls.Add(filePatternGroup);
            mainContainer.Controls.Add(includeSubdirsCheckBox);
            mainContainer.Controls.Add(mirrorModeCheckBox);
            mainContainer.Controls.Add(moveFilesCheckBox);
            mainContainer.Controls.Add(enableLoggingCheckBox);
            mainContainer.Controls.Add(threadsLabel);
            mainContainer.Controls.Add(threadsComboBox);
            mainContainer.Controls.Add(retriesLabel);
            mainContainer.Controls.Add(retriesComboBox);
            mainContainer.Controls.Add(toggleAdvancedButton);
            mainContainer.Controls.Add(advancedOptions);
            mainContainer.Controls.Add(startCopyButton);
            mainContainer.Controls.Add(progressContainer);
            mainContainer.Controls.Add(logContainer);
            mainContainer.Controls.Add(statusPanel);
            mainContainer.Location = new Point(23, 23);
            mainContainer.Margin = new Padding(4, 3, 4, 3);
            mainContainer.Name = "mainContainer";
            mainContainer.Padding = new Padding(30);
            mainContainer.Size = new Size(868, 1030);
            mainContainer.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(102, 126, 234);
            titleLabel.Location = new Point(62, 30);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(740, 60);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "🚀 Robocopy File Copier";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // copyTypeLabel
            // 
            copyTypeLabel.AutoSize = true;
            copyTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyTypeLabel.Location = new Point(30, 100);
            copyTypeLabel.Margin = new Padding(4, 0, 4, 0);
            copyTypeLabel.Name = "copyTypeLabel";
            copyTypeLabel.Size = new Size(66, 15);
            copyTypeLabel.TabIndex = 1;
            copyTypeLabel.Text = "Copy Type:";
            // 
            // copyTypeComboBox
            // 
            copyTypeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            copyTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            copyTypeComboBox.FormattingEnabled = true;
            copyTypeComboBox.Items.AddRange(new object[] { "Single File", "Entire Folder" });
            copyTypeComboBox.Location = new Point(120, 97);
            copyTypeComboBox.Margin = new Padding(4, 3, 4, 3);
            copyTypeComboBox.Name = "copyTypeComboBox";
            copyTypeComboBox.Size = new Size(698, 23);
            copyTypeComboBox.TabIndex = 2;
            copyTypeComboBox.SelectedIndexChanged += copyTypeComboBox_SelectedIndexChanged_1;
            // 
            // sourcePathLabel
            // 
            sourcePathLabel.AutoSize = true;
            sourcePathLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sourcePathLabel.Location = new Point(30, 140);
            sourcePathLabel.Margin = new Padding(4, 0, 4, 0);
            sourcePathLabel.Name = "sourcePathLabel";
            sourcePathLabel.Size = new Size(77, 15);
            sourcePathLabel.TabIndex = 3;
            sourcePathLabel.Text = "Source Path:";
            // 
            // sourcePathTextBox
            // 
            sourcePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sourcePathTextBox.Location = new Point(150, 140);
            sourcePathTextBox.Margin = new Padding(4, 3, 4, 3);
            sourcePathTextBox.Name = "sourcePathTextBox";
            sourcePathTextBox.Size = new Size(618, 23);
            sourcePathTextBox.TabIndex = 4;
            // 
            // browseSourceButton
            // 
            browseSourceButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browseSourceButton.BackColor = Color.FromArgb(102, 126, 234);
            browseSourceButton.FlatStyle = FlatStyle.Flat;
            browseSourceButton.ForeColor = Color.White;
            browseSourceButton.Location = new Point(782, 134);
            browseSourceButton.Margin = new Padding(4, 3, 4, 3);
            browseSourceButton.Name = "browseSourceButton";
            browseSourceButton.Size = new Size(52, 33);
            browseSourceButton.TabIndex = 5;
            browseSourceButton.Text = "📁 Browse";
            browseSourceButton.UseVisualStyleBackColor = false;
            browseSourceButton.Click += browseSourceButton_Click;
            // 
            // destPathLabel
            // 
            destPathLabel.AutoSize = true;
            destPathLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            destPathLabel.Location = new Point(30, 180);
            destPathLabel.Margin = new Padding(4, 0, 4, 0);
            destPathLabel.Name = "destPathLabel";
            destPathLabel.Size = new Size(102, 15);
            destPathLabel.TabIndex = 6;
            destPathLabel.Text = "Destination Path:";
            // 
            // destPathTextBox
            // 
            destPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            destPathTextBox.Location = new Point(149, 178);
            destPathTextBox.Margin = new Padding(4, 3, 4, 3);
            destPathTextBox.Name = "destPathTextBox";
            destPathTextBox.Size = new Size(619, 23);
            destPathTextBox.TabIndex = 7;
            // 
            // browseDestButton
            // 
            browseDestButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browseDestButton.BackColor = Color.FromArgb(102, 126, 234);
            browseDestButton.FlatStyle = FlatStyle.Flat;
            browseDestButton.ForeColor = Color.White;
            browseDestButton.Location = new Point(782, 173);
            browseDestButton.Margin = new Padding(4, 3, 4, 3);
            browseDestButton.Name = "browseDestButton";
            browseDestButton.Size = new Size(52, 31);
            browseDestButton.TabIndex = 8;
            browseDestButton.Text = "📁 Browse";
            browseDestButton.UseVisualStyleBackColor = false;
            browseDestButton.Click += browseDestButton_Click;
            // 
            // filePatternGroup
            // 
            filePatternGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filePatternGroup.Controls.Add(filePatternLabel);
            filePatternGroup.Controls.Add(filePatternTextBox);
            filePatternGroup.Location = new Point(30, 220);
            filePatternGroup.Margin = new Padding(4, 3, 4, 3);
            filePatternGroup.Name = "filePatternGroup";
            filePatternGroup.Size = new Size(789, 50);
            filePatternGroup.TabIndex = 9;
            // 
            // filePatternLabel
            // 
            filePatternLabel.AutoSize = true;
            filePatternLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filePatternLabel.Location = new Point(4, 10);
            filePatternLabel.Margin = new Padding(4, 0, 4, 0);
            filePatternLabel.Name = "filePatternLabel";
            filePatternLabel.Size = new Size(130, 15);
            filePatternLabel.TabIndex = 0;
            filePatternLabel.Text = "File Pattern (optional):";
            // 
            // filePatternTextBox
            // 
            filePatternTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filePatternTextBox.Location = new Point(162, 7);
            filePatternTextBox.Margin = new Padding(4, 3, 4, 3);
            filePatternTextBox.Name = "filePatternTextBox";
            filePatternTextBox.Size = new Size(622, 23);
            filePatternTextBox.TabIndex = 1;
            // 
            // includeSubdirsCheckBox
            // 
            includeSubdirsCheckBox.AutoSize = true;
            includeSubdirsCheckBox.Checked = true;
            includeSubdirsCheckBox.CheckState = CheckState.Checked;
            includeSubdirsCheckBox.Location = new Point(30, 280);
            includeSubdirsCheckBox.Margin = new Padding(4, 3, 4, 3);
            includeSubdirsCheckBox.Name = "includeSubdirsCheckBox";
            includeSubdirsCheckBox.Size = new Size(107, 19);
            includeSubdirsCheckBox.TabIndex = 10;
            includeSubdirsCheckBox.Text = "Include Subdirs";
            includeSubdirsCheckBox.UseVisualStyleBackColor = true;
            includeSubdirsCheckBox.CheckedChanged += includeSubdirsCheckBox_CheckedChanged;
            // 
            // mirrorModeCheckBox
            // 
            mirrorModeCheckBox.AutoSize = true;
            mirrorModeCheckBox.Location = new Point(30, 310);
            mirrorModeCheckBox.Margin = new Padding(4, 3, 4, 3);
            mirrorModeCheckBox.Name = "mirrorModeCheckBox";
            mirrorModeCheckBox.Size = new Size(209, 19);
            mirrorModeCheckBox.TabIndex = 11;
            mirrorModeCheckBox.Text = "Mirror Mode (⚠️ Deletes extra files)";
            mirrorModeCheckBox.UseVisualStyleBackColor = true;
            mirrorModeCheckBox.CheckedChanged += mirrorModeCheckBox_CheckedChanged;
            // 
            // moveFilesCheckBox
            // 
            moveFilesCheckBox.AutoSize = true;
            moveFilesCheckBox.Location = new Point(30, 340);
            moveFilesCheckBox.Margin = new Padding(4, 3, 4, 3);
            moveFilesCheckBox.Name = "moveFilesCheckBox";
            moveFilesCheckBox.Size = new Size(184, 19);
            moveFilesCheckBox.TabIndex = 12;
            moveFilesCheckBox.Text = "Move Files (⚠️ Deletes source)";
            moveFilesCheckBox.UseVisualStyleBackColor = true;
            moveFilesCheckBox.CheckedChanged += moveFilesCheckBox_CheckedChanged;
            // 
            // enableLoggingCheckBox
            // 
            enableLoggingCheckBox.AutoSize = true;
            enableLoggingCheckBox.Checked = true;
            enableLoggingCheckBox.CheckState = CheckState.Checked;
            enableLoggingCheckBox.Location = new Point(30, 370);
            enableLoggingCheckBox.Margin = new Padding(4, 3, 4, 3);
            enableLoggingCheckBox.Name = "enableLoggingCheckBox";
            enableLoggingCheckBox.Size = new Size(108, 19);
            enableLoggingCheckBox.TabIndex = 13;
            enableLoggingCheckBox.Text = "Enable Logging";
            enableLoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // threadsLabel
            // 
            threadsLabel.AutoSize = true;
            threadsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            threadsLabel.Location = new Point(30, 410);
            threadsLabel.Margin = new Padding(4, 0, 4, 0);
            threadsLabel.Name = "threadsLabel";
            threadsLabel.Size = new Size(118, 15);
            threadsLabel.TabIndex = 14;
            threadsLabel.Text = "Number of Threads:";
            // 
            // threadsComboBox
            // 
            threadsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            threadsComboBox.FormattingEnabled = true;
            threadsComboBox.Items.AddRange(new object[] { "1 (Single-threaded)", "2", "4", "8 (Default)", "16", "32 (Max)" });
            threadsComboBox.Location = new Point(175, 407);
            threadsComboBox.Margin = new Padding(4, 3, 4, 3);
            threadsComboBox.Name = "threadsComboBox";
            threadsComboBox.Size = new Size(200, 23);
            threadsComboBox.TabIndex = 15;
            threadsComboBox.SelectedIndexChanged += threadsComboBox_SelectedIndexChanged_1;
            // 
            // retriesLabel
            // 
            retriesLabel.AutoSize = true;
            retriesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retriesLabel.Location = new Point(30, 450);
            retriesLabel.Margin = new Padding(4, 0, 4, 0);
            retriesLabel.Name = "retriesLabel";
            retriesLabel.Size = new Size(114, 15);
            retriesLabel.TabIndex = 16;
            retriesLabel.Text = "Number of Retries:";
            // 
            // retriesComboBox
            // 
            retriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            retriesComboBox.FormattingEnabled = true;
            retriesComboBox.Items.AddRange(new object[] { "0 (No retries)", "1", "3 (Recommended)", "5", "10" });
            retriesComboBox.Location = new Point(170, 448);
            retriesComboBox.Margin = new Padding(4, 3, 4, 3);
            retriesComboBox.Name = "retriesComboBox";
            retriesComboBox.Size = new Size(200, 23);
            retriesComboBox.TabIndex = 17;
            retriesComboBox.SelectedIndexChanged += retriesComboBox_SelectedIndexChanged;
            // 
            // toggleAdvancedButton
            // 
            toggleAdvancedButton.BackColor = Color.Transparent;
            toggleAdvancedButton.FlatAppearance.BorderSize = 0;
            toggleAdvancedButton.FlatStyle = FlatStyle.Flat;
            toggleAdvancedButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toggleAdvancedButton.ForeColor = Color.FromArgb(102, 126, 234);
            toggleAdvancedButton.Location = new Point(30, 479);
            toggleAdvancedButton.Margin = new Padding(4, 3, 4, 3);
            toggleAdvancedButton.Name = "toggleAdvancedButton";
            toggleAdvancedButton.Size = new Size(201, 45);
            toggleAdvancedButton.TabIndex = 18;
            toggleAdvancedButton.Text = "⚙️ Show Advanced Options";
            toggleAdvancedButton.TextAlign = ContentAlignment.MiddleLeft;
            toggleAdvancedButton.UseVisualStyleBackColor = false;
            toggleAdvancedButton.Click += toggleAdvancedButton_Click;
            // 
            // advancedOptions
            // 
            advancedOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            advancedOptions.BorderStyle = BorderStyle.FixedSingle;
            advancedOptions.Controls.Add(waitTimeLabel);
            advancedOptions.Controls.Add(waitTimeComboBox);
            advancedOptions.Controls.Add(copyFlagsLabel);
            advancedOptions.Controls.Add(copyFlagsComboBox);
            advancedOptions.Location = new Point(30, 520);
            advancedOptions.Margin = new Padding(4, 3, 4, 3);
            advancedOptions.Name = "advancedOptions";
            advancedOptions.Size = new Size(788, 90);
            advancedOptions.TabIndex = 19;
            advancedOptions.Visible = false;
            // 
            // waitTimeLabel
            // 
            waitTimeLabel.AutoSize = true;
            waitTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            waitTimeLabel.Location = new Point(10, 15);
            waitTimeLabel.Margin = new Padding(4, 0, 4, 0);
            waitTimeLabel.Name = "waitTimeLabel";
            waitTimeLabel.Size = new Size(193, 15);
            waitTimeLabel.TabIndex = 0;
            waitTimeLabel.Text = "Wait Time Between Retries (sec):";
            // 
            // waitTimeComboBox
            // 
            waitTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            waitTimeComboBox.FormattingEnabled = true;
            waitTimeComboBox.Items.AddRange(new object[] { "5", "10", "30", "60" });
            waitTimeComboBox.Location = new Point(243, 13);
            waitTimeComboBox.Margin = new Padding(4, 3, 4, 3);
            waitTimeComboBox.Name = "waitTimeComboBox";
            waitTimeComboBox.Size = new Size(119, 23);
            waitTimeComboBox.TabIndex = 1;
            waitTimeComboBox.SelectedIndexChanged += waitTimeComboBox_SelectedIndexChanged;
            // 
            // copyFlagsLabel
            // 
            copyFlagsLabel.AutoSize = true;
            copyFlagsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyFlagsLabel.Location = new Point(10, 50);
            copyFlagsLabel.Margin = new Padding(4, 0, 4, 0);
            copyFlagsLabel.Name = "copyFlagsLabel";
            copyFlagsLabel.Size = new Size(67, 15);
            copyFlagsLabel.TabIndex = 2;
            copyFlagsLabel.Text = "Copy Flags:";
            // 
            // copyFlagsComboBox
            // 
            copyFlagsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            copyFlagsComboBox.FormattingEnabled = true;
            copyFlagsComboBox.Items.AddRange(new object[] { "DAT (Data, Attributes, Timestamps)", "COPYALL (Everything)", "DATA (Data only)" });
            copyFlagsComboBox.Location = new Point(96, 47);
            copyFlagsComboBox.Margin = new Padding(4, 3, 4, 3);
            copyFlagsComboBox.Name = "copyFlagsComboBox";
            copyFlagsComboBox.Size = new Size(300, 23);
            copyFlagsComboBox.TabIndex = 3;
            copyFlagsComboBox.SelectedIndexChanged += copyFlagsComboBox_SelectedIndexChanged;
            // 
            // commandPreviewLabel
            // 
            commandPreviewLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            commandPreviewLabel.BackColor = Color.FromArgb(248, 249, 250);
            commandPreviewLabel.BorderStyle = BorderStyle.FixedSingle;
            commandPreviewLabel.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            commandPreviewLabel.Location = new Point(30, 615);
            commandPreviewLabel.Margin = new Padding(4, 0, 4, 0);
            commandPreviewLabel.Name = "commandPreviewLabel";
            commandPreviewLabel.Padding = new Padding(10);
            commandPreviewLabel.Size = new Size(788, 137);
            commandPreviewLabel.TabIndex = 20;
            commandPreviewLabel.Text = "Command: robocopy \"source\" \"destination\" /E /MT:8 /R:3 /W:30";
            commandPreviewLabel.Click += commandPreviewLabel_Click;
            // 
            // startCopyButton
            // 
            startCopyButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            startCopyButton.BackColor = Color.FromArgb(17, 153, 142);
            startCopyButton.FlatAppearance.BorderSize = 0;
            startCopyButton.FlatStyle = FlatStyle.Flat;
            startCopyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startCopyButton.ForeColor = Color.White;
            startCopyButton.Location = new Point(30, 755);
            startCopyButton.Margin = new Padding(4, 3, 4, 3);
            startCopyButton.Name = "startCopyButton";
            startCopyButton.Size = new Size(789, 50);
            startCopyButton.TabIndex = 21;
            startCopyButton.Text = "🚀 Start Copy Operation";
            startCopyButton.UseVisualStyleBackColor = false;
            startCopyButton.Click += startCopyButton_Click;
            // 
            // progressContainer
            // 
            progressContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressContainer.Controls.Add(progressHeaderLabel);
            progressContainer.Controls.Add(progressBar);
            progressContainer.Controls.Add(progressLabel);
            progressContainer.Location = new Point(30, 815);
            progressContainer.Margin = new Padding(4, 3, 4, 3);
            progressContainer.Name = "progressContainer";
            progressContainer.Size = new Size(789, 80);
            progressContainer.TabIndex = 22;
            progressContainer.Visible = false;
            // 
            // progressHeaderLabel
            // 
            progressHeaderLabel.AutoSize = true;
            progressHeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressHeaderLabel.Location = new Point(4, 5);
            progressHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            progressHeaderLabel.Name = "progressHeaderLabel";
            progressHeaderLabel.Size = new Size(85, 15);
            progressHeaderLabel.TabIndex = 0;
            progressHeaderLabel.Text = "Copy Progress";
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.BackColor = Color.FromArgb(225, 229, 233);
            progressBar.BorderStyle = BorderStyle.FixedSingle;
            progressBar.Controls.Add(progressFill);
            progressBar.Location = new Point(0, 25);
            progressBar.Margin = new Padding(4, 3, 4, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(788, 25);
            progressBar.TabIndex = 1;
            // 
            // progressFill
            // 
            progressFill.BackColor = Color.FromArgb(17, 153, 142);
            progressFill.Dock = DockStyle.Left;
            progressFill.Location = new Point(0, 0);
            progressFill.Margin = new Padding(4, 3, 4, 3);
            progressFill.Name = "progressFill";
            progressFill.Size = new Size(0, 23);
            progressFill.TabIndex = 0;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(4, 55);
            progressLabel.Margin = new Padding(4, 0, 4, 0);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(110, 15);
            progressLabel.TabIndex = 2;
            progressLabel.Text = "Preparing to copy...";
            // 
            // logContainer
            // 
            logContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            logContainer.Controls.Add(logHeaderLabel);
            logContainer.Controls.Add(logOutputTextBox);
            logContainer.Location = new Point(30, 905);
            logContainer.Margin = new Padding(4, 3, 4, 3);
            logContainer.Name = "logContainer";
            logContainer.Size = new Size(789, 200);
            logContainer.TabIndex = 23;
            logContainer.Visible = false;
            // 
            // logHeaderLabel
            // 
            logHeaderLabel.AutoSize = true;
            logHeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logHeaderLabel.Location = new Point(4, 5);
            logHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            logHeaderLabel.Name = "logHeaderLabel";
            logHeaderLabel.Size = new Size(57, 15);
            logHeaderLabel.TabIndex = 1;
            logHeaderLabel.Text = "Copy Log";
            // 
            // logOutputTextBox
            // 
            logOutputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logOutputTextBox.BackColor = Color.Black;
            logOutputTextBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOutputTextBox.ForeColor = Color.Lime;
            logOutputTextBox.Location = new Point(0, 25);
            logOutputTextBox.Margin = new Padding(4, 3, 4, 3);
            logOutputTextBox.Multiline = true;
            logOutputTextBox.Name = "logOutputTextBox";
            logOutputTextBox.ReadOnly = true;
            logOutputTextBox.ScrollBars = ScrollBars.Vertical;
            logOutputTextBox.Size = new Size(788, 134);
            logOutputTextBox.TabIndex = 0;
            // 
            // statusPanel
            // 
            statusPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            statusPanel.BackColor = SystemColors.Control;
            statusPanel.BorderColor = Color.Gray;
            statusPanel.BorderRadius = 10;
            statusPanel.BorderSize = 2;
            statusPanel.Controls.Add(statusLabel);
            statusPanel.Location = new Point(30, 1060);
            statusPanel.Margin = new Padding(4, 3, 4, 3);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(789, 50);
            statusPanel.TabIndex = 24;
            statusPanel.Visible = false;
            // 
            // statusLabel
            // 
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            statusLabel.Location = new Point(0, 0);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(789, 50);
            statusLabel.TabIndex = 0;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(118, 75, 162);
            ClientSize = new Size(915, 1061);
            Controls.Add(mainContainer);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Robocopy File Copier";
            mainContainer.ResumeLayout(false);
            mainContainer.PerformLayout();
            filePatternGroup.ResumeLayout(false);
            filePatternGroup.PerformLayout();
            advancedOptions.ResumeLayout(false);
            advancedOptions.PerformLayout();
            progressContainer.ResumeLayout(false);
            progressContainer.PerformLayout();
            progressBar.ResumeLayout(false);
            logContainer.ResumeLayout(false);
            logContainer.PerformLayout();
            statusPanel.ResumeLayout(false);
            ResumeLayout(false);

        }
    }
}