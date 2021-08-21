using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAgosto21WebApiUnitTest.modelo;

namespace WebAgosto21WebApiUnitTest.dto
{
    // una clase DTO
    // data transfer object
    // es una clase usada para transportar datos.

    public class ClienteyMontoDTO
    {
        public Cliente cli { set; get;}
        public int monto { set; get;}
    }
}
