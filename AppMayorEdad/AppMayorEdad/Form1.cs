using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMayorEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona(txtNombre.Text,int.Parse(txtEdad.Text));
            if (persona1.Edad >= 18)
            {
                MessageBox.Show("LA EDAD DE" + persona1.Nombre + "TIENE" + persona1.Edad + "MAYOR DE 18");
            }
            else 
            {
                   MessageBox.Show("LA EDAD DE"+persona1.Nombre+"TIENE"+persona1.Edad+"MENOR DE 18");
            }
            }
        }
    }

