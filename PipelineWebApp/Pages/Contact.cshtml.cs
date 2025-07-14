using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstWebApp.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; private set; }

        public void OnPost(string name, string email)
        {
            Message = $"Thank you, {name}! We have received your email.";
        }
    }
}