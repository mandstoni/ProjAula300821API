using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjAula300821API.Controllers.Model
{
    public class Padaria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public int QuantidadeFuncionario { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
