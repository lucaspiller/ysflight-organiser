namespace Ysfo.Samples.Unloader
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
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.gbxPath = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxLoaded = new System.Windows.Forms.GroupBox();
            this.btnUnloadAddon = new System.Windows.Forms.Button();
            this.lbxLoaded = new System.Windows.Forms.ListBox();
            this.gbxUnloaded = new System.Windows.Forms.GroupBox();
            this.btnLoadAddon = new System.Windows.Forms.Button();
            this.lbxUnloaded = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.gbxPath.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxLoaded.SuspendLayout();
            this.gbxUnloaded.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxPath
            // 
            this.tbxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPath.Location = new System.Drawing.Point(6, 22);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(280, 20);
            this.tbxPath.TabIndex = 0;
            this.tbxPath.Text = "C:\\dev\\ysflight\\20090502";
            // 
            // gbxPath
            // 
            this.gbxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPath.Controls.Add(this.btnLoad);
            this.gbxPath.Controls.Add(this.tbxPath);
            this.gbxPath.Location = new System.Drawing.Point(12, 12);
            this.gbxPath.Name = "gbxPath";
            this.gbxPath.Size = new System.Drawing.Size(373, 52);
            this.gbxPath.TabIndex = 1;
            this.gbxPath.TabStop = false;
            this.gbxPath.Text = "YsFlight Directory";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(292, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(10, 70);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxLoaded);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbxUnloaded);
            this.splitContainer1.Size = new System.Drawing.Size(375, 237);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbxLoaded
            // 
            this.gbxLoaded.Controls.Add(this.btnUp);
            this.gbxLoaded.Controls.Add(this.btnUnloadAddon);
            this.gbxLoaded.Controls.Add(this.lbxLoaded);
            this.gbxLoaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxLoaded.Location = new System.Drawing.Point(0, 0);
            this.gbxLoaded.Name = "gbxLoaded";
            this.gbxLoaded.Size = new System.Drawing.Size(187, 237);
            this.gbxLoaded.TabIndex = 2;
            this.gbxLoaded.TabStop = false;
            this.gbxLoaded.Text = "Loaded Aircraft";
            // 
            // btnUnloadAddon
            // 
            this.btnUnloadAddon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnloadAddon.Location = new System.Drawing.Point(106, 208);
            this.btnUnloadAddon.Name = "btnUnloadAddon";
            this.btnUnloadAddon.Size = new System.Drawing.Size(75, 23);
            this.btnUnloadAddon.TabIndex = 3;
            this.btnUnloadAddon.Text = "Unload >>";
            this.btnUnloadAddon.UseVisualStyleBackColor = true;
            this.btnUnloadAddon.Click += new System.EventHandler(this.btnUnloadAddon_Click);
            // 
            // lbxLoaded
            // 
            this.lbxLoaded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxLoaded.FormattingEnabled = true;
            this.lbxLoaded.Location = new System.Drawing.Point(3, 16);
            this.lbxLoaded.Name = "lbxLoaded";
            this.lbxLoaded.Size = new System.Drawing.Size(181, 186);
            this.lbxLoaded.TabIndex = 0;
            this.lbxLoaded.SelectedIndexChanged += new System.EventHandler(this.lbxLoaded_SelectedIndexChanged);
            // 
            // gbxUnloaded
            // 
            this.gbxUnloaded.Controls.Add(this.btnDown);
            this.gbxUnloaded.Controls.Add(this.btnLoadAddon);
            this.gbxUnloaded.Controls.Add(this.lbxUnloaded);
            this.gbxUnloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUnloaded.Location = new System.Drawing.Point(0, 0);
            this.gbxUnloaded.Name = "gbxUnloaded";
            this.gbxUnloaded.Size = new System.Drawing.Size(184, 237);
            this.gbxUnloaded.TabIndex = 3;
            this.gbxUnloaded.TabStop = false;
            this.gbxUnloaded.Text = "Unloaded Aircraft";
            // 
            // btnLoadAddon
            // 
            this.btnLoadAddon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadAddon.Location = new System.Drawing.Point(6, 208);
            this.btnLoadAddon.Name = "btnLoadAddon";
            this.btnLoadAddon.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAddon.TabIndex = 4;
            this.btnLoadAddon.Text = "<< Load";
            this.btnLoadAddon.UseVisualStyleBackColor = true;
            this.btnLoadAddon.Click += new System.EventHandler(this.btnLoadAddon_Click);
            // 
            // lbxUnloaded
            // 
            this.lbxUnloaded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxUnloaded.FormattingEnabled = true;
            this.lbxUnloaded.Location = new System.Drawing.Point(3, 16);
            this.lbxUnloaded.Name = "lbxUnloaded";
            this.lbxUnloaded.Size = new System.Drawing.Size(178, 186);
            this.lbxUnloaded.TabIndex = 0;
            this.lbxUnloaded.SelectedIndexChanged += new System.EventHandler(this.lbxUnloaded_SelectedIndexChanged);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.Location = new System.Drawing.Point(8, 208);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(44, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(134, 208);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(44, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 319);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gbxPath);
            this.Name = "MainForm";
            this.Text = "Sample GUI Unloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gbxPath.ResumeLayout(false);
            this.gbxPath.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbxLoaded.ResumeLayout(false);
            this.gbxUnloaded.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.GroupBox gbxPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbxLoaded;
        private System.Windows.Forms.ListBox lbxLoaded;
        private System.Windows.Forms.GroupBox gbxUnloaded;
        private System.Windows.Forms.ListBox lbxUnloaded;
        private System.Windows.Forms.Button btnUnloadAddon;
        private System.Windows.Forms.Button btnLoadAddon;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}

