using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAgosto21WebApiUnitTest.modelo
{
    public class Cliente
    {
        public string Nombre { set; get;}
        public int MontoUtilizado { set; get;}
        public int MontoMaximo { set; get; }
        public bool Moroso { set; get;}

    }
}
