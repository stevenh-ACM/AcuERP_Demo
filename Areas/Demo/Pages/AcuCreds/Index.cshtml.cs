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
using Microsoft.AspNetCore.Authorization;

namespace AcuERP_Demo.Areas.Demo.Pages.AcuCreds
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(AppDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<AcuAuth> AcuAuth { get;set; }

        public async Task OnGetAsync()
        {
            AcuAuth = await _context.AcuAuths.ToListAsync();
        }
    }
}
