﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class FrmSozlesmeGenel : Form
    {
        public FrmSozlesmeGenel()
        {
            InitializeComponent();
        }

        private void FrmSozlesmeGenel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracKiralamaDataSet.kiralama' table. You can move, or remove it, as needed.
            this.kiralamaTableAdapter.Fill(this.aracKiralamaDataSet.kiralama);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
