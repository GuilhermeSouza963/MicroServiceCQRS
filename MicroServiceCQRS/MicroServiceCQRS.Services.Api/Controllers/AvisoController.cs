using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServiceCQRS.Application.Interfaces;
using MicroServiceCQRS.Application.ViewModels;
using MicroServiceCQRS.ServicesApi.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroServiceCQRS.Services.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AvisoController : ApiController
    {
        private readonly IObjetoAppService _objetoAppService;
        private readonly IDisciplinaObjetoAppService _disciplinaObjetoAppService;

        public AvisoController(IObjetoAppService objetoAppService, IDisciplinaObjetoAppService disciplinaObjetoAppService)
        {
            _objetoAppService = objetoAppService;
            _disciplinaObjetoAppService = disciplinaObjetoAppService;            
        }

        

        [AllowAnonymous]
        [HttpGet("aviso")]
        public async Task<IEnumerable<ObjetoViewModel>> Get()
        {
            return await _objetoAppService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("aviso/{id:int}")]
        public async Task<ObjetoViewModel> Get(int id)
        {
            return await _objetoAppService.GetById(id);
        }

        [HttpPost("aviso")]
        public async Task<IActionResult> Post([FromBody] ObjetoViewModel objetoViewModel)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _objetoAppService.Add(objetoViewModel));
        }

    }
}