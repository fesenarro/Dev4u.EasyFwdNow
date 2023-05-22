using Dev4u.EasyFwdNow.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev4u.EasyFwdNow.Servicios
{
    public class ServicioAppService :
        CrudAppService<
            Servicio, //The Book entity
            ServicioDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateServicioDto>, //Used to create/update a book
            IServicioAppService //implement the IBookAppService
    {
        public ServicioAppService(IRepository<Servicio, Guid> repository)
            : base(repository)
        {
            GetPolicyName = EasyFwdNowPermissions.Servicios.Default;
            GetListPolicyName = EasyFwdNowPermissions.Servicios.Default;
            CreatePolicyName = EasyFwdNowPermissions.Servicios.Create;
            UpdatePolicyName = EasyFwdNowPermissions.Servicios.Edit;
            DeletePolicyName = EasyFwdNowPermissions.Servicios.Delete;
        }
    }
}
