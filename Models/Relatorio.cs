using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombaInjetora.Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Testes { get; set; }
        public string Provetas { get; set; }
    }
}
