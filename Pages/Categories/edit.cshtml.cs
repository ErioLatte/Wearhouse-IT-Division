using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WearHouse.Data;
using WearHouse.Model;

namespace WearHouse.Pages.Categories
{
    public class editModel : PageModel
    {
        private readonly WearHouseDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public editModel(WearHouseDbContext db)
        {
            _db = db;
        }
        
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }
        public async Task<IActionResult> OnPost(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("product");
            }
            return RedirectToPage("product"); ;
        }
    }
}
