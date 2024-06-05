using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PizzaModelo : Modelo
    {
        public int Id;
        public string Nombre;
        public int Precio;

        public void Guardar()
        {
            string sql = $"INSERT INTO pizzas (nombre,precio) VALUES('{this.Nombre}',{this.Precio})";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();

        }

        public void Borrar()
        {
            string sql = $"DELETE FROM pizzas WHERE id ='{this.Id}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }
    }
}
