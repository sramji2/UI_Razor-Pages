using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UIAssignmentRazorPages.Pages
{
    public class sramji2SignOnModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        [Required]
        [RegularExpression(@"^[a-zA-Z]{4}[0-9]{4}$", ErrorMessage = "User ID must start with 4 letters followed by 4 numbers")]
        //[StringLength(8, MinimumLength = 8, ErrorMessage = "Maximum 8 characters")]
        public string userID { get; set; }

        [BindProperty]
        [Required]
        [RegularExpression(@"^.{6,}$", ErrorMessage = "Minimum 6 characters required")]
        public string password { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

            if (ModelState.IsValid)
                Message = $"User ID: {userID} , Password: {password}";
        }
    }
}
