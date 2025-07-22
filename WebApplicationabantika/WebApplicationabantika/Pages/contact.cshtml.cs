using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationabantika.Pages
{
    public class contactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Subject { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public bool HasData { get; set; } = false;

        public void OnPost()
        {
            HasData = true;
            // At this point, Name, Email, Subject, Message are all populated from the form.
        }
    }
}
