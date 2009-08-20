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

        private void LoadData()
        {
            try
            {
                _ysfo.Setup();

                // enable tabs
                tpgAircraft.Enabled = true;
                tpgObjects.Enabled = true;
                tpgMaps.Enabled = true;
            }
            catch (YsfoWrapper.YsfoPathInvalidException)
            {
                // change tabs
                tpgAircraft.Enabled = false;
                tpgObjects.Enabled = false;
                tpgMaps.Enabled = false;
                tabControl.SelectedTab = tpgSettings;

                MessageBox.Show("The path to your YsFlight directory is invalid!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
