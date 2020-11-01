using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scriptures { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public SelectList Books { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string BookFilter { get; set; }
        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Scripture> scriptureIQ = from s in _context.Scripture
                                                select s;

            IQueryable<string> bookQuery = from s in _context.Scripture
                                           orderby s.Book
                                           select s.Book;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptureIQ = scriptureIQ.Where(s => s.Note.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(BookFilter))
            {
                scriptureIQ = scriptureIQ.Where(s => s.Book == BookFilter);
            }

            switch (sortOrder)
            {
                case "book_desc":
                    scriptureIQ = scriptureIQ.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptureIQ = scriptureIQ.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    scriptureIQ = scriptureIQ.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    scriptureIQ = scriptureIQ.OrderBy(s => s.Book);
                    break;
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scriptures = await scriptureIQ.AsNoTracking().ToListAsync();
        }
    }
}
