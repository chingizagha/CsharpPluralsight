using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _appDbContext;


        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
        }

        public ViewResult List()
        {
            IEnumerable<Pie> pies;
            //Category category;

            pies = _pieRepository.AllPies.OrderBy(p => p.PieId);


            return View(new AdminPiesListViewModel
            {
                Pies = pies 
            });
        }

        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(
            [Bind(include: "Name, ShortDescription, LongDescription, Price, ImageUrl, ImageThumbnailUrl, IsPieOfTheWeek, InStock, CategoryId")] Pie pie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pieRepository.Add(pie);
                    await _appDbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(List));
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(pie);
        }

        public async Task<IActionResult> Edit(int pieId, [Bind("PieId,,Name,ShortDescription,LongDescription,Price,ImageUrl,ImageThumbnailUrl,IsPieOfTheWeek,InStock,CategoryId,Category")] Pie pie)
        {
            if (pieId != pie.PieId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _pieRepository.Update(pie);
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
            return View(pie);
        }
    }
}

