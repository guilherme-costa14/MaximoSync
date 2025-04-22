using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; //Permite fazer a serialização para .json

namespace MaximoSync
{
    //Declaração de uma classe Formulario
    public class Formulario
    {
        //Métodos da classe.
        public string UrlLink { get; set; }
        public int TempoMinutos { get; set; }

        //Função para converter os dados em formato .json
        public string JsonSerializar(Formulario formulario)
        {
            return JsonConvert.SerializeObject(formulario);
        }
    }

}