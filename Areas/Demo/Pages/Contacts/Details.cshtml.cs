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

namespace AcuERP_Demo.Areas.Demo.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public DetailsModel(AppDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public CR_Contact CR_Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CR_Contact = await _context.CR_Contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (CR_Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}