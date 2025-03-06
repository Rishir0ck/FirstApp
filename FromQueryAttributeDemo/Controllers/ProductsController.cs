using FromQueryAttributeDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FromQueryAttributeDemo.Controllers
{
    public class ProductsController : Controller
    {
        public async Task<IActionResult> Index([FromQuery] ProductQueryParameters queryParameters)
        {
            var productService = new ProductService();
            var (products, totalCount) = await productService.GetProductsAsync(queryParameters);

            var categories = Enum.GetValues(typeof(ProductCategory)).
                            Cast<ProductCategory>().Select(c => new { id = c, name = c.ToString() }).ToList();

            var sortOptions = new List<SelectListItem>
            {
                new SelectListItem{ Value = "price", Text = "Price" },
                new SelectListItem{ Value = "dateAdded", Text = "Date Added" }
            };

            var pageSizeOptions = new List<SelectListItem>
            {
                new SelectListItem{ Value = "5", Text = "5" },
                new SelectListItem{ Value = "10", Text = "10" },
                new SelectListItem{ Value = "15", Text = "15" },
                new SelectListItem{ Value = "20", Text = "20" }
            };

            var viewModel = new ProductListViewModel
            {
                Products = products,
                PageNumber = queryParameters.PageNumber,
                PageSize = queryParameters.PageSize,
                Totalpages = (int)Math.Ceiling((double)totalCount / queryParameters.PageSize),
                SearchTerm = queryParameters.SearchTerm,
                Category = queryParameters.Category,
                SortBy = queryParameters.SortBy,
                SortAscending = queryParameters.SortAscending,
                Categories = new SelectList(categories, "id", "name", queryParameters.Category),
                SortOptions = new SelectList(sortOptions, "Value", "Text", queryParameters.SortBy),
                PageSizeOptions = new SelectList(pageSizeOptions, "Value", "Text", queryParameters.PageSize.ToString())
            };





           

            return View(viewModel);
        }

    }
}
