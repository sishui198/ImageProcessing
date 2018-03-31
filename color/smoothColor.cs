﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace color
{
    public partial class smoothColor : Form
    {
        public smoothColor()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool GetMethod
        {
            get
            {
                return hsiS.Checked;
            }
        }

        public byte GetLength
        {
            get
            {
                return (byte)lengthS.Value;
            }
        }
    }
}