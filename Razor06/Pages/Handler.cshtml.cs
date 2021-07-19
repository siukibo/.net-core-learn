using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor06.Pages
{
    public class HandlerModel : PageModel
    {
        public string Message { get; set; } 

        public void OnGet()
        {
            Message = "this is GET request";
        }
        public void OnPost()
        {   
            Message = "this is post request" ;
        }
    }
}
