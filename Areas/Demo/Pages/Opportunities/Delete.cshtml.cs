﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcuERP_Demo.Data;
using AcuERP_Demo.Models;

namespace AcuERP_Demo.Areas.Demo.Pages.Opportunities
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public DeleteModel(AppDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public OP_Opportunity OP_Opportunity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OP_Opportunity = await _context.OP_Opportunities.FirstOrDefaultAsync(m => m.Id == id);

            if (OP_Opportunity == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OP_Opportunity = await _context.OP_Opportunities.FindAsync(id);

            if (OP_Opportunity != null)
            {
                _context.OP_Opportunities.Remove(OP_Opportunity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}