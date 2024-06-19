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
            refrescarTablaDeDatos();
            MessageBox.Show("Su pizza ha sido creada");

        }

        private void refrescarTablaDeDatos()
        {
            tablaDeDatos.Refresh();
            tablaDeDatos.DataSource = PizzaControlador.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescarTablaDeDatos();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            string id = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar la pizza {id}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                PizzaControlador.Eliminar(id);
                refrescarTablaDeDatos();
                MessageBox.Show("Pizza eliminada");
            }
        }

        private void tablaDeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxNombre.Text = tablaDeDatos.SelectedRows[0].Cells["nombre"].Value.ToString();
            TextBoxPrecio.Text = tablaDeDatos.SelectedRows[0].Cells["precio"].Value.ToString();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            /*string id = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
            PizzaControlador.Modificar(id, TextBoxNombre.Text, TextBoxPrecio.Text);
            MessageBox.Show("Pizza Modificada");
            refrescarTablaDeDatos();*/
        }
    }
}
