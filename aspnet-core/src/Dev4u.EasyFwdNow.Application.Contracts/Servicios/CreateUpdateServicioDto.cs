using System;
using System.ComponentModel.DataAnnotations;

namespace Dev4u.EasyFwdNow.Servicios
{
    public class CreateUpdateServicioDto
    {
        [Required]
        [StringLength(128)]
        public string Codigo { get; set; }
        [Required]
        [StringLength(128)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(128)]
        public string Descripcion { get; set; }
        [Required]
        public TipoCategoria Tipo { get; set; }
        [Required]
        public TipoVisibilidad Visibilidad { get; set; }
        [Required]
        public TipoCarga Carga { get; set; }
        [Required]
        public Estado Estado { get; set; }
        [Required]
        public float RequiereCantidad { get; set; }
        [Required]
        public float RequiereMonto { get; set; }
        [Required]
        public float RequiereHoras { get; set; }
    }
}
