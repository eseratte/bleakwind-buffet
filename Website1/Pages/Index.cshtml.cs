/* Author: Ethan Seratte
 * Name: Index.cshtml.cs
 * Purpose: model framework for website filter/search function
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, int? CalorieMin, int?CalorieMax, float? PriceMin, float? PriceMax, string[] Categories)       
        {
            Items = Menu.All;
            //search menu for matching search terms
            Items = Menu.Search(SearchTerms);

            Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCategory(Items, Categories);

            ItemCategories = Request.Query["ItemCategories"];
        }

        public string[] ItemCategories { get; set; }

        public IEnumerable<IOrderItem> Items { get; set; }
        public string SearchTerms { get; set; }
        public string[] ItemTypes { get; set; }
    }
}
