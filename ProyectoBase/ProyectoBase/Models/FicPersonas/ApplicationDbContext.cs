using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoBase.Models.FicPersonas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<rh_cat_persona> rh_cat_personas { get; set; }
        public DbSet<rh_cat_domicilio> rh_cat_domicilios { get; set; }
        public DbSet<rh_cat_telefono> rh_cat_telefonos { get; set; }
        public DbSet<rh_cat_dir_web> rh_cat_dir_webs { get; set; }

    }
}
