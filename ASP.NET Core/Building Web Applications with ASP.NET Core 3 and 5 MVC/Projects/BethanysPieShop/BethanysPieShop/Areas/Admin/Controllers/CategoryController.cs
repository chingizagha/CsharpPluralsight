using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _appDbContext;

        public CategoryController(ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
        }

        public ViewResult List()
        {
            IEnumerable<Category> category;

            category = _categoryRepository.AllCategories.OrderBy(c => c.CategoryId);

            return View(new AdminCategoriesListViewModel
            {
                Categories = category
            });
        }

        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind(include: "CategoryName, Description")]Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoryRepository.Add(category);
                    await _appDbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(List));
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int CategoryId)
        {
            var category = _categoryRepository.GetCategoryById(CategoryId);
            if (category == null)
                return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int categoryId, [Bind("CategoryName, Description")] Category category)
        {
            if (categoryId != category.CategoryId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _categoryRepository.Update(category);
                    await _appDbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(List));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(category);
        }
    }
}
