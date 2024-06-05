using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelos
{
    public abstract class Modelo
    {
        public string IP;
        public string NombreBase;
        public string NombreDeUsuario;
        public string Password;

        public MySqlConnection Conexion;
        public MySqlCommand Comando;
        public MySqlDataReader Lector;

        public Modelo()
        {
            this.IP = "127.0.0.1";
            this.NombreBase = "pizzas";
            this.Password = "";
            this.NombreDeUsuario = "root";

            this.Conexion = new MySqlConnection(
                $"server={this.IP};" +
                $"user={this.NombreDeUsuario};" +
                $"password={this.Password};" +
                $"database={this.NombreBase};"
            );

            this.Conexion.Open();

            this.Comando = new MySqlCommand();
            this.Comando.Connection = this.Conexion;
            
        }


    }
}
