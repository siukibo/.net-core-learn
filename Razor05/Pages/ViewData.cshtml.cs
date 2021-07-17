using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor05.Pages
{
    public class ViewDatasModel : PageModel
    {
            
        
            public void OnGet()
            {
                ViewData["MyNumber"] = 2020;
                ViewData["MyString"] = "Hello World, Razor Pages!";
                ViewData["MyObject"] = new Book{
                    Title = "ASP.NET Core for Dummy",
                    Publisher = "Tự học ICT Press",
                    Author = "Mai Chi"
                };
            }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }

    }
}
