using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombaInjetora
{
    // Vai ser usado futuramente também para implementação nos relatórios
    internal class SessaoOperadorcs
    {
        public class SessaoOperador
        {
            private static SessaoOperador instancia;

            public string NomeOperador { get; set; }

            private SessaoOperador() { }

            public static SessaoOperador Instancia
            {
                get
                {
                    if (instancia == null)
                    {
                        instancia = new SessaoOperador();
                    }
                    return instancia;
                }
            }

        }
    }
}
