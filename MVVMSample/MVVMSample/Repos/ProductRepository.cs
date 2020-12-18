using MVVMSample.Data;
using MVVMSample.Models;
using MVVMSample.ReposInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.Repos
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(AdvWorksDbContext context)
        {
            DbContext = context;
        }

        private AdvWorksDbContext DbContext { get; set; }

        public List<Product> Get()
        {
            return DbContext.Products.ToList();
        }
    }
}
