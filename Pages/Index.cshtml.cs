using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor.Models;
using razor.Services;

namespace razor.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private JsonFileProductService ProductService;
    public IEnumerable<Product> Products { get; private set; }

    public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
    {
        ProductService = productService;
        _logger = logger;
    }

    public void OnGet()
    {
        Products = ProductService.GetProducts();
    }
}
