using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2_web_development_.net_and_database.Pages.Tp9.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }
        public string SubmittedCityName { get; set; }
        public class InputModel
        {
            [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
            [MinLength(3, ErrorMessage = "O nome da cidade deve ter pelo menos 3 caracteres.")]
            public string CityName { get; set; }
        }
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            SubmittedCityName = Input.CityName;
        }
    }
}
