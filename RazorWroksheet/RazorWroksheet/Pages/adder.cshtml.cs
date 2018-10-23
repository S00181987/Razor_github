using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWroksheet.Pages
{
    
    public class adderModel : PageModel
    {
        public string Message { get; set; } = " ";

        public void OnGet()
        {

        }
        public void OnPost(int num1,int num2)
        {
            int total = num1 + num2;
            Message = Convert.ToString (num1+"+"+num2+"="+total); 
        }
    }
}