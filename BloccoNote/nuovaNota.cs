﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloccoNote
{
    public partial class nuovaNota : Form
    {
        public nuovaNota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.nomeTemp = textBox1.ToString();
            this.Close();
        }
    }
}
