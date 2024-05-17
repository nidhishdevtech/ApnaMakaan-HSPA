using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.DAL.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApnaMakaanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnishingTypeController : ControllerBase
    {
        private readonly IRepositoryWrapper repository;
        private readonly IMapper mapper;

        public FurnishingTypeController(IRepositoryWrapper repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult>Get()
        {
            var result = await this.repository.FurnishingTypeRepository.GetAllAsync();
            var data = mapper.Map<IEnumerable<FurnishingTypeResponseDTO>>(result);
            return Ok(data);
        }

        [HttpGet("PropertywithFurnishingType/{id}")]

        public async Task<IActionResult>GetPropertywithFurnishing(int id)
        {
            var result = await this.repository.FurnishingTypeRepository.GetFurnishingwithProperty(id);
           var data = mapper.Map<FurnishingTypeWithPropertyResponseDTO>(result);
            return Ok(data);
        }

    }
}
