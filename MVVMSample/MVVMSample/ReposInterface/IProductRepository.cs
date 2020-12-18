using MVVMSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.ReposInterface
{
    public interface IProductRepository
    {
        List<Product> Get();
    }
}
