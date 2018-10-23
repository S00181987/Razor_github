using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWroksheet.Pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }
        [BindProperty]
        public string Name1 { get; set; }
        [BindProperty]
        public int? Number2 { get; set; }
        [BindProperty]
        public double double1 { get; set; }
        [BindProperty]
        public decimal decimal1 { get; set; }
        [BindProperty]
        public DateTime time { get; set; }
        [BindProperty]
        public DateTime? time2 { get; set; } 
        [BindProperty]
        public bool IsContactAllowed { get; set; }

        public void OnGet()
        {

        }
    }
}