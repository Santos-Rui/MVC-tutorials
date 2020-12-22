using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.Models
{
    public partial class ProductSearch
    {
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "List Price Greater Than or Equal to")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ListPrice { get; set; }
    }
}