using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; //Permite fazer a serialização para .json

namespace MaximoSync
{
    public class Formulario
    {
        public string UrlLink { get; set; }
        public decimal TempoMinutos { get; set; }

        public string JsonSerializar(Formulario formulario)
        {
            return JsonConvert.SerializeObject(formulario);
        }
    }

}