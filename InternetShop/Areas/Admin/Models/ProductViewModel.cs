using internetShop.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace internetShop.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public Product ProductVM { get; set; } = new Product();
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; } = new List<SelectListItem>();    
    }
}
