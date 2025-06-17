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
            this.components = new System.ComponentModel.Container();
            this.copyTimer = new System.Windows.Forms.Timer(this.components);
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.mainContainer = new RoboCopyGUI.RoundedPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.copyTypeLabel = new System.Windows.Forms.Label();
            this.copyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sourcePathLabel = new System.Windows.Forms.Label();
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.browseSourceButton = new System.Windows.Forms.Button();
            this.destPathLabel = new System.Windows.Forms.Label();
            this.destPathTextBox = new System.Windows.Forms.TextBox();
            this.browseDestButton = new System.Windows.Forms.Button();
            this.filePatternGroup = new System.Windows.Forms.Panel();
            this.filePatternLabel = new System.Windows.Forms.Label();
            this.filePatternTextBox = new System.Windows.Forms.TextBox();
            this.includeSubdirsCheckBox = new System.Windows.Forms.CheckBox();
            this.mirrorModeCheckBox = new System.Windows.Forms.CheckBox();
            this.moveFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.enableLoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.threadsComboBox = new System.Windows.Forms.ComboBox();
            this.retriesLabel = new System.Windows.Forms.Label();
            this.retriesComboBox = new System.Windows.Forms.ComboBox();
            this.toggleAdvancedButton = new System.Windows.Forms.Button();
            this.advancedOptions = new System.Windows.Forms.Panel();
            this.waitTimeLabel = new System.Windows.Forms.Label();
            this.waitTimeComboBox = new System.Windows.Forms.ComboBox();
            this.copyFlagsLabel = new System.Windows.Forms.Label();
            this.copyFlagsComboBox = new System.Windows.Forms.ComboBox();
            this.commandPreviewLabel = new System.Windows.Forms.Label();
            this.startCopyButton = new System.Windows.Forms.Button();
            this.progressContainer = new System.Windows.Forms.Panel();
            this.progressHeaderLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.Panel();
            this.progressFill = new System.Windows.Forms.Panel();
            this.progressLabel = new System.Windows.Forms.Label();
            this.logContainer = new System.Windows.Forms.Panel();
            this.logHeaderLabel = new System.Windows.Forms.Label();
            this.logOutputTextBox = new System.Windows.Forms.TextBox();
            this.statusPanel = new RoboCopyGUI.RoundedPanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.filePatternGroup.SuspendLayout();
            this.advancedOptions.SuspendLayout();
            this.progressContainer.SuspendLayout();
            this.progressBar.SuspendLayout();
            this.logContainer.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyTimer
            // 
            this.copyTimer.Interval = 200;
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 5000;
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.BorderColor = System.Drawing.Color.White;
            this.mainContainer.BorderRadius = 20;
            this.mainContainer.BorderSize = 0;
            this.mainContainer.Controls.Add(this.titleLabel);
            this.mainContainer.Controls.Add(this.copyTypeLabel);
            this.mainContainer.Controls.Add(this.copyTypeComboBox);
            this.mainContainer.Controls.Add(this.sourcePathLabel);
            this.mainContainer.Controls.Add(this.sourcePathTextBox);
            this.mainContainer.Controls.Add(this.browseSourceButton);
            this.mainContainer.Controls.Add(this.destPathLabel);
            this.mainContainer.Controls.Add(this.destPathTextBox);
            this.mainContainer.Controls.Add(this.browseDestButton);
            this.mainContainer.Controls.Add(this.filePatternGroup);
            this.mainContainer.Controls.Add(this.includeSubdirsCheckBox);
            this.mainContainer.Controls.Add(this.mirrorModeCheckBox);
            this.mainContainer.Controls.Add(this.moveFilesCheckBox);
            this.mainContainer.Controls.Add(this.enableLoggingCheckBox);
            this.mainContainer.Controls.Add(this.threadsLabel);
            this.mainContainer.Controls.Add(this.threadsComboBox);
            this.mainContainer.Controls.Add(this.retriesLabel);
            this.mainContainer.Controls.Add(this.retriesComboBox);
            this.mainContainer.Controls.Add(this.toggleAdvancedButton);
            this.mainContainer.Controls.Add(this.advancedOptions);
            this.mainContainer.Controls.Add(this.commandPreviewLabel);
            this.mainContainer.Controls.Add(this.startCopyButton);
            this.mainContainer.Controls.Add(this.progressContainer);
            this.mainContainer.Controls.Add(this.logContainer);
            this.mainContainer.Controls.Add(this.statusPanel);
            this.mainContainer.Location = new System.Drawing.Point(20, 20);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(26);
            this.mainContainer.Size = new System.Drawing.Size(744, 893);
            this.mainContainer.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.titleLabel.Location = new System.Drawing.Point(53, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(634, 52);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "🚀 Robocopy File Copier";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyTypeLabel
            // 
            this.copyTypeLabel.AutoSize = true;
            this.copyTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyTypeLabel.Location = new System.Drawing.Point(26, 87);
            this.copyTypeLabel.Name = "copyTypeLabel";
            this.copyTypeLabel.Size = new System.Drawing.Size(66, 15);
            this.copyTypeLabel.TabIndex = 1;
            this.copyTypeLabel.Text = "Copy Type:";
            // 
            // copyTypeComboBox
            // 
            this.copyTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.copyTypeComboBox.FormattingEnabled = true;
            this.copyTypeComboBox.Items.AddRange(new object[] {
            "Single File",
            "Entire Folder"});
            this.copyTypeComboBox.Location = new System.Drawing.Point(103, 84);
            this.copyTypeComboBox.Name = "copyTypeComboBox";
            this.copyTypeComboBox.Size = new System.Drawing.Size(599, 21);
            this.copyTypeComboBox.TabIndex = 2;
            this.copyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.copyTypeComboBox_SelectedIndexChanged_1);
            // 
            // sourcePathLabel
            // 
            this.sourcePathLabel.AutoSize = true;
            this.sourcePathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcePathLabel.Location = new System.Drawing.Point(26, 121);
            this.sourcePathLabel.Name = "sourcePathLabel";
            this.sourcePathLabel.Size = new System.Drawing.Size(77, 15);
            this.sourcePathLabel.TabIndex = 3;
            this.sourcePathLabel.Text = "Source Path:";
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcePathTextBox.Location = new System.Drawing.Point(129, 121);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(530, 20);
            this.sourcePathTextBox.TabIndex = 4;
            // 
            // browseSourceButton
            // 
            this.browseSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseSourceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.browseSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseSourceButton.ForeColor = System.Drawing.Color.White;
            this.browseSourceButton.Location = new System.Drawing.Point(670, 116);
            this.browseSourceButton.Name = "browseSourceButton";
            this.browseSourceButton.Size = new System.Drawing.Size(45, 29);
            this.browseSourceButton.TabIndex = 5;
            this.browseSourceButton.Text = "📁 Browse";
            this.browseSourceButton.UseVisualStyleBackColor = false;
            this.browseSourceButton.Click += new System.EventHandler(this.browseSourceButton_Click);
            // 
            // destPathLabel
            // 
            this.destPathLabel.AutoSize = true;
            this.destPathLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destPathLabel.Location = new System.Drawing.Point(26, 156);
            this.destPathLabel.Name = "destPathLabel";
            this.destPathLabel.Size = new System.Drawing.Size(102, 15);
            this.destPathLabel.TabIndex = 6;
            this.destPathLabel.Text = "Destination Path:";
            // 
            // destPathTextBox
            // 
            this.destPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destPathTextBox.Location = new System.Drawing.Point(128, 154);
            this.destPathTextBox.Name = "destPathTextBox";
            this.destPathTextBox.Size = new System.Drawing.Size(531, 20);
            this.destPathTextBox.TabIndex = 7;
            // 
            // browseDestButton
            // 
            this.browseDestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseDestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.browseDestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseDestButton.ForeColor = System.Drawing.Color.White;
            this.browseDestButton.Location = new System.Drawing.Point(670, 150);
            this.browseDestButton.Name = "browseDestButton";
            this.browseDestButton.Size = new System.Drawing.Size(45, 27);
            this.browseDestButton.TabIndex = 8;
            this.browseDestButton.Text = "📁 Browse";
            this.browseDestButton.UseVisualStyleBackColor = false;
            this.browseDestButton.Click += new System.EventHandler(this.browseDestButton_Click);
            // 
            // filePatternGroup
            // 
            this.filePatternGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePatternGroup.Controls.Add(this.filePatternLabel);
            this.filePatternGroup.Controls.Add(this.filePatternTextBox);
            this.filePatternGroup.Location = new System.Drawing.Point(26, 191);
            this.filePatternGroup.Name = "filePatternGroup";
            this.filePatternGroup.Size = new System.Drawing.Size(676, 43);
            this.filePatternGroup.TabIndex = 9;
            // 
            // filePatternLabel
            // 
            this.filePatternLabel.AutoSize = true;
            this.filePatternLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePatternLabel.Location = new System.Drawing.Point(3, 9);
            this.filePatternLabel.Name = "filePatternLabel";
            this.filePatternLabel.Size = new System.Drawing.Size(130, 15);
            this.filePatternLabel.TabIndex = 0;
            this.filePatternLabel.Text = "File Pattern (optional):";
            // 
            // filePatternTextBox
            // 
            this.filePatternTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePatternTextBox.Location = new System.Drawing.Point(139, 6);
            this.filePatternTextBox.Name = "filePatternTextBox";
            this.filePatternTextBox.Size = new System.Drawing.Size(534, 20);
            this.filePatternTextBox.TabIndex = 1;
            // 
            // includeSubdirsCheckBox
            // 
            this.includeSubdirsCheckBox.AutoSize = true;
            this.includeSubdirsCheckBox.Checked = true;
            this.includeSubdirsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSubdirsCheckBox.Location = new System.Drawing.Point(26, 243);
            this.includeSubdirsCheckBox.Name = "includeSubdirsCheckBox";
            this.includeSubdirsCheckBox.Size = new System.Drawing.Size(99, 17);
            this.includeSubdirsCheckBox.TabIndex = 10;
            this.includeSubdirsCheckBox.Text = "Include Subdirs";
            this.includeSubdirsCheckBox.UseVisualStyleBackColor = true;
            // 
            // mirrorModeCheckBox
            // 
            this.mirrorModeCheckBox.AutoSize = true;
            this.mirrorModeCheckBox.Location = new System.Drawing.Point(26, 269);
            this.mirrorModeCheckBox.Name = "mirrorModeCheckBox";
            this.mirrorModeCheckBox.Size = new System.Drawing.Size(189, 17);
            this.mirrorModeCheckBox.TabIndex = 11;
            this.mirrorModeCheckBox.Text = "Mirror Mode (⚠️ Deletes extra files)";
            this.mirrorModeCheckBox.UseVisualStyleBackColor = true;
            this.mirrorModeCheckBox.CheckedChanged += new System.EventHandler(this.mirrorModeCheckBox_CheckedChanged);
            // 
            // moveFilesCheckBox
            // 
            this.moveFilesCheckBox.AutoSize = true;
            this.moveFilesCheckBox.Location = new System.Drawing.Point(26, 295);
            this.moveFilesCheckBox.Name = "moveFilesCheckBox";
            this.moveFilesCheckBox.Size = new System.Drawing.Size(172, 17);
            this.moveFilesCheckBox.TabIndex = 12;
            this.moveFilesCheckBox.Text = "Move Files (⚠️ Deletes source)";
            this.moveFilesCheckBox.UseVisualStyleBackColor = true;
            this.moveFilesCheckBox.CheckedChanged += new System.EventHandler(this.moveFilesCheckBox_CheckedChanged);
            // 
            // enableLoggingCheckBox
            // 
            this.enableLoggingCheckBox.AutoSize = true;
            this.enableLoggingCheckBox.Checked = true;
            this.enableLoggingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableLoggingCheckBox.Location = new System.Drawing.Point(26, 321);
            this.enableLoggingCheckBox.Name = "enableLoggingCheckBox";
            this.enableLoggingCheckBox.Size = new System.Drawing.Size(100, 17);
            this.enableLoggingCheckBox.TabIndex = 13;
            this.enableLoggingCheckBox.Text = "Enable Logging";
            this.enableLoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadsLabel.Location = new System.Drawing.Point(26, 355);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(118, 15);
            this.threadsLabel.TabIndex = 14;
            this.threadsLabel.Text = "Number of Threads:";
            // 
            // threadsComboBox
            // 
            this.threadsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threadsComboBox.FormattingEnabled = true;
            this.threadsComboBox.Items.AddRange(new object[] {
            "1 (Single-threaded)",
            "2",
            "4",
            "8 (Default)",
            "16",
            "32 (Max)"});
            this.threadsComboBox.Location = new System.Drawing.Point(150, 353);
            this.threadsComboBox.Name = "threadsComboBox";
            this.threadsComboBox.Size = new System.Drawing.Size(172, 21);
            this.threadsComboBox.TabIndex = 15;
            this.threadsComboBox.SelectedIndexChanged += new System.EventHandler(this.threadsComboBox_SelectedIndexChanged_1);
            // 
            // retriesLabel
            // 
            this.retriesLabel.AutoSize = true;
            this.retriesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retriesLabel.Location = new System.Drawing.Point(26, 390);
            this.retriesLabel.Name = "retriesLabel";
            this.retriesLabel.Size = new System.Drawing.Size(114, 15);
            this.retriesLabel.TabIndex = 16;
            this.retriesLabel.Text = "Number of Retries:";
            // 
            // retriesComboBox
            // 
            this.retriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.retriesComboBox.FormattingEnabled = true;
            this.retriesComboBox.Items.AddRange(new object[] {
            "0 (No retries)",
            "1",
            "3 (Recommended)",
            "5",
            "10"});
            this.retriesComboBox.Location = new System.Drawing.Point(146, 388);
            this.retriesComboBox.Name = "retriesComboBox";
            this.retriesComboBox.Size = new System.Drawing.Size(172, 21);
            this.retriesComboBox.TabIndex = 17;
            this.retriesComboBox.SelectedIndexChanged += new System.EventHandler(this.retriesComboBox_SelectedIndexChanged);
            // 
            // toggleAdvancedButton
            // 
            this.toggleAdvancedButton.BackColor = System.Drawing.Color.Transparent;
            this.toggleAdvancedButton.FlatAppearance.BorderSize = 0;
            this.toggleAdvancedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleAdvancedButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleAdvancedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.toggleAdvancedButton.Location = new System.Drawing.Point(26, 415);
            this.toggleAdvancedButton.Name = "toggleAdvancedButton";
            this.toggleAdvancedButton.Size = new System.Drawing.Size(172, 39);
            this.toggleAdvancedButton.TabIndex = 18;
            this.toggleAdvancedButton.Text = "⚙️ Show Advanced Options";
            this.toggleAdvancedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toggleAdvancedButton.UseVisualStyleBackColor = false;
            this.toggleAdvancedButton.Click += new System.EventHandler(this.toggleAdvancedButton_Click);
            // 
            // advancedOptions
            // 
            this.advancedOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.advancedOptions.Controls.Add(this.waitTimeLabel);
            this.advancedOptions.Controls.Add(this.waitTimeComboBox);
            this.advancedOptions.Controls.Add(this.copyFlagsLabel);
            this.advancedOptions.Controls.Add(this.copyFlagsComboBox);
            this.advancedOptions.Location = new System.Drawing.Point(26, 451);
            this.advancedOptions.Name = "advancedOptions";
            this.advancedOptions.Size = new System.Drawing.Size(676, 78);
            this.advancedOptions.TabIndex = 19;
            this.advancedOptions.Visible = false;
            // 
            // waitTimeLabel
            // 
            this.waitTimeLabel.AutoSize = true;
            this.waitTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitTimeLabel.Location = new System.Drawing.Point(9, 13);
            this.waitTimeLabel.Name = "waitTimeLabel";
            this.waitTimeLabel.Size = new System.Drawing.Size(193, 15);
            this.waitTimeLabel.TabIndex = 0;
            this.waitTimeLabel.Text = "Wait Time Between Retries (sec):";
            // 
            // waitTimeComboBox
            // 
            this.waitTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waitTimeComboBox.FormattingEnabled = true;
            this.waitTimeComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60"});
            this.waitTimeComboBox.Location = new System.Drawing.Point(208, 11);
            this.waitTimeComboBox.Name = "waitTimeComboBox";
            this.waitTimeComboBox.Size = new System.Drawing.Size(103, 21);
            this.waitTimeComboBox.TabIndex = 1;
            this.waitTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.waitTimeComboBox_SelectedIndexChanged);
            // 
            // copyFlagsLabel
            // 
            this.copyFlagsLabel.AutoSize = true;
            this.copyFlagsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyFlagsLabel.Location = new System.Drawing.Point(9, 43);
            this.copyFlagsLabel.Name = "copyFlagsLabel";
            this.copyFlagsLabel.Size = new System.Drawing.Size(67, 15);
            this.copyFlagsLabel.TabIndex = 2;
            this.copyFlagsLabel.Text = "Copy Flags:";
            // 
            // copyFlagsComboBox
            // 
            this.copyFlagsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.copyFlagsComboBox.FormattingEnabled = true;
            this.copyFlagsComboBox.Items.AddRange(new object[] {
            "DAT (Data, Attributes, Timestamps)",
            "COPYALL (Everything)",
            "DATA (Data only)"});
            this.copyFlagsComboBox.Location = new System.Drawing.Point(82, 41);
            this.copyFlagsComboBox.Name = "copyFlagsComboBox";
            this.copyFlagsComboBox.Size = new System.Drawing.Size(258, 21);
            this.copyFlagsComboBox.TabIndex = 3;
            this.copyFlagsComboBox.SelectedIndexChanged += new System.EventHandler(this.copyFlagsComboBox_SelectedIndexChanged);
            // 
            // commandPreviewLabel
            // 
            this.commandPreviewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandPreviewLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.commandPreviewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commandPreviewLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandPreviewLabel.Location = new System.Drawing.Point(26, 532);
            this.commandPreviewLabel.Name = "commandPreviewLabel";
            this.commandPreviewLabel.Padding = new System.Windows.Forms.Padding(9);
            this.commandPreviewLabel.Size = new System.Drawing.Size(676, 119);
            this.commandPreviewLabel.TabIndex = 20;
            this.commandPreviewLabel.Text = "Command: robocopy \"source\" \"destination\" /E /MT:8 /R:3 /W:30";
            this.commandPreviewLabel.Click += new System.EventHandler(this.commandPreviewLabel_Click);
            // 
            // startCopyButton
            // 
            this.startCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startCopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.startCopyButton.FlatAppearance.BorderSize = 0;
            this.startCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startCopyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCopyButton.ForeColor = System.Drawing.Color.White;
            this.startCopyButton.Location = new System.Drawing.Point(26, 654);
            this.startCopyButton.Name = "startCopyButton";
            this.startCopyButton.Size = new System.Drawing.Size(676, 43);
            this.startCopyButton.TabIndex = 21;
            this.startCopyButton.Text = "🚀 Start Copy Operation";
            this.startCopyButton.UseVisualStyleBackColor = false;
            this.startCopyButton.Click += new System.EventHandler(this.startCopyButton_Click);
            // 
            // progressContainer
            // 
            this.progressContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressContainer.Controls.Add(this.progressHeaderLabel);
            this.progressContainer.Controls.Add(this.progressBar);
            this.progressContainer.Controls.Add(this.progressLabel);
            this.progressContainer.Location = new System.Drawing.Point(26, 706);
            this.progressContainer.Name = "progressContainer";
            this.progressContainer.Size = new System.Drawing.Size(676, 69);
            this.progressContainer.TabIndex = 22;
            this.progressContainer.Visible = false;
            // 
            // progressHeaderLabel
            // 
            this.progressHeaderLabel.AutoSize = true;
            this.progressHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressHeaderLabel.Location = new System.Drawing.Point(3, 4);
            this.progressHeaderLabel.Name = "progressHeaderLabel";
            this.progressHeaderLabel.Size = new System.Drawing.Size(85, 15);
            this.progressHeaderLabel.TabIndex = 0;
            this.progressHeaderLabel.Text = "Copy Progress";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(233)))));
            this.progressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBar.Controls.Add(this.progressFill);
            this.progressBar.Location = new System.Drawing.Point(0, 22);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(676, 22);
            this.progressBar.TabIndex = 1;
            // 
            // progressFill
            // 
            this.progressFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(153)))), ((int)(((byte)(142)))));
            this.progressFill.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressFill.Location = new System.Drawing.Point(0, 0);
            this.progressFill.Name = "progressFill";
            this.progressFill.Size = new System.Drawing.Size(0, 20);
            this.progressFill.TabIndex = 0;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(3, 48);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(99, 13);
            this.progressLabel.TabIndex = 2;
            this.progressLabel.Text = "Preparing to copy...";
            // 
            // logContainer
            // 
            this.logContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logContainer.Controls.Add(this.logHeaderLabel);
            this.logContainer.Controls.Add(this.logOutputTextBox);
            this.logContainer.Location = new System.Drawing.Point(26, 784);
            this.logContainer.Name = "logContainer";
            this.logContainer.Size = new System.Drawing.Size(676, 173);
            this.logContainer.TabIndex = 23;
            this.logContainer.Visible = false;
            // 
            // logHeaderLabel
            // 
            this.logHeaderLabel.AutoSize = true;
            this.logHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHeaderLabel.Location = new System.Drawing.Point(3, 4);
            this.logHeaderLabel.Name = "logHeaderLabel";
            this.logHeaderLabel.Size = new System.Drawing.Size(57, 15);
            this.logHeaderLabel.TabIndex = 1;
            this.logHeaderLabel.Text = "Copy Log";
            // 
            // logOutputTextBox
            // 
            this.logOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutputTextBox.BackColor = System.Drawing.Color.Black;
            this.logOutputTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutputTextBox.ForeColor = System.Drawing.Color.Lime;
            this.logOutputTextBox.Location = new System.Drawing.Point(0, 22);
            this.logOutputTextBox.Multiline = true;
            this.logOutputTextBox.Name = "logOutputTextBox";
            this.logOutputTextBox.ReadOnly = true;
            this.logOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logOutputTextBox.Size = new System.Drawing.Size(676, 117);
            this.logOutputTextBox.TabIndex = 0;
            // 
            // statusPanel
            // 
            this.statusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusPanel.BackColor = System.Drawing.SystemColors.Control;
            this.statusPanel.BorderColor = System.Drawing.Color.Gray;
            this.statusPanel.BorderRadius = 10;
            this.statusPanel.BorderSize = 2;
            this.statusPanel.Controls.Add(this.statusLabel);
            this.statusPanel.Location = new System.Drawing.Point(26, 919);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(676, 43);
            this.statusPanel.TabIndex = 24;
            this.statusPanel.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(676, 43);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(784, 933);
            this.Controls.Add(this.mainContainer);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(17);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Robocopy File Copier";
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.filePatternGroup.ResumeLayout(false);
            this.filePatternGroup.PerformLayout();
            this.advancedOptions.ResumeLayout(false);
            this.advancedOptions.PerformLayout();
            this.progressContainer.ResumeLayout(false);
            this.progressContainer.PerformLayout();
            this.progressBar.ResumeLayout(false);
            this.logContainer.ResumeLayout(false);
            this.logContainer.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}