using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UIAssignmentRazorPages.Model.Domain;
using UIAssignmentRazorPages.Model.TechnicalServices;

namespace UIAssignmentRazorPages.Pages.Categories
{
    public class sramji2CategoriesModel : PageModel
    {
        public List<NorthwindCategory> Categories { get; set; }
        public void OnGet()
        {
            NorthwindHandler requestDirector = new NorthwindHandler();
            Categories = requestDirector.FindAllCategories();
        }
    }
}
