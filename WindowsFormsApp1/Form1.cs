﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double Pi = 3.141592653589793;
            double c = 299792458;
            double d1 = 5e6;
            richTextBox1.AppendText(Pi.ToString() + "\n");
            richTextBox1.AppendText(Pi.ToString("N5") + "\n");
            richTextBox1.AppendText(Pi.ToString("N3") + "\n");
            richTextBox1.AppendText(Pi.ToString("N0") + "\n");
            richTextBox1.AppendText(Pi.ToString("0") + "\n");
            richTextBox1.AppendText(Pi.ToString("0.0") + "\n");
            richTextBox1.AppendText(Pi.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(Pi.ToString("0.00E00") + "\n");

            string st = "three";
            try
            {

                int it = int.Parse(st);

            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            }




        }
        
            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
