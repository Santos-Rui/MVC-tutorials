using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace RestAPI.Models
{
    public class GlossaryItem
    {
        [Key]
        public long Id { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }
    }
}
