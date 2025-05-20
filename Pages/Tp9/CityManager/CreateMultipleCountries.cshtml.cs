using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using tp2_web_development_.net_and_database.Models;


namespace tp2_web_development_.net_and_database.Pages.Tp9.CityManager
{
    public class CreateMultipleCountriesModel : PageModel
    {
        [BindProperty]
        public List<InputModel> CountriesInput { get; set; } = new List<InputModel>();

        public List<Country> CreatedCountries { get; set; } = new List<Country>();

        public class InputModel
        {
            [Required(ErrorMessage = "O nome do país é obrigatório.")]
            [MinLength(3, ErrorMessage = "O nome do país deve ter pelo menos 3 caracteres.")]
            public string CountryName { get; set; }

            [Required(ErrorMessage = "O código do país é obrigatório.")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código do país deve ter exatamente 2 caracteres.")]
            public string CountryCode { get; set; }
        }
        public void OnGet()
        {
            for (int i = 0; i < 5; i++)
            {
                CountriesInput.Add(new InputModel());
            }
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            foreach (var input in CountriesInput)
            {
                CreatedCountries.Add(new Country
                {
                    CountryName = input.CountryName,
                    CountryCode = input.CountryCode
                });
            }
        }
    }
}
