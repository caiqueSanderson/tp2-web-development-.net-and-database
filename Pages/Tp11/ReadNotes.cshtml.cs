using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tp2_web_development_.net_and_database.Pages.Tp11
{
    public class ReadNotesModel : PageModel
    {
        public List<string> FileNames { get; set; } = new();
        public string FileContent { get; set; }
        public string SelectedFile { get; set; }

        public void OnGet(string? file)
        {
            string filesPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");

            if (!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
            }

            FileNames = Directory.GetFiles(filesPath, "*.txt")
                .Select(Path.GetFileName)
                .ToList();

            if (!string.IsNullOrEmpty(file))
            {
                string filePath = Path.Combine(filesPath, file);

                if (System.IO.File.Exists(filePath))
                {
                    FileContent = System.IO.File.ReadAllText(filePath);
                    SelectedFile = file;
                }
            }
        }
    }
}
