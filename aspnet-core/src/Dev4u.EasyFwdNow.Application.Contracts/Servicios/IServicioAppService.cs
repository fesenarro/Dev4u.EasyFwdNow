using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev4u.EasyFwdNow.Servicios
{
    public interface IServicioAppService :
        ICrudAppService<
            ServicioDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateServicioDto>
    {
    }
}
