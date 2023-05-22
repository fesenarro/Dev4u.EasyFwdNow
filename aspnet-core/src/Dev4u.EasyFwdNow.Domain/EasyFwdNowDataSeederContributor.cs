using System;
using System.Threading.Tasks;
using Dev4u.EasyFwdNow.Servicios;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dev4u.EasyFwdNow
{
    public class EasyFwdDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Servicio, Guid> _servicioRepository;
        public EasyFwdDataSeederContributor(IRepository<Servicio, Guid> servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _servicioRepository.GetCountAsync() <= 0)
            {
                await _servicioRepository.InsertAsync(
                    new Servicio
                    {
                        //Name = "1984",
                        //Type = BookType.Dystopia,
                        //PublishDate = new DateTime(1949, 6, 8),
                        //Price = 19.84f
                        Codigo = "SER_FWI_ACON",
                        Nombre = "ACONDICIONAMIENTO ESPECIAL FWD IMP",
                        Descripcion = "OTROS SERVICIOS",
                        Tipo = TipoCategoria.Importacion,
                        Estado = Estado.Activo,
                        Visibilidad = TipoVisibilidad.Todos,
                        Carga = TipoCarga.CargaSuelta,
                        RequiereCantidad = 0,
                        RequiereMonto = 0,
                        RequiereHoras = 0
                    },
                    autoSave: true
                );

                await _servicioRepository.InsertAsync(
                    new Servicio
                    {
                        Codigo = "NEP_ADI_OTR_TER",
                        Nombre = "ADICIONALES OTROS TERMINALES",
                        Descripcion = "ADICIONALES OTROS TERMINALES",
                        Tipo = TipoCategoria.ImpoExpo,
                        Estado = Estado.Activo,
                        Visibilidad = TipoVisibilidad.Todos,
                        Carga = TipoCarga.CargaSuelta,
                        RequiereCantidad = 0,
                        RequiereMonto = 0,
                        RequiereHoras = 0
                    },
                    autoSave: true
                );
            }
        }
    }
}