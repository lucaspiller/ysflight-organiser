using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ysfo.Samples.Lister
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = tbxPath.Text;

                // aircraft
                var aircraft = ysfo.GetAircraftCollection();
                lbxAircraft.Items.AddRange(aircraft.ToArray());

                // ground
                var ground = ysfo.GetGroundCollection();
                lbxGround.Items.AddRange(ground.ToArray());

                // scenery
                var scenery = ysfo.GetSceneryCollection();
                lbxScenery.Items.AddRange(scenery.ToArray());
            }
        }

        private void lbxAircraft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Ysfo.Core.AircraftAddon aircraft = (Ysfo.Core.AircraftAddon) lbxAircraft.SelectedItem;

            if (aircraft != null)
            {
                new AircraftDetailsForm(aircraft).Show();
            }
        }
    }
}
