using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.BLL.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApnaMakaanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userservice;
        private readonly IMapper mapper;

        public UserController(IUserService userservice , IMapper mapper)
        {
            this.userservice = userservice;
            this.mapper = mapper;
        }


        [HttpPost]

        public async Task<ActionResult>PostData(UserRequestDTO requestDTO)
        {
            var result = await this.userservice.Add(requestDTO);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IEnumerable<UserResponseDTO>> GetAllUser()
        {
            var result = await this.userservice.GetAll();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult>GetByIdProperty(int id)
        {
            var result = await this.userservice.GetById(id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<bool>DeleteUser(int id)
        {
            return await this.userservice.Delete(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateUser(int id , UserRequestDTO requestDTO)
        {
            var result = await this.userservice.Update(id,requestDTO);
            return Ok(result);
        }


        [HttpGet("UserWithProperty/{id}")]
        public async Task<ActionResult> GetUserwithProperty(int id)
        {
            var data = await this.userservice.GetUserwithAllProperty(id);
            return Ok(data);
        }
    }
}
