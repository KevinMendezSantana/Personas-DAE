using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoBase.Models.FicPersonas;

namespace ProyectoBase.Pages.Menu.FicPersonas.fic_rh_cat_telefonos
{
    public class DeleteModel : PageModel
    {
        private readonly ProyectoBase.Models.FicPersonas.ApplicationDbContext _context;

        public DeleteModel(ProyectoBase.Models.FicPersonas.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public rh_cat_telefono rh_cat_telefono { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            rh_cat_telefono = await _context.rh_cat_telefonos.SingleOrDefaultAsync(m => m.IdTelefono == id);

            if (rh_cat_telefono == null)
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

            rh_cat_telefono = await _context.rh_cat_telefonos.FindAsync(id);

            if (rh_cat_telefono != null)
            {
                _context.rh_cat_telefonos.Remove(rh_cat_telefono);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
