using static FormValidation.Models.usermodel;
namespace FormValidation.Models;

    public class countryCity
    {
       public interface ICountryCity 
        {  
     List<Country> GetCategories();

    }

        public class Repository : ICountryCity
        {
           

            public List<Country> GetCategories()
            {
                List<Country> categories = new List<Country>()
         {
             new Country(){ Id=101, CountryName="India",
                 City= new List<City>(){
                 new City(){ Id=1001, CityName="UP"},
                 new City(){ Id=1002, CityName="Delhi"},
                 new City(){ Id=1003, CityName="Haryana"},
                 }
             },
             new Country(){ Id=102, CountryName="USA",
                 City= new List<City>(){
                 new City(){ Id=1001, CityName="Newyork"},
                 new City(){ Id=1002, CityName="Chicago"},
                 new City(){ Id=1003, CityName="Mosco"},
                 }
             },
             new Country(){ Id=103, CountryName="Pakistan",
                 City= new List<City>(){
                 new City(){ Id=1001, CityName="Karachi"},
                 new City(){ Id=1002, CityName="Lahor"},
                 new City(){ Id=1003, CityName="Balochistan"},
                 }
             },

         };

                return categories;
            }


        }
}
