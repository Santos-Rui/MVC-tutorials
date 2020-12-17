using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTutorialV2.Models
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String nome { get; set; }

        [Required]
        [Range(18,65)]
        public int idade { get; set; }
    }
}
