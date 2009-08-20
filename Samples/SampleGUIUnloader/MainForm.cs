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

            // bind to data
            lbxLoaded.DataSource = new BindingSource(ysfo, "LoadedAircraft");
            lbxUnloaded.DataSource = new BindingSource(ysfo, "UnloadedAircraft");

            lbxLoaded.ClearSelected();
            lbxUnloaded.ClearSelected();
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

            lbxUnloaded.ClearSelected();
        }

        private void btnLoadAddon_Click(object sender, EventArgs e)
        {
            if (lbxUnloaded.SelectedItem == null)
                return;

            Ysfo.Core.AircraftAddon aircraft = (Ysfo.Core.AircraftAddon) lbxUnloaded.SelectedItem;
            ysfo.LoadAircraft(aircraft);

            lbxLoaded.ClearSelected();
        }

        private void lbxUnloaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxUnloaded.SelectedItem != null)
            {
                // clear selection
                lbxLoaded.ClearSelected();
            }
        }

        private void lbxLoaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxLoaded.SelectedItem != null)
            {
                // clear selection
                lbxUnloaded.ClearSelected();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lbxLoaded.SelectedItem != null)
            {
                var selected = (Ysfo.Core.AircraftAddon) lbxLoaded.SelectedItem;
                int selectedIndex = lbxLoaded.SelectedIndex;

                ysfo.MoveUp(selected);

                lbxLoaded.SelectedIndex = selectedIndex - 1;
            }

            if (lbxUnloaded.SelectedItem != null)
            {
                var selected = (Ysfo.Core.AircraftAddon)lbxUnloaded.SelectedItem;
                int selectedIndex = lbxUnloaded.SelectedIndex;

                ysfo.MoveUp(selected);

                lbxUnloaded.SelectedIndex = selectedIndex - 1;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lbxLoaded.SelectedItem != null)
            {
                var selected = (Ysfo.Core.AircraftAddon)lbxLoaded.SelectedItem;
                int selectedIndex = lbxLoaded.SelectedIndex;

                ysfo.MoveDown(selected);

                lbxLoaded.SelectedIndex = selectedIndex + 1;
            }

            if (lbxUnloaded.SelectedItem != null)
            {
                var selected = (Ysfo.Core.AircraftAddon)lbxUnloaded.SelectedItem;
                int selectedIndex = lbxUnloaded.SelectedIndex;

                ysfo.MoveDown(selected);

                lbxUnloaded.SelectedIndex = selectedIndex + 1;
            }
        }
    }
}
