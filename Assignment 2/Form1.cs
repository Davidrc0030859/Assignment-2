﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double SR1 = double.Parse(textBox9.Text);
            double SR2 = double.Parse(textBox1.Text);
            double SR3 = double.Parse(textBox4.Text);
            double SR4 = double.Parse(textBox3.Text);
            double SR5 = double.Parse(textBox7.Text);

            double TotalResistance = SR1 + SR2 + SR3 + SR4 + SR5;
            MessageBox.Show("TotalResistance = " + TotalResistance.ToString("0.00") + "Ω");
        }
    }
}
