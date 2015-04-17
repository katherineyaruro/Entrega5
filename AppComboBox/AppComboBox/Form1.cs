using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int contador = 0; contador <= 255; contador++) 
            {
                cmbRojo.Items.Add(contador.ToString());
            }

            for (int contador = 0; contador <= 255; contador++)
            {
                cmbRosa.Items.Add(contador.ToString());
            }
            for (int contador = 0; contador <= 255; contador++)
            {
                cmbAzul.Items.Add(contador.ToString());
            }
        }

        private void bbtColor_Click(object sender, EventArgs e)
        {
            int rojo, rosa, azul;
            rojo = int.Parse(cmbRojo.Text);
            rosa = int.Parse(cmbRosa.Text);
            azul = int.Parse(cmbAzul.Text);
            BackColor = Color.FromArgb(rojo, rosa, azul);

        }
    }
}
