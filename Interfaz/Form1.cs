using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controladores;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            PizzaControlador.Crear(TextBoxNombre.Text, TextBoxPrecio.Text);
            MessageBox.Show("Su pizza ha sido creada");
        }
    }
}
