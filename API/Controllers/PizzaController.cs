using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Models;
using Controladores;
using System.Data;

namespace API.Controllers
{
    public class PizzaController : ApiController
    {
        
       
        [Route("api/pizza")]
        public List<PizzaModel> Get()
        {
            DataTable pizzas = PizzaControlador.Listar();

            List<PizzaModel> pizzitas = new List<PizzaModel>();

            foreach(DataRow pizza in pizzas.Rows)
            {
                PizzaModel p = new PizzaModel();
                p.Id = Int32.Parse(pizza["id"].ToString());
                p.Nombre = pizza["nombre"].ToString();
                p.Precio = Int32.Parse(pizza["precio"].ToString());

                pizzitas.Add(p);
            }
            return pizzitas;
        }
        [Route("api/pizza/")]
        public IHttpActionResult Post(PizzaModel pizza)
        {
            PizzaControlador.Crear(pizza.Nombre,pizza.Precio.ToString());
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            resultado.Add("mensaje", "Pizza creada");
            return Ok(resultado);
        }

        [Route("api/pizza/{id:int}")]
        public IHttpActionResult Put(int id, PizzaModel pizza)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            bool existe = PizzaControlador.Modificar(id.ToString(), pizza.Nombre, pizza.Precio.ToString());

            if (existe){
                resultado.Add("mensaje", "Pizza creada");
                return Ok(resultado);
            }

            return NotFound();

        }
        [Route("api/pizza/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();

            bool existe = PizzaControlador.Eliminar(id.ToString());

            if (existe)
            {
                resultado.Add("mensaje", "Pizza Eliminada");
                return Ok(resultado);
            }

            return NotFound();
        }

        [Route("api/pizza/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            PizzaModel pizza = new PizzaModel();
            Dictionary<string,string> p = PizzaControlador.Buscar(id);

            if(p["resultado"] == "true")
            {
                pizza.Id = Int32.Parse(p["id"]);
                pizza.Nombre = p["nombre"];
                pizza.Precio = Int32.Parse(p["precio"]);
                return Ok(pizza);

            }
            return NotFound();

        }
    }
}