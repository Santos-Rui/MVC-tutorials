using Microsoft.AspNetCore.Mvc;
using MVVMSample.ReposInterface;
using MVVMSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;
        private readonly ProductViewModel _viewModel;

        public ProductController(IProductRepository repo, ProductViewModel vm)
        {
            _repo = repo;
            _viewModel = vm;
        }

        public IActionResult Products()
        {
            // Load products
            _viewModel.HandleRequest();
            return View(_viewModel);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            _viewModel.HandleRequest();
            return View(_viewModel);
        }
    }
}
