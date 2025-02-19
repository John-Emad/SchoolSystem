using SchoolSystem.Domain;
using MediatR;

namespace SchoolSystem.Core.Features.Students.Commands
{
    public record AddStudentCommand(Student Student) : IRequest<Student>;

}
