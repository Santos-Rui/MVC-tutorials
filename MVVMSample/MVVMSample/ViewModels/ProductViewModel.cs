using MVVMSample.Models;
using MVVMSample.ReposInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.ViewModels
{
    public class ProductViewModel
    {
        /// <summary>
        /// NOTE: You need a parameterless     
        /// constructor for post-backs in MVC    
        /// </summary>
        public ProductViewModel()
        { }

        public ProductViewModel(IProductRepository repository)
        {
            Repository = repository;
        }

        public IProductRepository Repository { get; set; }
        public List<Product> Products { get; set; }

        public void HandleRequest()
        {
            LoadProducts();
        }

        protected virtual void LoadProducts()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                Products = Repository.Get().OrderBy(p => p.Name).ToList();
            }
        }
    }
}
