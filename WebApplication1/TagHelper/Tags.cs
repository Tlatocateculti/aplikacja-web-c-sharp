using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.TagHelper
{
    public class Tags
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Moja wiadomość")]
        public string Mail { get; set; }



        [StringLength(20)]
        [MinLength(5)]
        public string Surname { get; set; }
    }
}
