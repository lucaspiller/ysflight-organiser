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
            this.tpgObjects = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gbxObjectsLoaded = new System.Windows.Forms.GroupBox();
            this.lbxObjectsLoaded = new System.Windows.Forms.ListBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnObjectsLoad = new System.Windows.Forms.Button();
            this.btnObjectsUnload = new System.Windows.Forms.Button();
            this.btnObjectsDown = new System.Windows.Forms.Button();
            this.btnObjectsUp = new System.Windows.Forms.Button();
            this.gbxObjectsUnloaded = new System.Windows.Forms.GroupBox();
            this.lbxObjectsUnloaded = new System.Windows.Forms.ListBox();
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
            this.tpgObjects.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gbxObjectsLoaded.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.gbxObjectsUnloaded.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(392, 24);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 351);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(392, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tpgAircraft);
            this.tabControl.Controls.Add(this.tpgObjects);
            this.tabControl.Controls.Add(this.tpgMaps);
            this.tabControl.Controls.Add(this.tpgSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(392, 327);
            this.tabControl.TabIndex = 2;
            // 
            // tpgAircraft
            // 
            this.tpgAircraft.Controls.Add(this.splitContainer1);
            this.tpgAircraft.Location = new System.Drawing.Point(4, 25);
            this.tpgAircraft.Name = "tpgAircraft";
            this.tpgAircraft.Size = new System.Drawing.Size(384, 298);
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
            this.splitContainer1.Size = new System.Drawing.Size(384, 298);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbxAircraftLoaded
            // 
            this.gbxAircraftLoaded.Controls.Add(this.lbxAircraftLoaded);
            this.gbxAircraftLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAircraftLoaded.Location = new System.Drawing.Point(0, 0);
            this.gbxAircraftLoaded.Name = "gbxAircraftLoaded";
            this.gbxAircraftLoaded.Size = new System.Drawing.Size(156, 298);
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
            this.lbxAircraftLoaded.Size = new System.Drawing.Size(150, 277);
            this.lbxAircraftLoaded.TabIndex = 0;
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
            this.splitContainer2.Size = new System.Drawing.Size(224, 298);
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
            // 
            // btnAircraftUnload
            // 
            this.btnAircraftUnload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAircraftUnload.Location = new System.Drawing.Point(3, 206);
            this.btnAircraftUnload.Name = "btnAircraftUnload";
            this.btnAircraftUnload.Size = new System.Drawing.Size(54, 23);
            this.btnAircraftUnload.TabIndex = 2;
            this.btnAircraftUnload.Text = "Unload";
            this.btnAircraftUnload.UseVisualStyleBackColor = true;
            // 
            // btnAircraftDown
            // 
            this.btnAircraftDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAircraftDown.Location = new System.Drawing.Point(3, 245);
            this.btnAircraftDown.Name = "btnAircraftDown";
            this.btnAircraftDown.Size = new System.Drawing.Size(54, 23);
            this.btnAircraftDown.TabIndex = 1;
            this.btnAircraftDown.Text = "Down";
            this.btnAircraftDown.UseVisualStyleBackColor = true;
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
            // 
            // gbxAircraftUnloaded
            // 
            this.gbxAircraftUnloaded.Controls.Add(this.lbxAircraftUnloaded);
            this.gbxAircraftUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAircraftUnloaded.Location = new System.Drawing.Point(0, 0);
            this.gbxAircraftUnloaded.Name = "gbxAircraftUnloaded";
            this.gbxAircraftUnloaded.Size = new System.Drawing.Size(160, 298);
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
            this.lbxAircraftUnloaded.Size = new System.Drawing.Size(154, 277);
            this.lbxAircraftUnloaded.TabIndex = 0;
            // 
            // tpgObjects
            // 
            this.tpgObjects.Controls.Add(this.splitContainer3);
            this.tpgObjects.Location = new System.Drawing.Point(4, 25);
            this.tpgObjects.Name = "tpgObjects";
            this.tpgObjects.Size = new System.Drawing.Size(384, 298);
            this.tpgObjects.TabIndex = 1;
            this.tpgObjects.Text = "Objects";
            this.tpgObjects.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gbxObjectsLoaded);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(384, 298);
            this.splitContainer3.SplitterDistance = 156;
            this.splitContainer3.TabIndex = 3;
            // 
            // gbxObjectsLoaded
            // 
            this.gbxObjectsLoaded.Controls.Add(this.lbxObjectsLoaded);
            this.gbxObjectsLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxObjectsLoaded.Location = new System.Drawing.Point(0, 0);
            this.gbxObjectsLoaded.Name = "gbxObjectsLoaded";
            this.gbxObjectsLoaded.Size = new System.Drawing.Size(156, 298);
            this.gbxObjectsLoaded.TabIndex = 0;
            this.gbxObjectsLoaded.TabStop = false;
            this.gbxObjectsLoaded.Text = "Loaded Objects";
            // 
            // lbxObjectsLoaded
            // 
            this.lbxObjectsLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxObjectsLoaded.FormattingEnabled = true;
            this.lbxObjectsLoaded.Location = new System.Drawing.Point(3, 16);
            this.lbxObjectsLoaded.Name = "lbxObjectsLoaded";
            this.lbxObjectsLoaded.Size = new System.Drawing.Size(150, 277);
            this.lbxObjectsLoaded.TabIndex = 0;
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
            this.splitContainer4.Panel1.Controls.Add(this.btnObjectsLoad);
            this.splitContainer4.Panel1.Controls.Add(this.btnObjectsUnload);
            this.splitContainer4.Panel1.Controls.Add(this.btnObjectsDown);
            this.splitContainer4.Panel1.Controls.Add(this.btnObjectsUp);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.gbxObjectsUnloaded);
            this.splitContainer4.Size = new System.Drawing.Size(224, 298);
            this.splitContainer4.SplitterDistance = 60;
            this.splitContainer4.TabIndex = 0;
            // 
            // btnObjectsLoad
            // 
            this.btnObjectsLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObjectsLoad.Location = new System.Drawing.Point(3, 71);
            this.btnObjectsLoad.Name = "btnObjectsLoad";
            this.btnObjectsLoad.Size = new System.Drawing.Size(54, 23);
            this.btnObjectsLoad.TabIndex = 3;
            this.btnObjectsLoad.Text = "Load";
            this.btnObjectsLoad.UseVisualStyleBackColor = true;
            // 
            // btnObjectsUnload
            // 
            this.btnObjectsUnload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObjectsUnload.Location = new System.Drawing.Point(3, 206);
            this.btnObjectsUnload.Name = "btnObjectsUnload";
            this.btnObjectsUnload.Size = new System.Drawing.Size(54, 23);
            this.btnObjectsUnload.TabIndex = 2;
            this.btnObjectsUnload.Text = "Unload";
            this.btnObjectsUnload.UseVisualStyleBackColor = true;
            // 
            // btnObjectsDown
            // 
            this.btnObjectsDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObjectsDown.Location = new System.Drawing.Point(3, 245);
            this.btnObjectsDown.Name = "btnObjectsDown";
            this.btnObjectsDown.Size = new System.Drawing.Size(54, 23);
            this.btnObjectsDown.TabIndex = 1;
            this.btnObjectsDown.Text = "Down";
            this.btnObjectsDown.UseVisualStyleBackColor = true;
            // 
            // btnObjectsUp
            // 
            this.btnObjectsUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObjectsUp.Location = new System.Drawing.Point(3, 32);
            this.btnObjectsUp.Name = "btnObjectsUp";
            this.btnObjectsUp.Size = new System.Drawing.Size(54, 23);
            this.btnObjectsUp.TabIndex = 0;
            this.btnObjectsUp.Text = "Up";
            this.btnObjectsUp.UseVisualStyleBackColor = true;
            // 
            // gbxObjectsUnloaded
            // 
            this.gbxObjectsUnloaded.Controls.Add(this.lbxObjectsUnloaded);
            this.gbxObjectsUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxObjectsUnloaded.Location = new System.Drawing.Point(0, 0);
            this.gbxObjectsUnloaded.Name = "gbxObjectsUnloaded";
            this.gbxObjectsUnloaded.Size = new System.Drawing.Size(160, 298);
            this.gbxObjectsUnloaded.TabIndex = 2;
            this.gbxObjectsUnloaded.TabStop = false;
            this.gbxObjectsUnloaded.Text = "Unloaded Objects";
            // 
            // lbxObjectsUnloaded
            // 
            this.lbxObjectsUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxObjectsUnloaded.FormattingEnabled = true;
            this.lbxObjectsUnloaded.Location = new System.Drawing.Point(3, 16);
            this.lbxObjectsUnloaded.Name = "lbxObjectsUnloaded";
            this.lbxObjectsUnloaded.Size = new System.Drawing.Size(154, 277);
            this.lbxObjectsUnloaded.TabIndex = 0;
            // 
            // tpgMaps
            // 
            this.tpgMaps.Controls.Add(this.splitContainer5);
            this.tpgMaps.Location = new System.Drawing.Point(4, 25);
            this.tpgMaps.Name = "tpgMaps";
            this.tpgMaps.Size = new System.Drawing.Size(384, 298);
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
            this.splitContainer5.Size = new System.Drawing.Size(384, 298);
            this.splitContainer5.SplitterDistance = 156;
            this.splitContainer5.TabIndex = 4;
            // 
            // gbxMapsLoaded
            // 
            this.gbxMapsLoaded.Controls.Add(this.lbxMapsLoaded);
            this.gbxMapsLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMapsLoaded.Location = new System.Drawing.Point(0, 0);
            this.gbxMapsLoaded.Name = "gbxMapsLoaded";
            this.gbxMapsLoaded.Size = new System.Drawing.Size(156, 298);
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
            this.lbxMapsLoaded.Size = new System.Drawing.Size(150, 277);
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
            this.splitContainer6.Size = new System.Drawing.Size(224, 298);
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
            this.btnMapsUnload.Location = new System.Drawing.Point(3, 206);
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
            this.btnMapsDown.Location = new System.Drawing.Point(3, 245);
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
            this.gbxMapsUnloaded.Size = new System.Drawing.Size(160, 298);
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
            this.lbxMapsUnloaded.Size = new System.Drawing.Size(154, 277);
            this.lbxMapsUnloaded.TabIndex = 0;
            // 
            // tpgSettings
            // 
            this.tpgSettings.Controls.Add(this.groupBox1);
            this.tpgSettings.Controls.Add(this.btnSettingsSave);
            this.tpgSettings.Location = new System.Drawing.Point(4, 25);
            this.tpgSettings.Name = "tpgSettings";
            this.tpgSettings.Size = new System.Drawing.Size(384, 298);
            this.tpgSettings.TabIndex = 3;
            this.tpgSettings.Text = "Settings";
            this.tpgSettings.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(392, 373);
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
            this.tpgObjects.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.gbxObjectsLoaded.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.gbxObjectsUnloaded.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tpgObjects;
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
        private System.Windows.Forms.GroupBox gbxObjectsLoaded;
        private System.Windows.Forms.ListBox lbxObjectsLoaded;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnObjectsLoad;
        private System.Windows.Forms.Button btnObjectsUnload;
        private System.Windows.Forms.Button btnObjectsDown;
        private System.Windows.Forms.Button btnObjectsUp;
        private System.Windows.Forms.GroupBox gbxObjectsUnloaded;
        private System.Windows.Forms.ListBox lbxObjectsUnloaded;
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

