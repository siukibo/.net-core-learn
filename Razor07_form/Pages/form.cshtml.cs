using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor07_form.Pages
{
    public class formModel : PageModel
    {
        public string Hoten { get; set; }
        public string Email { get; set; }
        public List<string> Sothich { get; set; }
        public string Nganhhoc { get; set; }
        public string Gioitinh { get; set; }
        public string Quequan { get; set; }

        public void OnPost(string hoten, string email, List<string> ck, string r1, string r2, string quequan )
        {
            Hoten = hoten;
            Email = email;
            Sothich = ck;
            Nganhhoc = r1;
            Gioitinh = r2;
            Quequan = quequan;
        }
    }
}
