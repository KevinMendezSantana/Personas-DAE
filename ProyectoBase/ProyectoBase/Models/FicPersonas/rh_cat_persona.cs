using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoBase.Models.FicPersonas
{
    public class rh_cat_persona
    {

        [Key]
        public int IdPersona { get; set; }
        public int IdInstituto { get; set; }
        public string NumControl { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public DateTime FechaNac { get; set; }
        public string TipoPersona { get; set; }
        public bool Sexo { get; set; }
        public string RutaFoto { get; set; }
        public string Alias { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioReg { get; set; }
        public string UsuarioMod { get; set; }
        public bool Activo { get; set; }
        public bool Borrado { get; set; }
    }
}
