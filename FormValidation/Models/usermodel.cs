using System.ComponentModel.DataAnnotations;
using FormValidation.Attributes;

namespace FormValidation.Models
{
    public class usermodel
    {
        [Required(ErrorMessage ="please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please Enter password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "please Enter Password")]
        [Compare("Password",ErrorMessage ="Please enter password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "please Enter address")]
        public string? Address { get; set; }
        public List<Country> CountryName { get; set; }

        public class Country
        {
            public int Id { get; set; }

            [Required]
            [Display(Name = "Country Name")]
            public string CountryName { get; set; }

            public ICollection<City> City { get; set; }
        }
         public List<City> CityName { get; set; }
        public class City
        {
            public int Id { get; set; }

            [Required]
            [Display(Name = "City Name")]
            public string CityName { get; set; }

            public int CityID { get; set; }

            public Country Country { get; set; }
        }


        [RegularExpression("^[789]\\d{9}$",ErrorMessage = "please Enter Name")]

        public string? Contacts { get; set; }
        [ValidateCheckbox(ErrorMessage = "please except terms")]
        public bool Terms { get; set; }
        



    }
}
