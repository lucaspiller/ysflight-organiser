namespace Ysfo.App
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mitExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpgAircraft = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxAircraftLoaded = new System.Windows.Forms.GroupBox();
            this.lbxAircraftLoaded = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAircraftLoad = new System.Windows.Forms.Button();
            this.btnAircraftUnload = new System.Windows.Forms.Button();
            this.btnAircraftDown = new System.Windows.Forms.Button();
            this.btnAircraftUp = new System.Windows.Forms.Button();
            this.gbxAircraftUnloaded = new System.Windows.Forms.GroupBox();
            this.lbxAircraftUnloaded = new System.Windows.Forms.ListBox();
            this.tpgGround = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gbxGroundLoaded = new System.Windows.Forms.GroupBox();
            this.lbxGroundLoaded = new System.Windows.Forms.ListBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnGroundLoad = new System.Windows.Forms.Button();
            this.btnGroundUnload = new System.Windows.Forms.Button();
            this.btnGroundDown = new System.Windows.Forms.Button();
            this.btnGroundUp = new System.Windows.Forms.Button();
            this.gbxGroundUnloaded = new System.Windows.Forms.GroupBox();
            this.lbxGroundUnloaded = new System.Windows.Forms.ListBox();
            this.tpgMaps = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.gbxMapsLoaded = new System.Windows.Forms.GroupBox();
            this.lbxMapsLoaded = new System.Windows.Forms.ListBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.btnMapsLoad = new System.Windows.Forms.Button();
            this.btnMapsUnload = new System.Windows.Forms.Button();
            this.btnMapsDown = new System.Windows.Forms.Button();
            this.btnMapsUp = new System.Windows.Forms.Button();
            this.gbxMapsUnloaded = new System.Windows.Forms.GroupBox();
            this.lbxMapsUnloaded = new System.Windows.Forms.ListBox();
            this.tpgSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSettingsPath = new System.Windows.Forms.TextBox();
            this.btnSettingsBrowse = new System.Windows.Forms.Button();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.diaSettingsBrowseYsPath = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpgAircraft.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxAircraftLoaded.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbxAircraftUnloaded.SuspendLayout();
            this.tpgGround.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gbxGroundLoaded.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gbxGroundUnloaded.SuspendLayout();
            this.tpgMaps.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.gbxMapsLoaded.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.gbxMapsUnloaded.SuspendLayout();
            this.tpgSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(390, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mitFile
            // 
            this.mitFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitExit});
            this.mitFile.Name = "mitFile";
            this.mitFile.Size = new System.Drawing.Size(35, 20);
            this.mitFile.Text = "&File";
            // 
            // mitExit
            // 
            this.mitExit.Name = "mitExit";
            this.mitExit.Size = new System.Drawing.Size(103, 22);
            this.mitExit.Text = "E&xit";
            this.mitExit.Click += new System.EventHandler(this.mitExit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 349);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(390, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(375, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tpgAircraft);
            this.tabControl.Controls.Add(this.tpgGround);
            this.tabControl.Controls.Add(this.tpgMaps);
            this.tabControl.Controls.Add(this.tpgSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(390, 325);
            this.tabControl.TabIndex = 2;
            // 
            // tpgAircraft
            // 
            this.tpgAircraft.Controls.Add(this.splitContainer1);
            this.tpgAircraft.Location = new System.Drawing.Point(4, 25);
            this.tpgAircraft.Name = "tpgAircraft";
            this.tpgAircraft.Size = new System.Drawing.Size(382, 296);
            this.tpgAircraft.TabIndex = 0;
            this.tpgAircraft.Text = "Aircraft";
            this.tpgAircraft.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxAircraftLoaded);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(382, 296);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbxAircraftLoaded
            // 
            this.gbxAircraftLoaded.Controls.Add(this.lbxAircraftLoaded);
            this.gbxAircraftLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAircraftLoaded.Location = new System.Drawing.Point(0, 0);
            this.gbxAircraftLoaded.Name = "gbxAircraftLoaded";
            this.gbxAircraftLoaded.Size = new System.Drawing.Size(155, 296);
            this.gbxAircraftLoaded.TabIndex = 0;
            this.gbxAircraftLoaded.TabStop = false;
            this.gbxAircraftLoaded.Text = "Loaded Aircraft";
            // 
            // lbxAircraftLoaded
            // 
            this.lbxAircraftLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAircraftLoaded.FormattingEnabled = true;
            this.lbxAircraftLoaded.Location = new System.Drawing.Point(3, 16);
            this.lbxAircraftLoaded.Name = "lbxAircraftLoaded";
            this.lbxAircraftLoaded.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAircraftLoaded.Size = new System.Drawing.Size(149, 277);
            this.lbxAircraftLoaded.TabIndex = 0;
            this.lbxAircraftLoaded.SelectedIndexChanged += new System.EventHandler(this.lbxAircraftLoaded_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnAircraftLoad);
            this.splitContainer2.Panel1.Controls.Add(this.btnAircraftUnload);
            this.splitContainer2.Panel1.Controls.Add(this.btnAircraftDown);
            this.splitContainer2.Panel1.Controls.Add(this.btnAircraftUp);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbxAircraftUnloaded);
            this.splitContainer2.Size = new System.Drawing.Size(223, 296);
            this.splitContainer2.SplitterDistance = 60;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAircraftLoad
            // 
            this.btnAircraftLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAircraftLoad.Location = new System.Drawing.Point(3, 71);
            this.btnAircraftLoad.Name = "btnAircraftLoad";
            this.btnAircraftLoad.Size = new System.Drawing.Size(54, 23);
            this.btnAircraftLoad.TabIndex = 3;
            this.btnAircraftLoad.Text = "Load";
            this.btnAircraftLoad.UseVisualStyleBackColor = true;
            this.btnAircraftLoad.Click += new System.EventHandler(this.btnAircraftLoad_Click);
            // 
            // btnAircraftUnload
            // 
            this.btnAircraftUnload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAircraftUnload.Location = new System.Drawing.Point(3, 204);
            this.btnAircraftUnload.Name = "btnAircraftUnload";
            this.btnAircraftUnload.Size = new System.Drawing.Size(54, 23);
            this.btnAircraftUnload.TabIndex = 2;
            this.btnAircraftUnload.Text = "Unload";
            this.btnAircraftUnload.UseVisualStyleBackColor = true;
            this.btnAircraftUnload.Click += new System.EventHandler(this.btnAircraftUnload_Click);
            // 
            // btnAircraftDown
            // 
            this.btnAircraftDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAircraftDown.Location = new System.Drawing.Point(3, 243);
            this.btnAircraftDown.Name = "btnAircraftDown";
            this.btnAircraftDown.Size = new System.Drawing.Size(54, 23);
            this.btnAircraftDown.TabIndex = 1;
            this.btnAircraftDown.Text = "Down";
            this.btnAircraftDown.UseVisualStyleBackColor = true;
            this.btnAircraftDown.Click += new System.EventHandler(this.btnAircraftDown_Click);
            // 
            // btnAircraftUp
            // 
            this.btnAircraftUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAircraftUp.Location = new System.Drawing.Point(3, 32);
            this.btnAircraftUp.Name = "btnAircraftUp";
            this.btnAircraftUp.Size = new System.Drawing.Size(54, 23);
            this.btnAircraftUp.TabIndex = 0;
            this.btnAircraftUp.Text = "Up";
            this.btnAircraftUp.UseVisualStyleBackColor = true;
            this.btnAircraftUp.Click += new System.EventHandler(this.btnAircraftUp_Click);
            // 
            // gbxAircraftUnloaded
            // 
            this.gbxAircraftUnloaded.Controls.Add(this.lbxAircraftUnloaded);
            this.gbxAircraftUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAircraftUnloaded.Location = new System.Drawing.Point(0, 0);
            this.gbxAircraftUnloaded.Name = "gbxAircraftUnloaded";
            this.gbxAircraftUnloaded.Size = new System.Drawing.Size(159, 296);
            this.gbxAircraftUnloaded.TabIndex = 2;
            this.gbxAircraftUnloaded.TabStop = false;
            this.gbxAircraftUnloaded.Text = "Unloaded Aircraft";
            // 
            // lbxAircraftUnloaded
            // 
            this.lbxAircraftUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAircraftUnloaded.FormattingEnabled = true;
            this.lbxAircraftUnloaded.Location = new System.Drawing.Point(3, 16);
            this.lbxAircraftUnloaded.Name = "lbxAircraftUnloaded";
            this.lbxAircraftUnloaded.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAircraftUnloaded.Size = new System.Drawing.Size(153, 277);
            this.lbxAircraftUnloaded.TabIndex = 0;
            this.lbxAircraftUnloaded.SelectedIndexChanged += new System.EventHandler(this.lbxAircraftUnloaded_SelectedIndexChanged);
            // 
            // tpgGround
            // 
            this.tpgGround.Controls.Add(this.splitContainer3);
            this.tpgGround.Location = new System.Drawing.Point(4, 25);
            this.tpgGround.Name = "tpgGround";
            this.tpgGround.Size = new System.Drawing.Size(382, 296);
            this.tpgGround.TabIndex = 1;
            this.tpgGround.Text = "Ground";
            this.tpgGround.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gbxGroundLoaded);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(382, 296);
            this.splitContainer3.SplitterDistance = 155;
            this.splitContainer3.TabIndex = 3;
            // 
            // gbxGroundLoaded
            // 
            this.gbxGroundLoaded.Controls.Add(this.lbxGroundLoaded);
            this.gbxGroundLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGroundLoaded.Location = new System.Drawing.Point(0, 0);
            this.gbxGroundLoaded.Name = "gbxGroundLoaded";
            this.gbxGroundLoaded.Size = new System.Drawing.Size(155, 296);
            this.gbxGroundLoaded.TabIndex = 0;
            this.gbxGroundLoaded.TabStop = false;
            this.gbxGroundLoaded.Text = "Loaded Ground";
            // 
            // lbxGroundLoaded
            // 
            this.lbxGroundLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxGroundLoaded.FormattingEnabled = true;
            this.lbxGroundLoaded.Location = new System.Drawing.Point(3, 16);
            this.lbxGroundLoaded.Name = "lbxGroundLoaded";
            this.lbxGroundLoaded.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxGroundLoaded.Size = new System.Drawing.Size(149, 277);
            this.lbxGroundLoaded.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnGroundLoad);
            this.splitContainer4.Panel1.Controls.Add(this.btnGroundUnload);
            this.splitContainer4.Panel1.Controls.Add(this.btnGroundDown);
            this.splitContainer4.Panel1.Controls.Add(this.btnGroundUp);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.gbxGroundUnloaded);
            this.splitContainer4.Size = new System.Drawing.Size(223, 296);
            this.splitContainer4.SplitterDistance = 60;
            this.splitContainer4.TabIndex = 0;
            // 
            // btnGroundLoad
            // 
            this.btnGroundLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroundLoad.Location = new System.Drawing.Point(3, 71);
            this.btnGroundLoad.Name = "btnGroundLoad";
            this.btnGroundLoad.Size = new System.Drawing.Size(54, 23);
            this.btnGroundLoad.TabIndex = 3;
            this.btnGroundLoad.Text = "Load";
            this.btnGroundLoad.UseVisualStyleBackColor = true;
            // 
            // btnGroundUnload
            // 
            this.btnGroundUnload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroundUnload.Location = new System.Drawing.Point(3, 204);
            this.btnGroundUnload.Name = "btnGroundUnload";
            this.btnGroundUnload.Size = new System.Drawing.Size(54, 23);
            this.btnGroundUnload.TabIndex = 2;
            this.btnGroundUnload.Text = "Unload";
            this.btnGroundUnload.UseVisualStyleBackColor = true;
            // 
            // btnGroundDown
            // 
            this.btnGroundDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroundDown.Location = new System.Drawing.Point(3, 243);
            this.btnGroundDown.Name = "btnGroundDown";
            this.btnGroundDown.Size = new System.Drawing.Size(54, 23);
            this.btnGroundDown.TabIndex = 1;
            this.btnGroundDown.Text = "Down";
            this.btnGroundDown.UseVisualStyleBackColor = true;
            // 
            // btnGroundUp
            // 
            this.btnGroundUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroundUp.Location = new System.Drawing.Point(3, 32);
            this.btnGroundUp.Name = "btnGroundUp";
            this.btnGroundUp.Size = new System.Drawing.Size(54, 23);
            this.btnGroundUp.TabIndex = 0;
            this.btnGroundUp.Text = "Up";
            this.btnGroundUp.UseVisualStyleBackColor = true;
            // 
            // gbxGroundUnloaded
            // 
            this.gbxGroundUnloaded.Controls.Add(this.lbxGroundUnloaded);
            this.gbxGroundUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGroundUnloaded.Location = new System.Drawing.Point(0, 0);
            this.gbxGroundUnloaded.Name = "gbxGroundUnloaded";
            this.gbxGroundUnloaded.Size = new System.Drawing.Size(159, 296);
            this.gbxGroundUnloaded.TabIndex = 2;
            this.gbxGroundUnloaded.TabStop = false;
            this.gbxGroundUnloaded.Text = "Unloaded Ground";
            // 
            // lbxGroundUnloaded
            // 
            this.lbxGroundUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxGroundUnloaded.FormattingEnabled = true;
            this.lbxGroundUnloaded.Location = new System.Drawing.Point(3, 16);
            this.lbxGroundUnloaded.Name = "lbxGroundUnloaded";
            this.lbxGroundUnloaded.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxGroundUnloaded.Size = new System.Drawing.Size(153, 277);
            this.lbxGroundUnloaded.TabIndex = 0;
            // 
            // tpgMaps
            // 
            this.tpgMaps.Controls.Add(this.splitContainer5);
            this.tpgMaps.Location = new System.Drawing.Point(4, 25);
            this.tpgMaps.Name = "tpgMaps";
            this.tpgMaps.Size = new System.Drawing.Size(382, 296);
            this.tpgMaps.TabIndex = 4;
            this.tpgMaps.Text = "Maps";
            this.tpgMaps.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.gbxMapsLoaded);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(382, 296);
            this.splitContainer5.SplitterDistance = 155;
            this.splitContainer5.TabIndex = 4;
            // 
            // gbxMapsLoaded
            // 
            this.gbxMapsLoaded.Controls.Add(this.lbxMapsLoaded);
            this.gbxMapsLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMapsLoaded.Location = new System.Drawing.Point(0, 0);
            this.gbxMapsLoaded.Name = "gbxMapsLoaded";
            this.gbxMapsLoaded.Size = new System.Drawing.Size(155, 296);
            this.gbxMapsLoaded.TabIndex = 0;
            this.gbxMapsLoaded.TabStop = false;
            this.gbxMapsLoaded.Text = "Loaded Maps";
            // 
            // lbxMapsLoaded
            // 
            this.lbxMapsLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMapsLoaded.FormattingEnabled = true;
            this.lbxMapsLoaded.Location = new System.Drawing.Point(3, 16);
            this.lbxMapsLoaded.Name = "lbxMapsLoaded";
            this.lbxMapsLoaded.Size = new System.Drawing.Size(149, 277);
            this.lbxMapsLoaded.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.btnMapsLoad);
            this.splitContainer6.Panel1.Controls.Add(this.btnMapsUnload);
            this.splitContainer6.Panel1.Controls.Add(this.btnMapsDown);
            this.splitContainer6.Panel1.Controls.Add(this.btnMapsUp);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.gbxMapsUnloaded);
            this.splitContainer6.Size = new System.Drawing.Size(223, 296);
            this.splitContainer6.SplitterDistance = 60;
            this.splitContainer6.TabIndex = 0;
            // 
            // btnMapsLoad
            // 
            this.btnMapsLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapsLoad.Location = new System.Drawing.Point(3, 71);
            this.btnMapsLoad.Name = "btnMapsLoad";
            this.btnMapsLoad.Size = new System.Drawing.Size(54, 23);
            this.btnMapsLoad.TabIndex = 3;
            this.btnMapsLoad.Text = "Load";
            this.btnMapsLoad.UseVisualStyleBackColor = true;
            // 
            // btnMapsUnload
            // 
            this.btnMapsUnload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapsUnload.Location = new System.Drawing.Point(3, 204);
            this.btnMapsUnload.Name = "btnMapsUnload";
            this.btnMapsUnload.Size = new System.Drawing.Size(54, 23);
            this.btnMapsUnload.TabIndex = 2;
            this.btnMapsUnload.Text = "Unload";
            this.btnMapsUnload.UseVisualStyleBackColor = true;
            // 
            // btnMapsDown
            // 
            this.btnMapsDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapsDown.Location = new System.Drawing.Point(3, 243);
            this.btnMapsDown.Name = "btnMapsDown";
            this.btnMapsDown.Size = new System.Drawing.Size(54, 23);
            this.btnMapsDown.TabIndex = 1;
            this.btnMapsDown.Text = "Down";
            this.btnMapsDown.UseVisualStyleBackColor = true;
            // 
            // btnMapsUp
            // 
            this.btnMapsUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapsUp.Location = new System.Drawing.Point(3, 32);
            this.btnMapsUp.Name = "btnMapsUp";
            this.btnMapsUp.Size = new System.Drawing.Size(54, 23);
            this.btnMapsUp.TabIndex = 0;
            this.btnMapsUp.Text = "Up";
            this.btnMapsUp.UseVisualStyleBackColor = true;
            // 
            // gbxMapsUnloaded
            // 
            this.gbxMapsUnloaded.Controls.Add(this.lbxMapsUnloaded);
            this.gbxMapsUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMapsUnloaded.Location = new System.Drawing.Point(0, 0);
            this.gbxMapsUnloaded.Name = "gbxMapsUnloaded";
            this.gbxMapsUnloaded.Size = new System.Drawing.Size(159, 296);
            this.gbxMapsUnloaded.TabIndex = 2;
            this.gbxMapsUnloaded.TabStop = false;
            this.gbxMapsUnloaded.Text = "Unloaded Maps";
            // 
            // lbxMapsUnloaded
            // 
            this.lbxMapsUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxMapsUnloaded.FormattingEnabled = true;
            this.lbxMapsUnloaded.Location = new System.Drawing.Point(3, 16);
            this.lbxMapsUnloaded.Name = "lbxMapsUnloaded";
            this.lbxMapsUnloaded.Size = new System.Drawing.Size(153, 277);
            this.lbxMapsUnloaded.TabIndex = 0;
            // 
            // tpgSettings
            // 
            this.tpgSettings.Controls.Add(this.groupBox1);
            this.tpgSettings.Controls.Add(this.btnSettingsSave);
            this.tpgSettings.Location = new System.Drawing.Point(4, 25);
            this.tpgSettings.Name = "tpgSettings";
            this.tpgSettings.Size = new System.Drawing.Size(382, 296);
            this.tpgSettings.TabIndex = 3;
            this.tpgSettings.Text = "Settings";
            this.tpgSettings.UseVisualStyleBackColor = true;
            this.tpgSettings.Enter += new System.EventHandler(this.tpgSettings_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxSettingsPath);
            this.groupBox1.Controls.Add(this.btnSettingsBrowse);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YsFlight Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installation directory:";
            // 
            // tbxSettingsPath
            // 
            this.tbxSettingsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSettingsPath.Location = new System.Drawing.Point(9, 32);
            this.tbxSettingsPath.Name = "tbxSettingsPath";
            this.tbxSettingsPath.Size = new System.Drawing.Size(272, 20);
            this.tbxSettingsPath.TabIndex = 1;
            // 
            // btnSettingsBrowse
            // 
            this.btnSettingsBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsBrowse.Location = new System.Drawing.Point(287, 30);
            this.btnSettingsBrowse.Name = "btnSettingsBrowse";
            this.btnSettingsBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsBrowse.TabIndex = 2;
            this.btnSettingsBrowse.Text = "Browse";
            this.btnSettingsBrowse.UseVisualStyleBackColor = true;
            this.btnSettingsBrowse.Click += new System.EventHandler(this.btnSettingsBrowse_Click);
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsSave.Location = new System.Drawing.Point(301, 272);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsSave.TabIndex = 3;
            this.btnSettingsSave.Text = "Save";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // diaSettingsBrowseYsPath
            // 
            this.diaSettingsBrowseYsPath.Description = "Select the root directory of your YsFlight installation.";
            this.diaSettingsBrowseYsPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.diaSettingsBrowseYsPath.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 371);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpgAircraft.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbxAircraftLoaded.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.gbxAircraftUnloaded.ResumeLayout(false);
            this.tpgGround.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.gbxGroundLoaded.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.gbxGroundUnloaded.ResumeLayout(false);
            this.tpgMaps.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            this.gbxMapsLoaded.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            this.gbxMapsUnloaded.ResumeLayout(false);
            this.tpgSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mitFile;
        private System.Windows.Forms.ToolStripMenuItem mitExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgAircraft;
        private System.Windows.Forms.TabPage tpgGround;
        private System.Windows.Forms.TabPage tpgSettings;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbxAircraftLoaded;
        private System.Windows.Forms.ListBox lbxAircraftLoaded;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnAircraftLoad;
        private System.Windows.Forms.Button btnAircraftUnload;
        private System.Windows.Forms.Button btnAircraftDown;
        private System.Windows.Forms.Button btnAircraftUp;
        private System.Windows.Forms.GroupBox gbxAircraftUnloaded;
        private System.Windows.Forms.ListBox lbxAircraftUnloaded;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gbxGroundLoaded;
        private System.Windows.Forms.ListBox lbxGroundLoaded;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnGroundLoad;
        private System.Windows.Forms.Button btnGroundUnload;
        private System.Windows.Forms.Button btnGroundDown;
        private System.Windows.Forms.Button btnGroundUp;
        private System.Windows.Forms.GroupBox gbxGroundUnloaded;
        private System.Windows.Forms.ListBox lbxGroundUnloaded;
        private System.Windows.Forms.TabPage tpgMaps;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox gbxMapsLoaded;
        private System.Windows.Forms.ListBox lbxMapsLoaded;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button btnMapsLoad;
        private System.Windows.Forms.Button btnMapsUnload;
        private System.Windows.Forms.Button btnMapsDown;
        private System.Windows.Forms.Button btnMapsUp;
        private System.Windows.Forms.GroupBox gbxMapsUnloaded;
        private System.Windows.Forms.ListBox lbxMapsUnloaded;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Button btnSettingsBrowse;
        private System.Windows.Forms.TextBox tbxSettingsPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog diaSettingsBrowseYsPath;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

