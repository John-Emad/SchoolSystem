using MediatR;
using SchoolSystem.Domain;

namespace SchoolSystem.Core.Features.Students.Queries.Models
{
    public class GetAllStudentQuery : IRequest<List<Student>>
    {

    }
}
