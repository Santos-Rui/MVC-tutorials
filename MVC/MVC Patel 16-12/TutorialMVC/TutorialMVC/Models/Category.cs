using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        [DisplayName("Display Order")]
        [Required]
        [Range(1,1000000,ErrorMessage = "seu noob, mete um nomero direito")]
        public int DisplayOrder { get; set; }
    }
}
