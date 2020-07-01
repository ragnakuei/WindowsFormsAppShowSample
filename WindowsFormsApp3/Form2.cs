﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public DialogResult DialogResult { get; set; } = DialogResult.Cancel;

        private void btn_Click(object sender, EventArgs e)
        {
            DialogResult = (sender as Button).DialogResult;
            this.Close();
        }
    }
}
