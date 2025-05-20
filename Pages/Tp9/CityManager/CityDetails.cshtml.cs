using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2_web_development_.net_and_database.Pages.Tp9.CityManager
{
    public class CityDetailsModel : PageModel
    {
        public string CityName { get; set; }
        public void OnGet(string cityName) 
        {
            CityName = cityName;
        }
    }
}
