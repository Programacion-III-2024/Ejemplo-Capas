using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

using ClienteAPI.Respuestas;

namespace ClienteAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listar()
        {
            List<PizzaDesdeAPI> pizzas = obtenerPizzasDesdeAPI();
            DataTable tabla = generarDataTable(pizzas);
            listaDePizzas.DataSource = tabla;
        }

        private static DataTable generarDataTable(List<PizzaDesdeAPI> pizzas)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Precio", typeof(int));

            foreach (PizzaDesdeAPI p in pizzas)
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Precio"] = p.Precio;
                tabla.Rows.Add(fila);
            }

            return tabla;
        }

        private static List<PizzaDesdeAPI> obtenerPizzasDesdeAPI()
        {
            RestClient client = new RestClient("http://localhost:65066/");
            RestRequest request = new RestRequest("/api/pizza", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);

            List<PizzaDesdeAPI> pizzas;
            pizzas = JsonConvert.DeserializeObject<List<PizzaDesdeAPI>>(response.Content);
            return pizzas;
        }

        private bool crearPizza(string nombre, string precio)
        {
            Dictionary<string, string> data = new Dictionary<string, string>(){
                { "nombre", TextboxNombre.Text },
                { "precio", TextboxPrecio.Text }
            };
            string requestBody = JsonConvert.SerializeObject(data);

            RestClient client = new RestClient("http://localhost:65066/");
            RestRequest request = new RestRequest("/api/pizza", Method.Post);


            request.RequestFormat = DataFormat.Json;
            request.AddBody(requestBody);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            RestResponse response = client.Execute(request);

            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (crearPizza(TextboxNombre.Text, TextboxPrecio.Text))
            {
                MessageBox.Show("Pizza Creada");
                listar();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
