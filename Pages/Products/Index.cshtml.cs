using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShopEase_app.Models;
using ecom_app.Data;

namespace ecom_app.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ecom_app.Data.ecom_appContext _context;

        public IndexModel(ecom_app.Data.ecom_appContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Category).ToListAsync();
        }
    }
}
