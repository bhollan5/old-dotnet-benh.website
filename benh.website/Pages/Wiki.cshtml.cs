using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace benh.website.Pages
{
    public class WikiModel : PageModel
    {
        public string Title { get; set; }
        public void OnGet(string title)
        {
            Title = title;
        }
    }
}
