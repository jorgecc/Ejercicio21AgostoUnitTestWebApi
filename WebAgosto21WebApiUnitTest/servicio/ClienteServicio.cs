using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAgosto21WebApiUnitTest.modelo;

namespace WebAgosto21WebApiUnitTest.servicio
{
    public class ClienteServicio
    {
        public static bool SolicitudCredito(Cliente cli,int montoSolicitado)
        {
            var resultado=true;
            if(cli.MontoUtilizado+montoSolicitado>cli.MontoMaximo)
            {
                resultado=false; // credito rechazado
            }
            if (cli.MontoUtilizado + montoSolicitado <0)
            {
                resultado = false; // credito rechazado por overflow
            }
            if (cli.Moroso)
            {
                resultado=false; // credito rechazado
            }
         
            return resultado;
        }
        public static int Azar()
        {
            var azar=new Random();
            return azar.Next(-100,100); 
        }
    }
}
