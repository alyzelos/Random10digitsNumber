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
            textBox1.Text = numarAleatorPtTelefon;
            MessageBox.Show("New 10 digits random number generated");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
