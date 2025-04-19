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
        public string urlLink { get; set; }
        public decimal tempoMinutos { get; set; }
    }
}