using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.DAL.Entities;
using ApnaMakaanAPI.DAL.Repositories;
using AutoMapper;

namespace ApnaMakaanAPI.BLL.Services
{
    public interface IUserService : IBaseService<UserRequestDTO, UserResponseDTO> 
    {
        Task<UserPropertyResponseDTO> GetUserwithAllProperty(int id);
    }
    public class UserService : IUserService
    {
        private readonly IRepositoryWrapper repository;
        private readonly IMapper mapper;

        public UserService(IRepositoryWrapper repository, IMapper mapper)
        { 
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<UserResponseDTO> Add(UserRequestDTO requestDTO)
        {
            var user= mapper.Map<user>(requestDTO);
            var userresponse = await this.repository.UserRepository.CreateAsync(user);
            await this.repository.UserRepository.SaveAsync();
            var result = mapper.Map<UserResponseDTO>(userresponse);
            return result;


        }

        public async Task<bool> Delete(int id)
        {
            var del =  await this.repository.UserRepository.DeleteAsync(id);
            await this.repository.UserRepository.SaveAsync();
            return del;
        }

       

        public async Task<IEnumerable<UserResponseDTO>> GetAll()
        {
            var user = await this.repository.UserRepository.GetAllAsync();
            var result = mapper.Map<UserResponseDTO[]>(user);
            return result;

        }

        public async Task<UserResponseDTO> GetById(int id)
        {
            var user = await this.repository.UserRepository.GetById(id);
            var result = mapper.Map<UserResponseDTO>(user);
            return result;
        }

        public async Task<UserResponseDTO>Update(int id, UserRequestDTO requestDTO)
        {
            var data = mapper.Map<user>(requestDTO);
            data.Id = id;
            var result = await this.repository.UserRepository.UpdateAsync(id, data);
            await this.repository.UserRepository.SaveAsync();
            var response = mapper.Map<UserResponseDTO>(result);
            return response;

        }


        public async Task<UserPropertyResponseDTO> GetUserwithAllProperty(int id)
        {
            var data = await this.repository.UserRepository.GetUserwithProperty(id);
            var result = mapper.Map<UserPropertyResponseDTO>(data);
            return result;

        }

    }
}
