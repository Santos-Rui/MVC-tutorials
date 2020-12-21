using MVVMv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMv2.ViewModel
{
    public class AnimalViewModel
    {
        public AnimalViewModel()
        { }

        public AnimalViewModel(IEnumerable<Animal> AnimalList)
        {
            Animals = AnimalList;
        }


        public IEnumerable<Animal> Animals { get; set; }

        public void  setList(IEnumerable<Animal> ani)
        {
            Animals = ani;
        }

    }
}
