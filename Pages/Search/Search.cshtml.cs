using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShopEase_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ecom_app.Pages.Search
{
    public class SearchModel : PageModel
    {
        private readonly ecom_app.Data.ecom_appContext _context;

        public SearchModel(ecom_app.Data.ecom_appContext context)
        {
            _context = context;
        }

        public string Query { get; set; }
        public string SelectedCategory { get; set; }
        public string Sort { get; set; }

        public List<Product> SearchResults { get; set; }
        public IQueryable<Product> products { get; set; }

        public int currentPage { get; set; } = 1;
        public int totalPages { get; set; }
        public int productsPerPage { get; set; } = 10; 
        public int totalProducts { get; set; }


        public async Task OnGetAsync(string? query, string? category, decimal? minPrice, decimal? maxPrice, int currentPage = 1)
        {
            Query = query;
            SelectedCategory = category;
            products = null;
            products = _context.Product.Include(c => c.Category);

            if (!string.IsNullOrEmpty(Query))
            {
                products = products.Where(p => p.Name.Contains(Query) || p.Description.Contains(Query));
            }

            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrEmpty(SelectedCategory))
            {
                int categoryId = int.Parse(SelectedCategory);
                products = products.Where(p => p.CategoryId == categoryId);
            }

            totalProducts = products.Count();
            int totalItems = await products.CountAsync();
            totalPages = (int)Math.Ceiling(totalItems / (double)productsPerPage);

            SearchResults = await products
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .ToListAsync();


            //SearchResults = products.ToList();
        }

        public async Task<IActionResult> OnPostSortAsync(string sort, string query, string category, decimal? minPrice, decimal? maxPrice, int currPage)
        {
            Sort = sort;
            currentPage = currPage;

            IQueryable<Product> products = _context.Product.Include(c => c.Category);

            if (!string.IsNullOrEmpty(query))
            {
                products = products.Where(p => p.Name.Contains(query) || p.Description.Contains(query));
            }

            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrEmpty(category))
            {
                int categoryId = int.Parse(category);
                products = products.Where(p => p.CategoryId == categoryId);
            }

            switch (Sort)
            {
                case "price_asc":
                    products = products.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price);
                    break;
            }

            int totalItems = await products.CountAsync();
            totalPages = (int)Math.Ceiling(totalItems / (double)productsPerPage);

            SearchResults = await products
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .ToListAsync();

            return Page();
        }


    }
}
