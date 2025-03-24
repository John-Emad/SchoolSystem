using MediatR;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Features.Departments.Queries.Query
{
    public record class GetDepartmentByIdQuery(int id) : IRequest<Department>;
}
