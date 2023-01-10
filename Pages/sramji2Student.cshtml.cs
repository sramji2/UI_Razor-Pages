using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UIAssignmentRazorPages.Pages
{
    public class sramji2StudentModel : PageModel
    {
        public string Message { get; set; }

        [BindProperty]
        
        public string FirstName { get; set; }

        [BindProperty]
        
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Program { get; set; }
        [BindProperty]
        //[RegularExpression(@"^[a-zA-Z]{4}[0-9]{4}$")]
        public string UserID { get; set; }
        [BindProperty]
        
        public string Password { get; set; }
        [BindProperty]
        
        public string ConfirmPassword { get; set; }

        

        public List<SelectListItem> Programs { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="", Text="---> Select Program Here <---"},
            new SelectListItem{Value="BAIST", Text="Bachelor of Applied Information Systems Technology"},
            new SelectListItem{Value="BBA", Text="Bachelor of Business Administration"},
            new SelectListItem{Value="PHOT", Text="Photographic Technology"}
        };
        public void OnGet()
        {
        }
    }
}
