using System;
using Volo.Abp.Application.Dtos;

namespace Dev4u.EasyFwdNow.Servicios
{
    public class ServicioDto : AuditedEntityDto<Guid>
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoCategoria Tipo { get; set; }
        public TipoVisibilidad Visibilidad { get; set; }
        public TipoCarga Carga { get; set; }
        public Estado Estado { get; set; }
        public float RequiereCantidad { get; set; }
        public float RequiereMonto { get; set; }
        public float RequiereHoras { get; set; }
    }
}
