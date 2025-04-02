using internetShop.Areas.Admin.Models;
using internetShop.DataAccess.Repository.CategoryAccess;
using internetShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace internetShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var product = _unitOfWork.ProductRepository.GetAllWithCategories();
            return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = _unitOfWork.CategoryRepository.GetAll()
                .Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepository.Add(product.ProductVM);
                _unitOfWork.Save();

                TempData["SuccessMessage"] = "Запись успешно создана!";
                return RedirectToAction("Index");
            }
            product.CategoryList = _unitOfWork.CategoryRepository.GetAll()
                .Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });
            TempData["ErrorMessage"] = "Возникла ошибка";
            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var product = new ProductViewModel
            {
                ProductVM = _unitOfWork.ProductRepository.GetById(x => x.Id == id),
                CategoryList = _unitOfWork.CategoryRepository.GetAll()
                .Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                })
            };
            if (product.ProductVM == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepository.Update(product.ProductVM);
                _unitOfWork.Save();

                TempData["SuccessMessage"] = "Запись успешно изменена!";
                return RedirectToAction("Index");
            }
            product.CategoryList = _unitOfWork.CategoryRepository.GetAll()
                .Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });
            TempData["ErrorMessage"] = "Возникла ошибка";
            return View(product);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var product = _unitOfWork.CategoryRepository.GetById(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if (product == null)
            {
                TempData["ErrorMessage"] = "Возникла ошибка";
                return NotFound();
            }
            _unitOfWork.ProductRepository.Delete    (product);
            _unitOfWork.Save();
            TempData["SuccessMessage"] = "Запись успешно создана!";

            return RedirectToAction("Index");
        }
    }
}
