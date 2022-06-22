using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public TagHelper.Tags Tags { get; set; }

        public TagHelper.Product Product { get; set; }


        private readonly ILogger<IndexModel> _logger;

        public Models.Films tmp;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Tags = new TagHelper.Tags();
            
            tmp = new Models.Films();
            
            tmp.Name = "Coś tam";
            tmp.Count = 13;
            tmp.AddFilm();

            Product = new TagHelper.Product();
        }
    }
}
