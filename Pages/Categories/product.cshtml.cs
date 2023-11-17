using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WearHouse.Data;
using WearHouse.Model;

namespace WearHouse.Pages.Categories;

public class productModel : PageModel
{
    private readonly WearHouseDbContext _db;
    public IEnumerable<Category> Categories { get; set; }

	[BindProperty]
	public Category Category { get; set; }

	public productModel(WearHouseDbContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        Categories = _db.Category;
    }
    

	public async Task<IActionResult> OnPost(Category category)
	{
        await _db.Category.AddAsync(category);
        await _db.SaveChangesAsync();
        
		return RedirectToPage("product");
	}
}
