using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using RestSharp;

namespace Modelos
{
    class ModeloREST
    {
        public string Url = "http://localhost:65066/";
        public RestClient client;
        public RestRequest request;
        public RestResponse response;

    }
}
