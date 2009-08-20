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

        private void mitExit_Click(object sender, EventArgs e)
        {
            // close form
            Close();
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

        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ysfo.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // initialize
            _ysfo = new YsfoWrapper();

            // settings
            tbxSettingsPath.DataBindings.Add("Text", _ysfo, "Path");
        }
    }
}
