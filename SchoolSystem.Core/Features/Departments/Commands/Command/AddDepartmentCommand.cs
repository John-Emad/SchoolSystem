using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Features.Departments.Commands
{
    public record AddDepartmentCommand(Department Department) : IRequest<Response<Department>>;
}
