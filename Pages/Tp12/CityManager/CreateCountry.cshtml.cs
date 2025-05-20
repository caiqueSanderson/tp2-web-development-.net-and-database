using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tp2_web_development_.net_and_database.Models;

namespace tp2_web_development_.net_and_database.Pages.Tp12.CityManager
{
    public class CreateCountryModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }
        public Country CreatedCountry { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O nome do país é obrigatório.")]
            [MinLength(3, ErrorMessage = "O nome do país deve ter pelo menos 3 caracteres.")]
            public string CountryName { get; set; }
            [Required(ErrorMessage = "O código do país é obrigatório.")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código do país deve ter exatamente 2 caracteres.")]
            public string CountryCode { get; set; }
        }
        public void OnGet() { }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!string.IsNullOrEmpty(Input.CountryName) && !string.IsNullOrEmpty(Input.CountryCode))
            {
                char firstCharCountry = char.ToUpper(Input.CountryName[0]);
                char firstCharCode = char.ToUpper(Input.CountryCode[0]);

                if (firstCharCountry != firstCharCode)
                {
                    ModelState.AddModelError("Input.CountryCode",
                        "O código do país deve começar com a mesma letra do nome do país.");
                    return Page();
                }
            }

            CreatedCountry = new Country
            {
                CountryName = Input.CountryName,
                CountryCode = Input.CountryCode
            };

            return Page();
        }
    }
}
