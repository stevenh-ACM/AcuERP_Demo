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
    public class DetailsModel : PageModel
    {
        private readonly AcuERP_Demo.Data.AppDbContext _context;

        public DetailsModel(AcuERP_Demo.Data.AppDbContext context)
        {
            _context = context;
        }

        public AcuAuth AcuAuth { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AcuAuth = await _context.AcuAuths.FirstOrDefaultAsync(m => m.Id == id);

            if (AcuAuth == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
