using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.BLL.Services;
using ApnaMakaanAPI.DAL.Entities;
using ApnaMakaanAPI.DAL.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ApnaMakaanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService propertyservice;
        private readonly IMapper mapper;

        public PropertyController(IPropertyService propertyservice, IMapper mapper)
        {
            this.propertyservice = propertyservice;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.propertyservice.GetAll();
            return Ok(result);
        }


        

        [HttpPost]
        public async Task<IActionResult> Post(PropertyRequestDTO propertydto)
        {
            var result = await this.propertyservice.Add(propertydto);
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult>GetByID(int id)
        {
            var result = await this.propertyservice.GetById(id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<bool>Delete(int id)
        {
            return await this.propertyservice.Delete(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateData(int id , PropertyRequestDTO requestdto)
        {
            var result = await this.propertyservice.Update(id,requestdto);
            return Ok(result);
        }


        [HttpGet("/PropertyForRent")]
        public async Task<IActionResult> PropertyForRent()
        {   
            var property = await this.propertyservice.GetPropertiesForRent();
            var result = mapper.Map<IEnumerable<PropertyResponseDTO>>(property);
            return Ok(result);
        }

        [HttpGet("/PropertyForSale")]
        public async Task<IActionResult> PropertyForSale()
        {
            var property = await this.propertyservice.GetPropertiesForSale();
            var result = mapper.Map<IEnumerable<PropertyResponseDTO>>(property);
            return Ok(result);
        }





    }
}
