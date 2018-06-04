using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoBase.Models.FicPersonas;

namespace ProyectoBase.Pages.Menu.FicPersonas.fic_rh_cat_domicilios
{
    public class IndexModel : PageModel
    {
        private readonly ProyectoBase.Models.FicPersonas.ApplicationDbContext _context;

        public IndexModel(ProyectoBase.Models.FicPersonas.ApplicationDbContext context)
        {
            _context = context;

        }

        public IList<rh_cat_domicilio> rh_cat_domicilio { get;set; }

        [BindProperty]
        public rh_cat_persona rh_cat_persona { get; set; }



        public async Task<IActionResult> OnGetAsync(int? id)
        {
            //Esto es para mostrar solo los domicilios de un usuario gracias a su id
            var item = from m in _context.rh_cat_domicilios
                       select m;

            item = item.Where(s => s.IdPersona.Equals(id));
            
            rh_cat_domicilio = await item.ToListAsync();

            //Esto es asignarle los valores a la variable rh_cat_personas y poderlo usar en el index para pasar
            //el parametro de id a la siguiente ventana
            if (id == null)
            {
                return NotFound();
            }

            rh_cat_persona = await _context.rh_cat_personas.SingleOrDefaultAsync(m => m.IdPersona == id);

            if (rh_cat_persona == null)
            {
                return NotFound();
            }
            return Page();
        }
        

    }



}

