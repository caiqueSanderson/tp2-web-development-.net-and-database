using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2_web_development_.net_and_database.Pages.Tp9.CityManager
{
    public class ListCitiesModel : PageModel
    {
        public List<string> Cities { get; set; } = new List<string>
        {
            "Rio",
            "S�o Paulo",
            "Bras�lia"
        };
        public void OnGet()
        {
        }
    }
}
