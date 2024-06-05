using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void Eliminar(string id)
        {
            PizzaModelo pizza = new PizzaModelo();
            pizza.Id = Int32.Parse(id);
            pizza.Borrar();

        }
    }
}
