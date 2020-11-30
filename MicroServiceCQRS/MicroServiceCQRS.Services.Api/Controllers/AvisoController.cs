using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServiceCQRS.Application.Interfaces;
using MicroServiceCQRS.ServicesApi.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroServiceCQRS.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvisoController : ApiController
    {
        private readonly IObjetoAppService _objetoAppService;

        public AvisoController(IObjetoAppService objetoAppService)
        {
            _objetoAppService = objetoAppService;
        }

    }
}