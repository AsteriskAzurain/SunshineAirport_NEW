﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0706.admin
{
    public partial class FlightScheduleManagement : Form
    {
        public FlightScheduleManagement()
        {
            InitializeComponent();
        }

        private void FlightScheduleManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
        }
    }
}