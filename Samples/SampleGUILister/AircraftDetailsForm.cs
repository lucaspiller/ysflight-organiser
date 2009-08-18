using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleGUILister
{
    public partial class AircraftDetailsForm : Form
    {
        public AircraftDetailsForm(Ysfo.Core.AircraftAddon aircraft)
        {
            InitializeComponent();

            // set details
            tbxLstEntry.Text = aircraft.LstEntry;
            tbxName.Text = aircraft.NamePretty;
            tbxCategory.Text = aircraft.CategoryPretty;
        }
    }
}
