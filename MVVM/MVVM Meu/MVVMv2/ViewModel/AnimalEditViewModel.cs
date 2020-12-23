using MVVMv2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMv2.ViewModel
{
    public class AnimalEditViewModel
    {

        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        [Range(1, 400)]
        public int Weight { get; set; }

        public AnimalEditViewModel(Animal anim)
        {
            Name = anim.Name;
            Weight = anim.Weight;
        }
    }
}
