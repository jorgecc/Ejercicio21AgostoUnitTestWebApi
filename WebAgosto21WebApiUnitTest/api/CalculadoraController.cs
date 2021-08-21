using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using WebAgosto21WebApiUnitTest.servicio;

namespace WebAgosto21WebApiUnitTest.api
{
    // http://localhost:35835/api/Calculadora/Sumar?n1=20&n2=30

    [Route("api/[controller]")]
    [ApiController]
    [ExcludeFromCodeCoverage]
    public class CalculadoraController : ControllerBase
    {

        // funcion envolvedora (wrapper)
        [HttpGet]
        [Route("Sumar")]
        public int Sumar(int n1,int n2)
        {
            return CalculadoraServicio.Sumar(n1,n2);
        }
    }
}
