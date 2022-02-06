using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        }

        public string numarAleatorPtTelefon { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator numarAleator = new RandomNumberGenerator();
            numarAleatorPtTelefon = numarAleator.RandomTelephoneGenerator();
            string value = comboBox1.Text;
            var index = value.IndexOf(' ');
            var dela = value.Substring(index + 1);
            textBox1.Text = dela + " " + numarAleatorPtTelefon;
            MessageBox.Show("For " + value + " region, the random number generated is"+ textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }

}
