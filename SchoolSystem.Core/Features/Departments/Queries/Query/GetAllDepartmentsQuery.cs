using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain.DTOs;

namespace SchoolSystem.Core.Features.Departments.Queries
{
    public class GetAllDepartmentsQuery : IRequest<Response<List<DepartmentReadDto>>>
    {
    }
}
