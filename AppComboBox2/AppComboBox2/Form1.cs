using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Rosa");
            comboBox1.Items.Add("Negro");
            comboBox1.Items.Add("Verde");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Violeta");
            comboBox1.Items.Add("Amarrillo");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = comboBox1.Text;
            label1.Text = x;
        }
    }
}
