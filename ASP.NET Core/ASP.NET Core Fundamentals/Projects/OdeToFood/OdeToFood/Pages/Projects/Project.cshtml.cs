using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFood.Pages.Projects
{
    public class ProjectModel : PageModel
    {

        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Hi";
        }
    }
}
