using MediatR;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Features.Students.Queries
{
    public class GetAllStudentQuery : IRequest<List<Student>>
    {
    }
}
