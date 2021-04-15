using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using codefirstrazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace codefirstrazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly newdbContext _db;
        public IndexModel(newdbContext db)
        {
            this._db = db;

        }
        public List<Book> Books { get; set; }
        public void OnGet()
        {
            Books = _db.Books.ToList();
        }
    }
}
