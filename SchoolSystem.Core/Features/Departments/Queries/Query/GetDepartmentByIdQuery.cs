using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Features.Departments.Queries.Query
{
    public record class GetDepartmentByIdQuery(int id) : IRequest<Response<Department>>;
}
