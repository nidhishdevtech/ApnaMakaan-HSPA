using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.BLL.Services;
using ApnaMakaanAPI.DAL.Entities;
using ApnaMakaanAPI.DAL.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApnaMakaanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService cityService;
        private readonly IMapper mapper;

        public CityController(ICityService cityService , IMapper mapper)
        {
            this.cityService = cityService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.cityService.GetAll();
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CityRequestDTO citydto)
        {
            
            var result = await this.cityService.Add(citydto); 
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult>GetById(int id)
        {
            var result =  await this.cityService.GetById(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


        [HttpDelete("{id}")]

        public async Task<bool>DeleteAsync(int id)
        {
          
            return await this.cityService.Delete(id);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<City>>Update(int id , CityRequestDTO requestDTO )
        {
            var city = await this.cityService.Update(id, requestDTO);
            return Ok(city);
        }

        [HttpGet("CityWithProperty{id}")]

        public  async Task<ActionResult>GetCitywithProperty(int id)
        {
            var data =  await this.cityService.GetCitywithAllProperty(id);
            return Ok(data);
        }

    }
}
