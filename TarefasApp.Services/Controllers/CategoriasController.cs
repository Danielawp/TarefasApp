using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarefasApp.Domain.Interfaces.Services;
using TarefasApp.Services.Models;

namespace TarefasApp.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaDomainService? _categoriaDomainService;
        private readonly IMapper? _mapper;

        public CategoriasController(ICategoriaDomainService? categoriaDomainService, IMapper? mapper)
        {
            _categoriaDomainService = categoriaDomainService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categoria = _mapper.Map<List<CategoriasGetModel>>(_categoriaDomainService?.Consultar());
            return Ok(categoria);
        }
    }
}
