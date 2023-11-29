using EchoRange.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;

namespace EchoRange.Strona
{
    public class IndexModel : PageModel
    {
        private readonly MyDbContext _context;

        public IndexModel(MyDbContext context)
    {
        _context = context;
    }
        public List<Odleglosci> Pomiar { get; set; }

        public async Task OnGetAsync()
        {
            Pomiar = await _context.Odleglosc.ToListAsync();
        }
    }
}
