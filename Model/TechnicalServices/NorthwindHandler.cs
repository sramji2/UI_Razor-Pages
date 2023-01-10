using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIAssignmentRazorPages.Model.Domain;

namespace UIAssignmentRazorPages.Model.TechnicalServices
{
    public class NorthwindHandler
    {
        public List<NorthwindCategory> FindAllCategories()
        {
            Categories categoryManager = new Categories();
            return categoryManager.GetCategories();
        }
    }
}
