using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.DAL.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApnaMakaanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyTypeController : ControllerBase
    {
        private readonly IRepositoryWrapper repository;
        private readonly IMapper mapper;

        public PropertyTypeController(IRepositoryWrapper repository , IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var result = await this.repository.PropertyTypeRepository.GetAllAsync();
            var data = mapper.Map<IEnumerable<PropertyTypeResponseDTO>>(result);
            return Ok(data);
        }

        [HttpGet("PropertywithPropoertyType/{id}")]

        public async Task<IActionResult> GetPropertywithTypes(int id)
        {
            var result = await this.repository.PropertyTypeRepository.GetPropertyTypewithProperty(id);
            var data = mapper.Map<PropertyTypeWithPropertyResponseDTO>(result);
            return Ok(data);
        }
    }
}
