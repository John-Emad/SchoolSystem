using SchoolSystem.Domain;
using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain.DTOs;

namespace SchoolSystem.Core.Features.Students.Commands
{
    public record AddStudentCommand(Student Student) : IRequest<Response<StudentReadDto>>;

}
