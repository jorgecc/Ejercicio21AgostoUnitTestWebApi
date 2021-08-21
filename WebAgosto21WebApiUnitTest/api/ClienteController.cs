using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using WebAgosto21WebApiUnitTest.dto;
using WebAgosto21WebApiUnitTest.modelo;
using WebAgosto21WebApiUnitTest.servicio;

namespace WebAgosto21WebApiUnitTest.api
{
    [Route("api/[controller]")]
    [ApiController]
    [ExcludeFromCodeCoverage]
    public class ClienteController : ControllerBase
    {
        [Route("SolicitudCredito")]
        public bool SolicitudCredito([FromBody] ClienteyMontoDTO cuerpo)
        {           
           return ClienteServicio.SolicitudCredito(cuerpo.cli,cuerpo.monto);
        }

    }
}
