﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoBase.Models.FicPersonas;

namespace ProyectoBase.Pages.Menu.FicPersonas.fic_rh_cat_dir_webs
{
    public class DeleteModel : PageModel
    {
        private readonly ProyectoBase.Models.FicPersonas.ApplicationDbContext _context;

        public DeleteModel(ProyectoBase.Models.FicPersonas.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public rh_cat_dir_web rh_cat_dir_web { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            rh_cat_dir_web = await _context.rh_cat_dir_webs.SingleOrDefaultAsync(m => m.IdDirWeb == id);

            if (rh_cat_dir_web == null)
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

            rh_cat_dir_web = await _context.rh_cat_dir_webs.FindAsync(id);

            if (rh_cat_dir_web != null)
            {
                _context.rh_cat_dir_webs.Remove(rh_cat_dir_web);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
