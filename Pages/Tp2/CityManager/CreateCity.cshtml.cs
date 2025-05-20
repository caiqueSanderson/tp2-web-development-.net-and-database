using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2_web_development_.net_and_database.Pages.Tp2.CityManager
{
    public class CreateCityModel : PageModel
    {
        public string SubmittedCityName { get; set; }
        public void OnGet()
        {
        }

        public void OnPost(string cityName) 
        { 
            SubmittedCityName = cityName;
        }
    }
}
