using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMv2.ViewModel
{
    public class AnimalCreateViewModel
    {
        [Required]
        public String Name { get; set; }

        [Required]
        [Range(1, 400)]
        public int Weight { get; set; }


    }
}
