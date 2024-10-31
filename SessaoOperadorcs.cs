using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombaInjetora
{
    internal class SessaoOperadorcs
    {
        public class SessaoOperador
        {
            private static SessaoOperador instancia;

            public string NomeOperador { get; set; }
            public string EmailOperador { get; set; }

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
