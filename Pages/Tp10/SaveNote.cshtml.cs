using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2_web_development_.net_and_database.Pages.Tp10
{
    public class SaveNoteModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        public string SavedFileName { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O conteúdo não pode estar vazio.")]
            public string Content { get; set; }
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string fileName = $"note_{timestamp}.txt";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", fileName);

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            System.IO.File.WriteAllText(filePath, Input.Content);
            SavedFileName = fileName;
            TempData["SavedFileName"] = fileName;

            return RedirectToPage();
        }
    }
}
