using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombaInjetora.Models
{
    public class Relatorio
    {
        public int id { get; set; }  
        public string modeloSelecionado { get; set; }
        public List<string> testesSelecionados { get; set; }
        public List<int> provetasSelecionadas { get; set; }

        public Relatorio()
        {
            testesSelecionados = new List<string>();
            provetasSelecionadas = new List<int>();
        }
    }


}
