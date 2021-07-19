using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor06_handler.Pages
{
    public class Handler2Model : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            Message = "this is post request";
        }
        public void OnPostEdit()
        {
            Message = "this is post edit";
        }
        public void OnPostDelete()
        {
            Message = "this is post delete";
        }
        public void OnPostView()
        {
            Message = "this is post view";
        }
    }
}
