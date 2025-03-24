using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;

namespace SchoolSystem.Core.Features.Students.Queries
{
    public class GetAllStudentQuery : IRequest<Response<List<StudentReadDto>>>
    {
    }
}
