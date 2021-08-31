using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjAula300821API.Controllers.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
