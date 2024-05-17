using ApnaMakaanAPI.BLL.DTOs;
using ApnaMakaanAPI.DAL.Entities;
using ApnaMakaanAPI.DAL.Repositories;
using AutoMapper;

namespace ApnaMakaanAPI.BLL.Services
{
    public interface IPropertyService : IBaseService<PropertyRequestDTO, PropertyResponseDTO>
    {
        Task<IEnumerable<PropertyResponseDTO>> GetPropertiesForRent();
        Task<IEnumerable<PropertyResponseDTO>> GetPropertiesForSale();
    }

    public class PropertyService : IPropertyService
    {
        private readonly IRepositoryWrapper repository;
        private readonly IMapper mapper;

        public PropertyService(IRepositoryWrapper repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<PropertyResponseDTO> Add(PropertyRequestDTO requestDTO)
        {
            var data = mapper.Map<Property>(requestDTO);
            var property = await this.repository.PropertyRepository.CreateAsync(data);
           await this.repository.PropertyRepository.SaveAsync();
            var result = mapper.Map<PropertyResponseDTO>(property);
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var del =  await this.repository.PropertyRepository.DeleteAsync(id);
            await this.repository.PropertyRepository.SaveAsync();
            return del;
        }

        public async Task<IEnumerable<PropertyResponseDTO>> GetAll()
        {
            var data = await this.repository.PropertyRepository.GetAllAsync();
            var result = mapper.Map<IEnumerable<PropertyResponseDTO>>(data);
            await this.repository.PropertyRepository.SaveAsync();
            return result;
        }

        public async Task<PropertyResponseDTO> GetById(int id)
        {
            var data = await this.repository.PropertyRepository.GetById(id);
            var result = mapper.Map<PropertyResponseDTO>(data);
            return result;
        }

        public async Task<PropertyResponseDTO> Update(int id, PropertyRequestDTO requestDTO)
        {
            var property = mapper.Map<Property>(requestDTO);
            property.Id= id;
            var updatedproperty=await this.repository.PropertyRepository.UpdateAsync(id,property);
            await this.repository.PropertyRepository.SaveAsync();
            var response = mapper.Map<PropertyResponseDTO>(updatedproperty);
            return response;
        }


        public async Task<IEnumerable<PropertyResponseDTO>>GetPropertiesForSale()
        {
            var data = await this.repository.PropertyRepository.GetAllAsync();
            var result = data.Where(p => p.SellRent == 1).Select(p => mapper.Map<PropertyResponseDTO>(p));
            await this.repository.PropertyRepository.SaveAsync();
            return result;
        }

        public async Task<IEnumerable<PropertyResponseDTO>>GetPropertiesForRent()
        {
            var data = await this.repository.PropertyRepository.GetAllAsync();
            var result = data.Where(p => p.SellRent == 2).Select(p => mapper.Map<PropertyResponseDTO>(p));
            await this.repository.PropertyRepository.SaveAsync();
            return result;
        }
    }
}
/////addd image dto