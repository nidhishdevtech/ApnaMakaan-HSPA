using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.DAL.Entities;
using ApnaMakaanAPI.DAL.Repositories;
using AutoMapper;

namespace ApnaMakaanAPI.BLL.Services
{
    public interface IBaseService<TRequestDTO,TResponseDTO>
    {
        Task<IEnumerable<TResponseDTO>> GetAll();
        Task<TResponseDTO> GetById(int id);
        Task<TResponseDTO> Add(TRequestDTO requestDTO);
        Task<bool> Delete(int id);
        Task<TResponseDTO> Update(int id ,TRequestDTO requestDTO);
    }

    public interface ICityService : IBaseService<CityRequestDTO, CityResponseDTO>
    {
        Task<CityPropertyResponseDTO> GetCitywithAllProperty(int id);

      
    }

    public class CityService : ICityService
    {
        private readonly IRepositoryWrapper repository;
        private readonly IMapper mapper;

        public CityService(IRepositoryWrapper repository , IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CityResponseDTO> Add(CityRequestDTO requestDTO)
        {
            var city = mapper.Map<City>(requestDTO);
            var CityResponse = await this.repository.CityRepository.CreateAsync(city);
            await this.repository.CityRepository.SaveAsync();

            var result = mapper.Map<CityResponseDTO>(CityResponse);
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            /* var city = await this.repository.CityRepository.GetById(id);
             if (city != null)
             {
                 return await this.repository.CityRepository.DeleteAsync(city.Id);
             }
             return false;*/

            return await this.repository.CityRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CityResponseDTO>> GetAll()
        {
            var cityResponse = await this.repository.CityRepository.GetAllAsync();
            var result = mapper.Map<CityResponseDTO[]>(cityResponse);
            return result;

        }

        public async Task<CityResponseDTO> GetById(int id)
        {
            var city=  await this.repository.CityRepository.GetById(id);
            var result = mapper.Map<CityResponseDTO>(city);
            return result;
        }

        public async Task<CityResponseDTO> Update(int id , CityRequestDTO requestDTO)
        {
            var city = mapper.Map<City>(requestDTO);
            city.Id = id;
            var updatedcity = await this.repository.CityRepository.UpdateAsync(id,city);
            await this.repository.CityRepository.SaveAsync();
            var response =  mapper.Map<CityResponseDTO>(updatedcity);
            return response;

          
        }

        public async Task<CityPropertyResponseDTO> GetCitywithAllProperty(int id)
        {
            var data = await this.repository.CityRepository.GetCitywithProperty(id);
            var result = mapper.Map<CityPropertyResponseDTO>(data);
            return result;

        }

        
    }
}
