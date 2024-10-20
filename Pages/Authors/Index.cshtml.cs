using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Suleap_Anca_Lab2.Data;
using Suleap_Anca_Lab2.Models;

namespace Suleap_Anca_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Suleap_Anca_Lab2.Data.Suleap_Anca_Lab2Context _context;

        public IndexModel(Suleap_Anca_Lab2.Data.Suleap_Anca_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
