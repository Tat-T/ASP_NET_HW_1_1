using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace MyRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public int DayOfYear { get; private set; }
        public string CurrentDate { get; }
        public string RandomLetter { get; private set; }

        public void OnGet()
        {
            DayOfYear = DateTime.Now.DayOfYear;

        }
        public IndexModel()
        {
            CurrentDate = DateTime.Now.ToShortDateString();
            
            Random random = new Random();
            int index = random.Next(0, 26); // 26 букв в английском алфавите
            RandomLetter = ((char)('A' + index)).ToString(); // Преобразуем индекс в букву
        }

        
    }
}