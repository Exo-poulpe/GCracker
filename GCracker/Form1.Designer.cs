﻿namespace GCracker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.attackToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbxArchivePath = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.grpBoxArchivePath = new System.Windows.Forms.GroupBox();
            this.grpAttack = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Types = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPasswordCurrent = new System.Windows.Forms.Label();
            this.lblPasswordSpeed = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCrackProgression = new System.Windows.Forms.Label();
            this.grpBoxTable = new System.Windows.Forms.GroupBox();
            this.lblPasswordNumber = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chkBoxMaxLength = new System.Windows.Forms.CheckBox();
            this.chkBoxAlpha2 = new System.Windows.Forms.RadioButton();
            this.chkBoxAlpha3 = new System.Windows.Forms.RadioButton();
            this.chkBoxAlpha1 = new System.Windows.Forms.RadioButton();
            this.grpBoxLog = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblLogsPath = new System.Windows.Forms.Label();
            this.tbxLogsPath = new System.Windows.Forms.TextBox();
            this.chkBoxLogs = new System.Windows.Forms.CheckBox();
            this.tbxWordlistPath = new System.Windows.Forms.TextBox();
            this.btnFindWordlist = new System.Windows.Forms.Button();
            this.grpWordList = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpBoxArchivePath.SuspendLayout();
            this.grpAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBoxTable.SuspendLayout();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpBoxLog.SuspendLayout();
            this.grpWordList.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.attackToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(584, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // attackToolStripMenuItem
            // 
            this.attackToolStripMenuItem.Items.AddRange(new object[] {
            "Zip",
            "Rar",
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-512"});
            this.attackToolStripMenuItem.Name = "attackToolStripMenuItem";
            this.attackToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.attackToolStripMenuItem.Text = "Attack";
            this.attackToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.AttackToolStripMenuItem_SelectedIndexChanged);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 86);
            this.panel1.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::GCracker.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(343, -7);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 95);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Image = global::GCracker.Properties.Resources.question;
            this.btnHelp.Location = new System.Drawing.Point(459, -7);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 95);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Image = global::GCracker.Properties.Resources.play_button;
            this.btnStart.Location = new System.Drawing.Point(125, -7);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 95);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Image = global::GCracker.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(236, -7);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 95);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Image = global::GCracker.Properties.Resources.folder64;
            this.btnOpen.Location = new System.Drawing.Point(9, -7);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 95);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // tbxArchivePath
            // 
            this.tbxArchivePath.Location = new System.Drawing.Point(15, 15);
            this.tbxArchivePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxArchivePath.Name = "tbxArchivePath";
            this.tbxArchivePath.Size = new System.Drawing.Size(225, 20);
            this.tbxArchivePath.TabIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "BruteForce",
            "Wordlist"});
            this.cmbType.Location = new System.Drawing.Point(10, 15);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(171, 21);
            this.cmbType.TabIndex = 5;
            // 
            // grpBoxArchivePath
            // 
            this.grpBoxArchivePath.Controls.Add(this.tbxArchivePath);
            this.grpBoxArchivePath.Location = new System.Drawing.Point(9, 115);
            this.grpBoxArchivePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxArchivePath.Name = "grpBoxArchivePath";
            this.grpBoxArchivePath.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxArchivePath.Size = new System.Drawing.Size(248, 39);
            this.grpBoxArchivePath.TabIndex = 6;
            this.grpBoxArchivePath.TabStop = false;
            this.grpBoxArchivePath.Text = "Path of archive";
            // 
            // grpAttack
            // 
            this.grpAttack.Controls.Add(this.cmbType);
            this.grpAttack.Location = new System.Drawing.Point(371, 115);
            this.grpAttack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAttack.Name = "grpAttack";
            this.grpAttack.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAttack.Size = new System.Drawing.Size(196, 39);
            this.grpAttack.TabIndex = 7;
            this.grpAttack.TabStop = false;
            this.grpAttack.Text = "Types d\'attack";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Types,
            this.Event,
            this.File});
            this.dataGridView1.Location = new System.Drawing.Point(9, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 122);
            this.dataGridView1.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Types
            // 
            this.Types.HeaderText = "Types";
            this.Types.Name = "Types";
            this.Types.ReadOnly = true;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            // 
            // File
            // 
            this.File.HeaderText = "Files";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // lblPasswordCurrent
            // 
            this.lblPasswordCurrent.AutoSize = true;
            this.lblPasswordCurrent.Location = new System.Drawing.Point(40, 323);
            this.lblPasswordCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordCurrent.Name = "lblPasswordCurrent";
            this.lblPasswordCurrent.Size = new System.Drawing.Size(98, 13);
            this.lblPasswordCurrent.TabIndex = 9;
            this.lblPasswordCurrent.Text = "Password current : ";
            // 
            // lblPasswordSpeed
            // 
            this.lblPasswordSpeed.AutoSize = true;
            this.lblPasswordSpeed.Location = new System.Drawing.Point(359, 323);
            this.lblPasswordSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordSpeed.Name = "lblPasswordSpeed";
            this.lblPasswordSpeed.Size = new System.Drawing.Size(94, 13);
            this.lblPasswordSpeed.TabIndex = 10;
            this.lblPasswordSpeed.Text = "Password speed : ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 371);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(568, 28);
            this.progressBar1.TabIndex = 11;
            // 
            // lblCrackProgression
            // 
            this.lblCrackProgression.AutoSize = true;
            this.lblCrackProgression.Location = new System.Drawing.Point(11, 353);
            this.lblCrackProgression.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrackProgression.Name = "lblCrackProgression";
            this.lblCrackProgression.Size = new System.Drawing.Size(90, 13);
            this.lblCrackProgression.TabIndex = 12;
            this.lblCrackProgression.Text = "Progress attack : ";
            // 
            // grpBoxTable
            // 
            this.grpBoxTable.Controls.Add(this.dataGridView1);
            this.grpBoxTable.Location = new System.Drawing.Point(0, 159);
            this.grpBoxTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxTable.Name = "grpBoxTable";
            this.grpBoxTable.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxTable.Size = new System.Drawing.Size(575, 150);
            this.grpBoxTable.TabIndex = 13;
            this.grpBoxTable.TabStop = false;
            this.grpBoxTable.Text = "Status table";
            // 
            // lblPasswordNumber
            // 
            this.lblPasswordNumber.AutoSize = true;
            this.lblPasswordNumber.Location = new System.Drawing.Point(359, 345);
            this.lblPasswordNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordNumber.Name = "lblPasswordNumber";
            this.lblPasswordNumber.Size = new System.Drawing.Size(100, 13);
            this.lblPasswordNumber.TabIndex = 14;
            this.lblPasswordNumber.Text = "Password number : ";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.numericUpDown1);
            this.grpSettings.Controls.Add(this.chkBoxMaxLength);
            this.grpSettings.Controls.Add(this.chkBoxAlpha2);
            this.grpSettings.Controls.Add(this.chkBoxAlpha3);
            this.grpSettings.Controls.Add(this.chkBoxAlpha1);
            this.grpSettings.Location = new System.Drawing.Point(599, 56);
            this.grpSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSettings.Size = new System.Drawing.Size(330, 173);
            this.grpSettings.TabIndex = 15;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(117, 37);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // chkBoxMaxLength
            // 
            this.chkBoxMaxLength.AutoSize = true;
            this.chkBoxMaxLength.Location = new System.Drawing.Point(18, 38);
            this.chkBoxMaxLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxMaxLength.Name = "chkBoxMaxLength";
            this.chkBoxMaxLength.Size = new System.Drawing.Size(106, 17);
            this.chkBoxMaxLength.TabIndex = 3;
            this.chkBoxMaxLength.Text = "Taille maximum : ";
            this.chkBoxMaxLength.UseVisualStyleBackColor = true;
            // 
            // chkBoxAlpha2
            // 
            this.chkBoxAlpha2.AutoSize = true;
            this.chkBoxAlpha2.Location = new System.Drawing.Point(19, 96);
            this.chkBoxAlpha2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxAlpha2.Name = "chkBoxAlpha2";
            this.chkBoxAlpha2.Size = new System.Drawing.Size(79, 17);
            this.chkBoxAlpha2.TabIndex = 2;
            this.chkBoxAlpha2.Text = "checkBox3";
            this.chkBoxAlpha2.UseVisualStyleBackColor = true;
            // 
            // chkBoxAlpha3
            // 
            this.chkBoxAlpha3.AutoSize = true;
            this.chkBoxAlpha3.Checked = true;
            this.chkBoxAlpha3.Location = new System.Drawing.Point(19, 118);
            this.chkBoxAlpha3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxAlpha3.Name = "chkBoxAlpha3";
            this.chkBoxAlpha3.Size = new System.Drawing.Size(79, 17);
            this.chkBoxAlpha3.TabIndex = 1;
            this.chkBoxAlpha3.TabStop = true;
            this.chkBoxAlpha3.Text = "checkBox2";
            this.chkBoxAlpha3.UseVisualStyleBackColor = true;
            // 
            // chkBoxAlpha1
            // 
            this.chkBoxAlpha1.AutoSize = true;
            this.chkBoxAlpha1.Location = new System.Drawing.Point(19, 74);
            this.chkBoxAlpha1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxAlpha1.Name = "chkBoxAlpha1";
            this.chkBoxAlpha1.Size = new System.Drawing.Size(79, 17);
            this.chkBoxAlpha1.TabIndex = 0;
            this.chkBoxAlpha1.Text = "checkBox1";
            this.chkBoxAlpha1.UseVisualStyleBackColor = true;
            // 
            // grpBoxLog
            // 
            this.grpBoxLog.Controls.Add(this.btnFind);
            this.grpBoxLog.Controls.Add(this.lblLogsPath);
            this.grpBoxLog.Controls.Add(this.tbxLogsPath);
            this.grpBoxLog.Controls.Add(this.chkBoxLogs);
            this.grpBoxLog.Location = new System.Drawing.Point(599, 232);
            this.grpBoxLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxLog.Name = "grpBoxLog";
            this.grpBoxLog.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBoxLog.Size = new System.Drawing.Size(330, 106);
            this.grpBoxLog.TabIndex = 16;
            this.grpBoxLog.TabStop = false;
            this.grpBoxLog.Text = "Logs";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(297, 72);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(32, 21);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "...";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // lblLogsPath
            // 
            this.lblLogsPath.AutoSize = true;
            this.lblLogsPath.Location = new System.Drawing.Point(20, 54);
            this.lblLogsPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogsPath.Name = "lblLogsPath";
            this.lblLogsPath.Size = new System.Drawing.Size(72, 13);
            this.lblLogsPath.TabIndex = 2;
            this.lblLogsPath.Text = "Path of logs : ";
            // 
            // tbxLogsPath
            // 
            this.tbxLogsPath.Location = new System.Drawing.Point(19, 73);
            this.tbxLogsPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxLogsPath.Name = "tbxLogsPath";
            this.tbxLogsPath.Size = new System.Drawing.Size(278, 20);
            this.tbxLogsPath.TabIndex = 1;
            // 
            // chkBoxLogs
            // 
            this.chkBoxLogs.AutoSize = true;
            this.chkBoxLogs.Location = new System.Drawing.Point(18, 27);
            this.chkBoxLogs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBoxLogs.Name = "chkBoxLogs";
            this.chkBoxLogs.Size = new System.Drawing.Size(87, 17);
            this.chkBoxLogs.TabIndex = 0;
            this.chkBoxLogs.Text = "Activate logs";
            this.chkBoxLogs.UseVisualStyleBackColor = true;
            // 
            // tbxWordlistPath
            // 
            this.tbxWordlistPath.Location = new System.Drawing.Point(16, 18);
            this.tbxWordlistPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxWordlistPath.Name = "tbxWordlistPath";
            this.tbxWordlistPath.Size = new System.Drawing.Size(279, 20);
            this.tbxWordlistPath.TabIndex = 17;
            // 
            // btnFindWordlist
            // 
            this.btnFindWordlist.Location = new System.Drawing.Point(295, 15);
            this.btnFindWordlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFindWordlist.Name = "btnFindWordlist";
            this.btnFindWordlist.Size = new System.Drawing.Size(32, 21);
            this.btnFindWordlist.TabIndex = 18;
            this.btnFindWordlist.Text = "...";
            this.btnFindWordlist.UseVisualStyleBackColor = true;
            // 
            // grpWordList
            // 
            this.grpWordList.Controls.Add(this.btnFindWordlist);
            this.grpWordList.Controls.Add(this.tbxWordlistPath);
            this.grpWordList.Location = new System.Drawing.Point(602, 347);
            this.grpWordList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWordList.Name = "grpWordList";
            this.grpWordList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpWordList.Size = new System.Drawing.Size(327, 51);
            this.grpWordList.TabIndex = 19;
            this.grpWordList.TabStop = false;
            this.grpWordList.Text = "Wordlist settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.grpWordList);
            this.Controls.Add(this.grpBoxLog);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.lblPasswordNumber);
            this.Controls.Add(this.grpBoxTable);
            this.Controls.Add(this.lblCrackProgression);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPasswordSpeed);
            this.Controls.Add(this.lblPasswordCurrent);
            this.Controls.Add(this.grpAttack);
            this.Controls.Add(this.grpBoxArchivePath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GCracker";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpBoxArchivePath.ResumeLayout(false);
            this.grpBoxArchivePath.PerformLayout();
            this.grpAttack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBoxTable.ResumeLayout(false);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpBoxLog.ResumeLayout(false);
            this.grpBoxLog.PerformLayout();
            this.grpWordList.ResumeLayout(false);
            this.grpWordList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox tbxArchivePath;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.GroupBox grpBoxArchivePath;
        private System.Windows.Forms.GroupBox grpAttack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPasswordCurrent;
        private System.Windows.Forms.Label lblPasswordSpeed;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCrackProgression;
        private System.Windows.Forms.GroupBox grpBoxTable;
        private System.Windows.Forms.Label lblPasswordNumber;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox chkBoxMaxLength;
        private System.Windows.Forms.RadioButton chkBoxAlpha2;
        private System.Windows.Forms.RadioButton chkBoxAlpha3;
        private System.Windows.Forms.RadioButton chkBoxAlpha1;
        private System.Windows.Forms.GroupBox grpBoxLog;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblLogsPath;
        private System.Windows.Forms.TextBox tbxLogsPath;
        private System.Windows.Forms.CheckBox chkBoxLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Types;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.TextBox tbxWordlistPath;
        private System.Windows.Forms.Button btnFindWordlist;
        private System.Windows.Forms.GroupBox grpWordList;
        private System.Windows.Forms.ToolStripComboBox attackToolStripMenuItem;
    }
}

