using ApnaMakaanAPI.DAL.Entities;

namespace ApnaMakaanAPI.DAL
{
    public class SeedingInitialData
    {

        public static List<City> GetCity()
        {
            return new List<City>
            {
                new City
                {
                    Id = 1,
                    CityName="Pune",
                    CountryName="India"
                },
                new City
                {
                    Id= 2,
                    CityName="Faridabad",
                    CountryName="India"
                },
                new City
                {
                    Id=3,
                    CityName="Nagpur",
                    CountryName="India"
                }
            };
        }

        public static List<FurnishingType> GetFurnishingType()
        {
            return new List<FurnishingType>
            {
                new FurnishingType
                {
                    Id = 1,
                    FurnishingType1="FullyFurnished"
                },

                new FurnishingType
                {
                    Id = 2,
                    FurnishingType1="SemiFurnished"
                },

                new FurnishingType
                {
                    Id = 3,
                    FurnishingType1="UnFurnished"
                }
            };
        }

        public static List<PropertyType> GetPropertyType()
        {
            return new List<PropertyType>
            {
                new PropertyType
                {
                    Id=1,
                    PropertyType1="House",
                },

                 new PropertyType
                {
                    Id=2,
                    PropertyType1="Duplex",
                },

                  new PropertyType
                {
                    Id=3,
                    PropertyType1="Apartment",
                }
            };
        }

        public static List<user> GetUser()
        {
            return new List<user>
            {
                new user
                {
                    Id = 1,
                    UserName="himanshuxx",
                    Password="himanshu123",
                    FullName="Himanshu Tembhurne",
                    PhoneNumber="9876543210",
                    IsAdmin=false,

                },
               new user
                {
                    Id = 2,
                    UserName="satyam",
                    Password="satyam123",
                    FullName="Satyam Verma",
                    PhoneNumber="9876543211",
                    IsAdmin=false,

                },
                new user
                {
                    Id = 3,
                    UserName="isha",
                    Password="isha123",
                    FullName="Isha Mulajkar",
                    PhoneNumber="9876543212",
                    IsAdmin=false,

                },
            };
        }

    }
}
