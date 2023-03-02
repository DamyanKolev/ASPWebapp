using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleRental;
using VehicleRental.Models;


namespace ASPWebapp.Pages.Products;

public class IndexModel : PageModel
{
    [BindProperty]
    public Product? Product { get; set; }
    private readonly DatabaseContext _dbContext;
    public IList<Product> Products { get; set; } = default!;

    public IndexModel(DatabaseContext databaseContext)
    {
        _dbContext = databaseContext;
    }

    public void OnGet()
    {
        if (_dbContext.Products != null)
        {
            Products = _dbContext.Products.ToList();
        }
    }

    public IActionResult OnPostCreate()
    {
        if (!ModelState.IsValid)
        {
            // return RedirectToPage("../products/index");
        }

        _dbContext.Products.Add(Product);
        _dbContext.SaveChangesAsync();

        return RedirectToPage("../products/index");
    }

    public IActionResult OnPostDelete(int id)
    {
        _dbContext.Remove(_dbContext.Products.Find(id));

        _dbContext.SaveChangesAsync();

        return RedirectToPage("../products/index");
    }
}
