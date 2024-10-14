using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ecom_app.Components.SearchBar
{
    public class SearchBarViewComponent : ViewComponent
    {

        private readonly ecom_app.Data.ecom_appContext _context;

        public SearchBarViewComponent(ecom_app.Data.ecom_appContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Category.ToListAsync();
            return View(categories); 
        }
    }
}
