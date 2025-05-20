using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2_web_development_.net_and_database.Pages.Tp1.CityManager
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public string CityName { get; set; }

        public void OnGet()
        {
        }

        public void OnPost() 
        { 
        }
    }
}
