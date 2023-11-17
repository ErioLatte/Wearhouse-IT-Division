using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WearHouse.Data;
using WearHouse.Model;

namespace WearHouse.Pages.Categories;

public class deleteModel : PageModel
{
    private readonly WearHouseDbContext _db;
    [BindProperty]
    public Category Category { get; set; }
    public deleteModel(WearHouseDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
    }
    public async Task<IActionResult> OnPost(Category category)
    {
        var categoryFromDb = _db.Category.Find(Category.Id);
        if (categoryFromDb != null)
        {
            _db.Category.Remove(categoryFromDb);
            await _db.SaveChangesAsync();
            return RedirectToPage("product");
        }
        return RedirectToPage("product");
    }
}
