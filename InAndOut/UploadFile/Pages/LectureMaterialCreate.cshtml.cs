﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UploadFile;
using UploadFile.Data;

namespace UploadFile.Pages
{
    public class LectureMaterialCreateModel : PageModel
    {
        private readonly UploadFile.UploadfileContext _context;

        public LectureMaterialCreateModel(UploadFile.UploadfileContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LectureMaterials LectureMaterials { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LectureMaterials.Add(LectureMaterials);
            await _context.SaveChangesAsync();

            return RedirectToPage("./LectureMaterialIndex");
        }
    }
}
