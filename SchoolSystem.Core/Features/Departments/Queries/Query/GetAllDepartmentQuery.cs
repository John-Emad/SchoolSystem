using MediatR;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Features.Departments.Queries
{
    public class GetAllDepartmentQuery : IRequest<List<Department>>
    {
    }
}
