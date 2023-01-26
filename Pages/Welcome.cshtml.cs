using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace Welcome.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Message { get; set; }
        
        public void OnPostSearch(string searchFor)
        {
            Message = $"You searched for {searchFor}";
        }

        public void OnPostRegister(string email)
        {
            Message = $"You registered {email} for newsletter updates. ";
        }

        public DateTime Today { get; set; } = DateTime.Now.Date;
    }
}
