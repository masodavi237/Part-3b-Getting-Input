﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3b_Getting_Input
{
    public partial class MainForm : Form
    {
        string name;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtInput.Text;
            lblMessage.Text = ($"Greetings {name}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
