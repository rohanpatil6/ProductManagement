using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;
using ProductManagement.PMModels;

namespace ProductManagement.Controllers
{
    public class ProductManagementController : Controller
    {
        private readonly ProductManagementContext _context;

        public ProductManagementController(ProductManagementContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new DashboardVM
            {
                Categories = await _context.Categories
                    .Include(c => c.CategoryAttributes)
                    .ThenInclude(ca => ca.Attribute)
                    .ToListAsync(),

                CategoryAttributes = await _context.CategoryAttributes
                    .Include(ca => ca.Category)
                    .Include(ca => ca.Attribute)
                    .ToListAsync(),

                Attributes = await _context.Attributes
                    .Include(a => a.CategoryAttributes)
                    .Include(a => a.ProductAttributeValues)
                    .ToListAsync(),

                Products = await _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.ProductAttributeValues)
                    .ToListAsync(),

                ProductAttributeValues = await _context.ProductAttributeValues
                    .Include(pav => pav.Product)
                    .Include(pav => pav.Attribute)
                    .ToListAsync()
            };

            return View(vm);
        }

        // === CRUD Actions (same as before) ===

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(model);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var cat = await _context.Categories.FindAsync(id);
            if (cat != null)
            {
                _context.Categories.Remove(cat);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttribute(ProductManagement.Models.Attribute model)
        {
            if (ModelState.IsValid)
            {
                _context.Attributes.Add(model);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAttribute(int id)
        {
            var attr = await _context.Attributes.FindAsync(id);
            if (attr != null)
            {
                _context.Attributes.Remove(attr);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryAttribute(CategoryAttribute model)
        {
            if (ModelState.IsValid)
            {
                _context.CategoryAttributes.Add(model);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(model);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var prod = await _context.Products.FindAsync(id);
            if (prod != null)
            {
                _context.Products.Remove(prod);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> SaveProductAttributeValue(ProductAttributeValue model)
        {
            if (ModelState.IsValid)
            {
                _context.ProductAttributeValues.Add(model);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
