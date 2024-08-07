using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Modelos;

namespace Controladores
{
    public class PizzaControlador
    {
        public static void Crear(string nombre, string precio)
        {
            PizzaModelo pizza = new PizzaModelo();
            pizza.Nombre = nombre;
            pizza.Precio = Int32.Parse(precio);

            pizza.Guardar();

        }

        public static bool Eliminar(string id)
        {
            PizzaModelo pizza = new PizzaModelo();
            if (pizza.Buscar(Int32.Parse(id)))
            {
                pizza.Borrar();
                return true;
            }

            return false;
        }

        public static bool Modificar(string id, string nombre, string precio)
        {
            PizzaModelo pizza = new PizzaModelo();
            if (pizza.Buscar(Int32.Parse(id)))
            {
                pizza.Nombre = nombre;
                pizza.Precio = Int32.Parse(precio);

                pizza.Guardar();
                return true;
            }

            return false;


          

        }

        public static Dictionary<string,string> Buscar(int id)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            PizzaModelo p = new PizzaModelo();
            if (p.Buscar(id))
            {
                resultado.Add("resultado", "true");
                resultado.Add("id", p.Id.ToString());
                resultado.Add("nombre", p.Nombre);
                resultado.Add("precio", p.Precio.ToString());
                return resultado;
            }
            resultado.Add("resultado", "false");
            return resultado;





        }


        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Precio", typeof(int));


            PizzaModelo pizza = new PizzaModelo();
            foreach(PizzaModelo p in pizza.ObtenerTodos())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Precio"] = p.Precio;
                tabla.Rows.Add(fila);
            }

            return tabla;
          
        }
    }
}
