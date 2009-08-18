namespace SampleGUILister
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
            this.gbxPath = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.gbxAircraft = new System.Windows.Forms.GroupBox();
            this.lbxAircraft = new System.Windows.Forms.ListBox();
            this.gbxGround = new System.Windows.Forms.GroupBox();
            this.lbxGround = new System.Windows.Forms.ListBox();
            this.gbxScenery = new System.Windows.Forms.GroupBox();
            this.lbxScenery = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbxPath.SuspendLayout();
            this.gbxAircraft.SuspendLayout();
            this.gbxGround.SuspendLayout();
            this.gbxScenery.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPath
            // 
            this.gbxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPath.Controls.Add(this.btnLoad);
            this.gbxPath.Controls.Add(this.tbxPath);
            this.gbxPath.Location = new System.Drawing.Point(12, 12);
            this.gbxPath.Name = "gbxPath";
            this.gbxPath.Size = new System.Drawing.Size(568, 52);
            this.gbxPath.TabIndex = 0;
            this.gbxPath.TabStop = false;
            this.gbxPath.Text = "YsFlight Directory";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(487, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPath.Location = new System.Drawing.Point(6, 22);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(475, 20);
            this.tbxPath.TabIndex = 0;
            this.tbxPath.Text = "C:\\dev\\ysflight\\20090502";
            // 
            // gbxAircraft
            // 
            this.gbxAircraft.Controls.Add(this.lbxAircraft);
            this.gbxAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxAircraft.Location = new System.Drawing.Point(0, 0);
            this.gbxAircraft.Name = "gbxAircraft";
            this.gbxAircraft.Size = new System.Drawing.Size(189, 230);
            this.gbxAircraft.TabIndex = 1;
            this.gbxAircraft.TabStop = false;
            this.gbxAircraft.Text = "Aircraft Objects";
            // 
            // lbxAircraft
            // 
            this.lbxAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxAircraft.FormattingEnabled = true;
            this.lbxAircraft.Location = new System.Drawing.Point(3, 16);
            this.lbxAircraft.Name = "lbxAircraft";
            this.lbxAircraft.Size = new System.Drawing.Size(183, 199);
            this.lbxAircraft.TabIndex = 0;
            this.lbxAircraft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxAircraft_MouseDoubleClick);
            // 
            // gbxGround
            // 
            this.gbxGround.Controls.Add(this.lbxGround);
            this.gbxGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxGround.Location = new System.Drawing.Point(0, 0);
            this.gbxGround.Name = "gbxGround";
            this.gbxGround.Size = new System.Drawing.Size(187, 230);
            this.gbxGround.TabIndex = 2;
            this.gbxGround.TabStop = false;
            this.gbxGround.Text = "Ground Objects";
            // 
            // lbxGround
            // 
            this.lbxGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxGround.FormattingEnabled = true;
            this.lbxGround.Location = new System.Drawing.Point(3, 16);
            this.lbxGround.Name = "lbxGround";
            this.lbxGround.Size = new System.Drawing.Size(181, 199);
            this.lbxGround.TabIndex = 0;
            // 
            // gbxScenery
            // 
            this.gbxScenery.Controls.Add(this.lbxScenery);
            this.gbxScenery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxScenery.Location = new System.Drawing.Point(0, 0);
            this.gbxScenery.Name = "gbxScenery";
            this.gbxScenery.Size = new System.Drawing.Size(184, 230);
            this.gbxScenery.TabIndex = 3;
            this.gbxScenery.TabStop = false;
            this.gbxScenery.Text = "Scenery Objects";
            // 
            // lbxScenery
            // 
            this.lbxScenery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxScenery.FormattingEnabled = true;
            this.lbxScenery.Location = new System.Drawing.Point(3, 16);
            this.lbxScenery.Name = "lbxScenery";
            this.lbxScenery.Size = new System.Drawing.Size(178, 199);
            this.lbxScenery.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 71);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxAircraft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(568, 230);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbxGround);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbxScenery);
            this.splitContainer2.Size = new System.Drawing.Size(375, 230);
            this.splitContainer2.SplitterDistance = 187;
            this.splitContainer2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 313);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gbxPath);
            this.Name = "MainForm";
            this.Text = "Sample GUI Lister";
            this.gbxPath.ResumeLayout(false);
            this.gbxPath.PerformLayout();
            this.gbxAircraft.ResumeLayout(false);
            this.gbxGround.ResumeLayout(false);
            this.gbxScenery.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.GroupBox gbxAircraft;
        private System.Windows.Forms.ListBox lbxAircraft;
        private System.Windows.Forms.GroupBox gbxGround;
        private System.Windows.Forms.ListBox lbxGround;
        private System.Windows.Forms.GroupBox gbxScenery;
        private System.Windows.Forms.ListBox lbxScenery;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

