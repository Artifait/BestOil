﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class fCheck : Form
    {
        public fCheck()
        {
            InitializeComponent();
        }
        public fCheck(int order, string check)
        {
            InitializeComponent();

            Text = $"Order N{order}";
            label2.Text = check;
        }
    }
}
