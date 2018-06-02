using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoBase.Models.FicPersonas
{
    public class rh_cat_dir_web
    {
        [Key]
        public int IdDirWeb { get; set; }
        public string DesDirWeb { get; set; }
        public string DirWeb { get; set; }
        public bool Principal { get; set; }
        public string ClaveReferencia { get; set; }
        public string Referencia { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioReg { get; set; }
        public string UsuarioMod { get; set; }
        public bool Activo { get; set; }
        public bool Borrado { get; set; }
        public int IdPersona { get; set; }
    }
}
