﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongGiuXe
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.imgLoading.Image = Properties.Resources.Loading_ico;
            this.imgLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imgLoading.Refresh();
        }
    }
}
