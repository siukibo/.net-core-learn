using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor05.Pages
{
    public class IndexModel : PageModel
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public string SayGoodbye() => $"Hello, {FullName}! I'm in the model class";

        public void OnGet()
        { 
                FirstName = "Donald";
                LastName = "Trump";
            
        }
    

    }
}
