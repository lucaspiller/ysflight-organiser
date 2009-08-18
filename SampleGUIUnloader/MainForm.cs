using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleGUIUnloader
{
    public partial class MainForm : Form
    {
        YsfoWrapper ysfo;

        public MainForm()
        {
            ysfo = new YsfoWrapper();
            ysfo.AircraftListsChange += new EventHandler(Ysfo_AircraftListsChanged);
            InitializeComponent();
        }

        private bool Cleanup()
        {
            // prompt user to save changes
            var userResponse = MessageBox.Show("Save changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (userResponse)
            {
                case DialogResult.Cancel:
                    // cancel
                    return false;
                case DialogResult.Yes:
                    // save
                    ysfo.Cleanup(true);
                    break;
                case DialogResult.No:
                    // don't save
                    ysfo.Cleanup(false);
                    break;
            }

            return true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ysfo.Loaded() && !Cleanup())
            {
                return;
            }

            ysfo.Setup(tbxPath.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ysfo.Loaded() && !Cleanup())
            {
                e.Cancel = true;
            }
        }

        private void btnUnloadAddon_Click(object sender, EventArgs e)
        {
            if (lbxLoaded.SelectedItem == null)
                return;

            Ysfo.Core.AircraftAddon aircraft = (Ysfo.Core.AircraftAddon) lbxLoaded.SelectedItem;
            ysfo.UnloadAircraft(aircraft);
        }

        private void btnLoadAddon_Click(object sender, EventArgs e)
        {
            if (lbxUnloaded.SelectedItem == null)
                return;

            Ysfo.Core.AircraftAddon aircraft = (Ysfo.Core.AircraftAddon) lbxUnloaded.SelectedItem;
            ysfo.LoadAircraft(aircraft);
        }

        private void Ysfo_AircraftListsChanged(object sender, EventArgs e)
        {
            // clear items
            lbxLoaded.Items.Clear();
            lbxUnloaded.Items.Clear();

            // add new items
            if (ysfo.LoadedAircraft != null)
                lbxLoaded.Items.AddRange(ysfo.LoadedAircraft.ToArray());

            if (ysfo.UnloadedAircraft != null)
                lbxUnloaded.Items.AddRange(ysfo.UnloadedAircraft.ToArray());
        }
    }
}
