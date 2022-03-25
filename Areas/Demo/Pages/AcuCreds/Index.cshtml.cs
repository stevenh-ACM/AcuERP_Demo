#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcuERP_Demo.Data;
using AcuERP_Demo.Models;

namespace AcuERP_Demo.Areas.Demo.Pages.AcuCreds
{
    public class IndexModel : PageModel
    {
        private readonly AcuERP_Demo.Data.AppDbContext _context;

        public IndexModel(AcuERP_Demo.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<AcuAuth> AcuAuth { get;set; }

        public async Task OnGetAsync()
        {
            AcuAuth = await _context.AcuAuths.ToListAsync();
        }
    }
}
