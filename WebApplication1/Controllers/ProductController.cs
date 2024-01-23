using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller

    {
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public FakeDB dB = new FakeDB();

        // GET: ProductController
        public ActionResult Index()
        {
            var viewModel = new ProductListViewModel();
            viewModel.Products = _mapper.Map<List<ProductViewModel>>(dB.Products);
            return View("Views/ActualViews/Products.cshtml", viewModel);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View("Views/ActualViews/CreateProduct.cshtml");
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel viewModel)
        {
            try
            {
                Product product = _mapper.Map<Product>(viewModel);
                dB.Products.Add(product);
                var viewModelProducts = new ProductListViewModel();
                viewModelProducts.Products = _mapper.Map<List<ProductViewModel>>(dB.Products);
                return View("Views/ActualViews/Products.cshtml", viewModelProducts);
            }
            catch
            {
                return View();
            }
        }

        

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            //var filteredTags = new int[] { 1, 20 };

            //var product = dB.Products.Where(p => p.PackQuantity <= 20 && p.PackQuantity >= 10 );
            //var product = dB.Products.Where(p => p.Category.Name == "Category2");
            //var product = dB.Products.Where(p => p.ProductColors.Any(y => y.ColorName == "Red"));
            //var product = dB.Products.Where(p => (p.Category.Name == "Category2") && (p.BrandName == "Brand2"));
            //var product = dB.Products.Where(p => (p.Length % 2 == 0) || (p.Weight % 2 == 0));
            //var product = dB.Products.Where(p => (p.Length + p.Weight  == 21));
            //var product = dB.Products.Where(p => p.ProductColors.Any(y => y.ColorName == "Purple") && (p.BrandName == "Brand3"));
            //var product = dB.Products.Where(p => p.Price <= 140 && p.Price >= 80 && p.ProductColors.Any(y => y.ColorName == "Red"));
            //var product = dB.Products.Where(p => p.Name.Contains("7"));
            var product = dB.Products.Where(p => p.Category.Name == "Category4").FirstOrDefault();
            
            var viewModelProducts = new ProductListViewModel();
            var Products = _mapper.Map<ProductViewModel>(product);
            viewModelProducts.Products.Add(Products);
            return View("Views/ActualViews/Products.cshtml", viewModelProducts);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = dB.Products.Where(p => p.Id == id).FirstOrDefault();
            dB.Products.Remove(product);
            var viewModelProducts = new ProductListViewModel();
            viewModelProducts.Products = _mapper.Map<List<ProductViewModel>>(dB.Products);
            return View("Views/ActualViews/Products.cshtml", viewModelProducts);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
