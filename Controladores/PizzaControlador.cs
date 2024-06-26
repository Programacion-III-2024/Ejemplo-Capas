﻿using System;
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

        public static void Eliminar(string id)
        {
            PizzaModelo pizza = new PizzaModelo();
            pizza.Id = Int32.Parse(id);
            pizza.Borrar();
        }

        public static void Modificar(string id, string nombre, string precio)
        {

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
