using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopEase_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecom_app.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ecom_app.Data.ecom_appContext _context;

        public IndexModel(ILogger<IndexModel> logger, ecom_app.Data.ecom_appContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Category> categories  { get; set; }

        public async Task OnGetAsync()
    {
            categories = await _context.Category
            .Include(c => c.Products)
            .Select(c => new Category
            {
                Id = c.Id,
                Name = c.Name,
                Products = c.Products.Take(4).ToList() 
            })
            .ToListAsync();

        }
    }
}
