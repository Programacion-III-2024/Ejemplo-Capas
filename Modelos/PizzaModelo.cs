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
            if (this.Id == 0) insertar();
            if (this.Id > 0) modificar();
        }

        private void modificar()
        {
            string sql = $"UPDATE pizzas set nombre ='{this.Nombre}', precio = {this.Precio} WHERE id = {this.Id}";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        private void insertar()
        {
            string sql = $"INSERT INTO pizzas (nombre,precio) VALUES('{this.Nombre}',{this.Precio})";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void Borrar()
        {
            string sql = $"UPDATE pizzas SET eliminado = true WHERE id ='{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public List<PizzaModelo> ObtenerTodos()
        {
            List<PizzaModelo> pizzas = new List<PizzaModelo>();

            string sql = $"SELECT * FROM pizzas WHERE eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                PizzaModelo pizza = new PizzaModelo();
                pizza.Id = Int32.Parse(this.Lector["Id"].ToString());
                pizza.Nombre = this.Lector["Nombre"].ToString();
                pizza.Precio = Int32.Parse(this.Lector["Precio"].ToString());
                pizzas.Add(pizza);
            }
            this.Lector.Close();
            return pizzas;
            

        }

        public bool Buscar(int id)
        {
            string sql = $"SELECT * FROM pizzas WHERE eliminado = false and id = {id}";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            if (this.Lector.HasRows) { 
                this.Lector.Read();
                this.Id = Int32.Parse(this.Lector["Id"].ToString());
                this.Nombre = this.Lector["Nombre"].ToString();
                this.Precio = Int32.Parse(this.Lector["Precio"].ToString());
                this.Lector.Close();
                return true;

            }
            this.Lector.Close();
            return false;

        }
    }
}
