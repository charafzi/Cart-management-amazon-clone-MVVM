using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShopEase_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public List<Product> SearchResults { get; set; }

        public int currentPage { get; set; } = 1;
        public int pageSize { get; set; } = 10;  
        public int totalPages { get; set; }

        public void OnGet(string? query, string? category, decimal? minPrice, decimal? maxPrice, int currentPage = 1)
        {
            Query = query;
            SelectedCategory = category;

            IQueryable<Product> products = _context.Product.Include(c => c.Category);

            //filter by keyword
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


             SearchResults = products.ToList();
            //int totalProducts = products.Count();
            //totalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);

            //if (currentPage < 1)
            //{
            //    currentPage = 1;
            //}
            //if (currentPage > totalPages)
            //{
            //    currentPage = totalPages;
            //}

            //SearchResults = products
            //    .Skip((currentPage - 1) * pageSize)  
            //    .Take(pageSize)                      
            //    .ToList();
        }
    }
}
