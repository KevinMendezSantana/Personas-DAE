using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoBase.Models.FicPersonas
{
    public class rh_cat_domicilio
    {
        [Key]
        public int IdDomicilio { get; set; }
        public string Domicilio { get; set; }
        public string EntreCalle1 { get; set; }
        public string EntreCalle2 { get; set; }
        public string CodigoPostal { get; set; }
        public string Coordenadas { get; set; }
        public bool Principal { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Localidad { get; set; }
        public string Colonia { get; set; }
        public string Referencia { get; set; }
        public string ClaveReferencia { get; set; }
        public string TipoDomicilio { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string UsuarioReg { get; set; }
        public string UsuarioMod { get; set; }
        public bool Activo { get; set; }
        public bool Borrado { get; set; }
        public int IdPersona { get; set; }


    }
}
