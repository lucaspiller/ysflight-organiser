using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ysfo.App
{
    public partial class MainForm : Form
    {
        YsfoWrapper _ysfo;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                _ysfo.Setup();

                // enable tabs
                tpgAircraft.Enabled = true;
                tpgGround.Enabled = true;
                tpgScenery.Enabled = true;

                // reset bindings
                lbxAircraftLoaded.DataSource = new BindingSource(_ysfo, "LoadedAircraft");
                lbxAircraftLoaded.ClearSelected();
                lbxAircraftUnloaded.DataSource = new BindingSource(_ysfo, "UnloadedAircraft");
                lbxAircraftUnloaded.ClearSelected();

                lbxGroundLoaded.DataSource = new BindingSource(_ysfo, "LoadedGround");
                lbxGroundLoaded.ClearSelected();
                lbxGroundUnloaded.DataSource = new BindingSource(_ysfo, "UnloadedGround");
                lbxGroundUnloaded.ClearSelected();

                lbxSceneryLoaded.DataSource = new BindingSource(_ysfo, "LoadedScenery");
                lbxSceneryLoaded.ClearSelected();
                lbxSceneryUnloaded.DataSource = new BindingSource(_ysfo, "UnloadedScenery");
                lbxSceneryUnloaded.ClearSelected();
            }
            catch (YsfoWrapper.YsfoPathInvalidException)
            {
                // change tabs
                tpgAircraft.Enabled = false;
                tpgGround.Enabled = false;
                tpgScenery.Enabled = false;
                tabControl.SelectedTab = tpgSettings;

                MessageBox.Show("The path to your YsFlight directory is invalid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        #region Aircraft

        private void lbxAircraftUnloaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (lbxAircraftUnloaded.SelectedItem != null)
            {
                lbxAircraftLoaded.ClearSelected();

                // buttons
                btnAircraftLoad.Enabled = true;
                btnAircraftUnload.Enabled = false;

                // status
                if (lbxAircraftUnloaded.SelectedItems.Count == 1)
                {
                    var aircraft = (Ysfo.Core.AircraftAddon)lbxAircraftUnloaded.SelectedItem;

                    lblStatus.Text = aircraft.NamePretty + " - Category: " + aircraft.CategoryPretty;
                }
                else
                {
                    lblStatus.Text = lbxAircraftUnloaded.SelectedItems.Count + " items selected";
                }
            }
        }

        private void lbxAircraftLoaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (lbxAircraftLoaded.SelectedItem != null)
            {
                lbxAircraftUnloaded.ClearSelected();

                // buttons
                btnAircraftLoad.Enabled = false;
                btnAircraftUnload.Enabled = true;

                // status
                if (lbxAircraftLoaded.SelectedItems.Count == 1)
                {
                    var aircraft = (Ysfo.Core.AircraftAddon) lbxAircraftLoaded.SelectedItem;

                    lblStatus.Text = aircraft.NamePretty + " - Category: " + aircraft.CategoryPretty;
                }
                else
                {
                    lblStatus.Text = lbxAircraftLoaded.SelectedItems.Count + " items selected";
                }
            }
        }

        private void btnAircraftUp_Click(object sender, EventArgs e)
        {
            if (lbxAircraftLoaded.SelectedItems.Count > 0)
            {
                // loaded
                for (int i = 1; i < lbxAircraftLoaded.Items.Count; i++)
                {
                    // if selected
                    if (lbxAircraftLoaded.GetSelected(i))
                    {
                        _ysfo.LoadedAircraft.MoveItem(i, Extensions.MoveDirection.Up);

                        // update selection
                        lbxAircraftLoaded.SetSelected(i - 1, true);
                        lbxAircraftLoaded.SetSelected(i, false);
                    }
                }
            }

            if (lbxAircraftUnloaded.SelectedItems.Count > 0)
            {
                // unloaded
                for (int i = 1; i < lbxAircraftUnloaded.Items.Count; i++)
                {
                    // if selected
                    if (lbxAircraftUnloaded.GetSelected(i))
                    {
                        _ysfo.UnloadedAircraft.MoveItem(i, Extensions.MoveDirection.Up);

                        // update selection
                        lbxAircraftUnloaded.SetSelected(i - 1, true);
                        lbxAircraftUnloaded.SetSelected(i, false);
                    }
                }
            }
        }

        private void btnAircraftDown_Click(object sender, EventArgs e)
        {
            if (lbxAircraftLoaded.SelectedItems.Count > 0)
            {
                // loaded
                for (int i = lbxAircraftLoaded.Items.Count - 1; i > 1;  i--)
                {
                    // if selected
                    if (lbxAircraftLoaded.GetSelected(i))
                    {
                        _ysfo.LoadedAircraft.MoveItem(i, Extensions.MoveDirection.Down);

                        // update selection
                        lbxAircraftLoaded.SetSelected(i + 1, true);
                        lbxAircraftLoaded.SetSelected(i, false);
                    }
                }
            }

            if (lbxAircraftUnloaded.SelectedItems.Count > 0)
            {
                // unloaded
                for (int i = lbxAircraftUnloaded.Items.Count - 2; i >= 0; i--)
                {
                    // if selected
                    if (lbxAircraftUnloaded.GetSelected(i))
                    {
                        _ysfo.UnloadedAircraft.MoveItem(i, Extensions.MoveDirection.Down);

                        // update selection
                        lbxAircraftUnloaded.SetSelected(i + 1, true);
                        lbxAircraftUnloaded.SetSelected(i, false);
                    }
                }
            }
        }

        private void btnAircraftLoad_Click(object sender, EventArgs e)
        {
            BeginAircraftTransaction();

            ICollection<Ysfo.Core.AircraftAddon> items = lbxAircraftUnloaded.SelectedItems.Cast<Ysfo.Core.AircraftAddon>().ToList();

            // move
            items.ForEach(a =>
            {
                if (_ysfo.UnloadedAircraft.Remove(a))
                {
                    _ysfo.LoadedAircraft.Add(a);
                }
            });

            EndAircraftTransaction();

            // clear selection
            lbxAircraftUnloaded.ClearSelected();
            lbxAircraftLoaded.ClearSelected();

            // set items as selected
            for (int i = lbxAircraftLoaded.Items.Count - 1; i > (lbxAircraftLoaded.Items.Count - 1) - items.Count; i--)
            {
                lbxAircraftLoaded.SetSelected(i, true);
            }
        }

        private void btnAircraftUnload_Click(object sender, EventArgs e)
        {
            BeginAircraftTransaction();

            ICollection<Ysfo.Core.AircraftAddon> items = lbxAircraftLoaded.SelectedItems.Cast<Ysfo.Core.AircraftAddon>().ToList();

            // move
            items.ForEach(a =>
            {
                if (_ysfo.LoadedAircraft.Remove(a))
                {
                    _ysfo.UnloadedAircraft.Add(a);
                }
            });

            EndAircraftTransaction();

            // clear selection
            lbxAircraftUnloaded.ClearSelected();
            lbxAircraftLoaded.ClearSelected();

            // set items as selected
            for (int i = lbxAircraftUnloaded.Items.Count - 1; i > (lbxAircraftUnloaded.Items.Count - 1) - items.Count; i--)
            {
                lbxAircraftUnloaded.SetSelected(i, true);
            }
        }

        private void BeginAircraftTransaction()
        {
            // begin transaction
            _ysfo.UnloadedAircraft.RaiseListChangedEvents = false;
            _ysfo.LoadedAircraft.RaiseListChangedEvents = false;
        }

        private void EndAircraftTransaction()
        {
            // end transaction
            _ysfo.UnloadedAircraft.RaiseListChangedEvents = true;
            _ysfo.LoadedAircraft.RaiseListChangedEvents = true;
            _ysfo.UnloadedAircraft.ResetBindings();
            _ysfo.LoadedAircraft.ResetBindings();
        }

        #endregion

        #region Ground

        private void lbxGroundUnloaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (lbxGroundUnloaded.SelectedItem != null)
            {
                lbxGroundLoaded.ClearSelected();

                // buttons
                btnGroundLoad.Enabled = true;
                btnGroundUnload.Enabled = false;

                // status
                if (lbxGroundUnloaded.SelectedItems.Count == 1)
                {
                    var ground = (Ysfo.Core.GroundAddon)lbxGroundUnloaded.SelectedItem;

                    lblStatus.Text = ground.NamePretty;
                }
                else
                {
                    lblStatus.Text = lbxGroundUnloaded.SelectedItems.Count + " items selected";
                }
            }
        }

        private void lbxGroundLoaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (lbxGroundLoaded.SelectedItem != null)
            {
                lbxGroundUnloaded.ClearSelected();

                // buttons
                btnGroundLoad.Enabled = false;
                btnGroundUnload.Enabled = true;

                // status
                if (lbxGroundLoaded.SelectedItems.Count == 1)
                {
                    var ground = (Ysfo.Core.GroundAddon)lbxGroundLoaded.SelectedItem;

                    lblStatus.Text = ground.NamePretty;
                }
                else
                {
                    lblStatus.Text = lbxGroundLoaded.SelectedItems.Count + " items selected";
                }
            }
        }

        private void btnGroundUp_Click(object sender, EventArgs e)
        {
            if (lbxGroundLoaded.SelectedItems.Count > 0)
            {
                // loaded
                for (int i = 1; i < lbxGroundLoaded.Items.Count; i++)
                {
                    // if selected
                    if (lbxGroundLoaded.GetSelected(i))
                    {
                        _ysfo.LoadedGround.MoveItem(i, Extensions.MoveDirection.Up);

                        // update selection
                        lbxGroundLoaded.SetSelected(i - 1, true);
                        lbxGroundLoaded.SetSelected(i, false);
                    }
                }
            }

            if (lbxGroundUnloaded.SelectedItems.Count > 0)
            {
                // unloaded
                for (int i = 1; i < lbxGroundUnloaded.Items.Count; i++)
                {
                    // if selected
                    if (lbxGroundUnloaded.GetSelected(i))
                    {
                        _ysfo.UnloadedGround.MoveItem(i, Extensions.MoveDirection.Up);

                        // update selection
                        lbxGroundUnloaded.SetSelected(i - 1, true);
                        lbxGroundUnloaded.SetSelected(i, false);
                    }
                }
            }
        }

        private void btnGroundDown_Click(object sender, EventArgs e)
        {
            if (lbxGroundLoaded.SelectedItems.Count > 0)
            {
                // loaded
                for (int i = lbxGroundLoaded.Items.Count - 1; i > 1; i--)
                {
                    // if selected
                    if (lbxGroundLoaded.GetSelected(i))
                    {
                        _ysfo.LoadedGround.MoveItem(i, Extensions.MoveDirection.Down);

                        // update selection
                        lbxGroundLoaded.SetSelected(i + 1, true);
                        lbxGroundLoaded.SetSelected(i, false);
                    }
                }
            }

            if (lbxGroundUnloaded.SelectedItems.Count > 0)
            {
                // unloaded
                for (int i = lbxGroundUnloaded.Items.Count - 2; i >= 0; i--)
                {
                    // if selected
                    if (lbxGroundUnloaded.GetSelected(i))
                    {
                        _ysfo.UnloadedGround.MoveItem(i, Extensions.MoveDirection.Down);

                        // update selection
                        lbxGroundUnloaded.SetSelected(i + 1, true);
                        lbxGroundUnloaded.SetSelected(i, false);
                    }
                }
            }
        }

        private void btnGroundLoad_Click(object sender, EventArgs e)
        {
            BeginGroundTransaction();

            ICollection<Ysfo.Core.GroundAddon> items = lbxGroundUnloaded.SelectedItems.Cast<Ysfo.Core.GroundAddon>().ToList();

            // move
            items.ForEach(a =>
            {
                if (_ysfo.UnloadedGround.Remove(a))
                {
                    _ysfo.LoadedGround.Add(a);
                }
            });

            EndGroundTransaction();

            // clear selection
            lbxGroundUnloaded.ClearSelected();
            lbxGroundLoaded.ClearSelected();

            // set items as selected
            for (int i = lbxGroundLoaded.Items.Count - 1; i > (lbxGroundLoaded.Items.Count - 1) - items.Count; i--)
            {
                lbxGroundLoaded.SetSelected(i, true);
            }
        }

        private void btnGroundUnload_Click(object sender, EventArgs e)
        {
            BeginGroundTransaction();

            ICollection<Ysfo.Core.GroundAddon> items = lbxGroundLoaded.SelectedItems.Cast<Ysfo.Core.GroundAddon>().ToList();

            // move
            items.ForEach(a =>
            {
                if (_ysfo.LoadedGround.Remove(a))
                {
                    _ysfo.UnloadedGround.Add(a);
                }
            });

            EndGroundTransaction();

            // clear selection
            lbxGroundUnloaded.ClearSelected();
            lbxGroundLoaded.ClearSelected();

            // set items as selected
            for (int i = lbxGroundUnloaded.Items.Count - 1; i > (lbxGroundUnloaded.Items.Count - 1) - items.Count; i--)
            {
                lbxGroundUnloaded.SetSelected(i, true);
            }
        }

        private void BeginGroundTransaction()
        {
            // begin transaction
            _ysfo.UnloadedGround.RaiseListChangedEvents = false;
            _ysfo.LoadedGround.RaiseListChangedEvents = false;
        }

        private void EndGroundTransaction()
        {
            // end transaction
            _ysfo.UnloadedGround.RaiseListChangedEvents = true;
            _ysfo.LoadedGround.RaiseListChangedEvents = true;
            _ysfo.UnloadedGround.ResetBindings();
            _ysfo.LoadedGround.ResetBindings();
        }


        #endregion

        #region Scenery

        private void lbxSceneryUnloaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (lbxSceneryUnloaded.SelectedItem != null)
            {
                lbxSceneryLoaded.ClearSelected();

                // buttons
                btnSceneryLoad.Enabled = true;
                btnSceneryUnload.Enabled = false;

                // status
                if (lbxSceneryUnloaded.SelectedItems.Count == 1)
                {
                    var scenery = (Ysfo.Core.SceneryAddon)lbxSceneryUnloaded.SelectedItem;

                    lblStatus.Text = scenery.NamePretty;
                }
                else
                {
                    lblStatus.Text = lbxSceneryUnloaded.SelectedItems.Count + " items selected";
                }
            }
        }

        private void lbxSceneryLoaded_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (lbxSceneryLoaded.SelectedItem != null)
            {
                lbxSceneryUnloaded.ClearSelected();

                // buttons
                btnSceneryLoad.Enabled = false;
                btnSceneryUnload.Enabled = true;

                // status
                if (lbxSceneryLoaded.SelectedItems.Count == 1)
                {
                    var scenery = (Ysfo.Core.SceneryAddon)lbxSceneryLoaded.SelectedItem;

                    lblStatus.Text = scenery.NamePretty;
                }
                else
                {
                    lblStatus.Text = lbxSceneryLoaded.SelectedItems.Count + " items selected";
                }
            }
        }

        #endregion

        #region Settings

        private void btnSettingsBrowse_Click(object sender, EventArgs e)
        {
            // set path
            diaSettingsBrowseYsPath.SelectedPath = _ysfo.Path;

            // show dialog
            DialogResult result = diaSettingsBrowseYsPath.ShowDialog();

            if (result == DialogResult.OK)
            {
                // update textbox
                _ysfo.Path = diaSettingsBrowseYsPath.SelectedPath;
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tpgSettings_Enter(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        #endregion

        #region FormEvents

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ysfo.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // initialise
            _ysfo = new YsfoWrapper();

            // settings
            tbxSettingsPath.DataBindings.Add("Text", _ysfo, "Path");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void mitExit_Click(object sender, EventArgs e)
        {
            // close form
            Close();
        }

        #endregion
    }
}
