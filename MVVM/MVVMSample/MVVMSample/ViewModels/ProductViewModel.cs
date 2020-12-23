using MVVMSample.Models;
using MVVMSample.ReposInterface;
using MVVMSample.ViewModels.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        /// <summary>
        /// NOTE: You need a parameterless     
        /// constructor for post-backs in MVC    
        /// </summary>
        public ProductViewModel() : base()
        {
            SearchEntity = new ProductSearch();
        }

        public ProductViewModel(IProductRepository repository) : base()
        {
            Repository = repository;
            SearchEntity = new ProductSearch();
        }


        public ProductSearch SearchEntity { get; set; }
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
