using ApnaMakaanAPI.DAL.DBContext;
using ApnaMakaanAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApnaMakaanAPI.DAL.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<bool> DeleteAsync(int id);
        Task<T> UpdateAsync(int id, T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> condition);
        Task<int> SaveAsync();
        
    }

    public abstract class RepositoryBase<T> : IBaseRepository<T> where T : class
    {
        private readonly ApnaMakaanDBContext dbContext;
        private readonly DbSet<T> dbSet;

        public RepositoryBase(ApnaMakaanDBContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            var result = await this.dbSet.AddAsync(entity);
            return result.Entity;
        }

        public  async Task<bool> DeleteAsync(int id)
        {

            var data = await this.dbSet.FindAsync(id);
            if (data != null)
            {
                var result = this.dbSet.Remove(data);
                await this.dbContext.SaveChangesAsync();
                return await Task.FromResult(result.Entity is not null);
                
            }
            return false;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = this.dbSet.AsEnumerable();
            return await Task.FromResult(result);
        }

        public async Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> condition)
        {
            var result = this.dbSet.Where(condition);
            return await Task.FromResult(result.AsEnumerable());
        }

        public virtual async Task<T> GetById(int id)
        {
            var data =  await this.dbSet.FindAsync(id);
            if (data!=null )
            {
                return data;
            }
            return null;
        }

        public async Task<T> UpdateAsync(int id , T entity)
        {
            var data = await this.dbSet.FindAsync(id);
            if (data != null)
            {
                dbContext.Entry(data).CurrentValues.SetValues(entity);
                return entity;
            }
            return null;
        }

        public async Task<int> SaveAsync()
        {
           return await this.dbContext.SaveChangesAsync();
        }
    }


    public interface ICityRepository : IBaseRepository<City> 
    {
        Task<City> GetCitywithProperty(int id);
    }

    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        private readonly ApnaMakaanDBContext dbContext;

        public CityRepository(ApnaMakaanDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<City>GetCitywithProperty(int id)
        {
            var data = await this.dbContext.Cities.Include(x => x.Properties).ThenInclude(x => x.FurnishingType).Include(x => x.Properties).ThenInclude(x=>x.PropertyType).ToListAsync();
            var result = data.FirstOrDefault(x => x.Id == id);
            if (result is null) return null;
            
            return result;
        }
    }


    public interface IFurnishingTypeRepository : IBaseRepository<FurnishingType>
    {
        Task<FurnishingType> GetFurnishingwithProperty(int id);
    }

    public class FurnishingTypeRepository : RepositoryBase<FurnishingType>, IFurnishingTypeRepository
    {
        private readonly ApnaMakaanDBContext dbContext;
        

        public FurnishingTypeRepository(ApnaMakaanDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<FurnishingType> GetFurnishingwithProperty(int id)
        {
            var data = await this.dbContext.FurnishingTypes.Include(x => x.Properties).ThenInclude(x => x.PropertyType).ToListAsync();
            var result = data.FirstOrDefault(x => x.Id == id);
            if (result is null) return null;

            return result;
        }
    }

    public interface IImageRepository : IBaseRepository<Image> { }

    public class ImageRepository : RepositoryBase<Image>, IImageRepository
    {

        public ImageRepository(ApnaMakaanDBContext dbContext) : base(dbContext)
        {}

      
    }

    public interface IPropertyRepository : IBaseRepository<Property> { }

    public class PropertyRepository : RepositoryBase<Property>, IPropertyRepository
    {
        private readonly ApnaMakaanDBContext dbContext;

        public PropertyRepository(ApnaMakaanDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public override Task<IEnumerable<Property>> GetAllAsync()
        {
            var result =  this.dbContext.Properties.Include(x => x.PropertyType).Include(x => x.FurnishingType)
                .Include(x => x.City).AsNoTracking().AsEnumerable();
            return Task.FromResult(result);
        }

        public override async Task<Property> GetById(int id)
        {

            var data = await this.dbContext.Properties.Include(x => x.PropertyType).Include(x => x.FurnishingType).Include(x => x.City).ToListAsync();
            var result = data.FirstOrDefault(x => x.Id == id);
            if (result is null) return null;

            return result;
        }

    }

    public interface IPropertyTypeRepository : IBaseRepository<PropertyType> 
    {
        Task<PropertyType> GetPropertyTypewithProperty(int id);
    }

    public class PropertyTypeRepository : RepositoryBase<PropertyType>, IPropertyTypeRepository
    {
        private readonly ApnaMakaanDBContext dbContext;

        public PropertyTypeRepository(ApnaMakaanDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<PropertyType> GetPropertyTypewithProperty(int id)
        {
            var data = await this.dbContext.PropertyTypes.Include(x => x.Properties).ThenInclude(x => x.FurnishingType).ToListAsync();
            var result = data.FirstOrDefault(x => x.Id == id);
            if (result is null) return null;

            return result;
        }
    }

    public interface IUserRepository : IBaseRepository<user> 
    {
        Task<user> GetUserwithProperty(int id);
    }

    public class UserRepository : RepositoryBase<user>, IUserRepository
    {
        private readonly ApnaMakaanDBContext dbContext;

        public UserRepository(ApnaMakaanDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<user> GetUserwithProperty(int id)
        {
            var data = await this.dbContext.Users.Include(x => x.Properties).ThenInclude(x => x.FurnishingType).Include(x => x.Properties).ThenInclude(x => x.PropertyType).ToListAsync();
            var result = data.FirstOrDefault(x => x.Id == id);
            if (result is null) return null;

            return result;
        }
    }



    public interface IRepositoryWrapper
    {
        public ICityRepository CityRepository {  get; set; }
        public IFurnishingTypeRepository FurnishingTypeRepository { get; set; }
        public IImageRepository ImageRepository { get; set; }
        public IPropertyRepository PropertyRepository { get; set; }
        public IPropertyTypeRepository PropertyTypeRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

    }

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApnaMakaanDBContext dbContext;

        public ICityRepository CityRepository { get ; set ; }
        public IFurnishingTypeRepository FurnishingTypeRepository { get; set; }
        public IImageRepository ImageRepository { get; set; }
        public IPropertyRepository PropertyRepository { get; set; }
        public IPropertyTypeRepository PropertyTypeRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

        public RepositoryWrapper(ApnaMakaanDBContext dbContext)
        {
            this.dbContext = dbContext;

            CityRepository = new CityRepository (dbContext);
            FurnishingTypeRepository = new FurnishingTypeRepository(dbContext);
            ImageRepository = new ImageRepository (dbContext);  
            PropertyRepository = new PropertyRepository (dbContext);    
            PropertyTypeRepository = new PropertyTypeRepository (dbContext);
            UserRepository = new UserRepository (dbContext);
        }
    }


}
