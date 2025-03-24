using MediatR;
using SchoolSystem.Domain;


namespace SchoolSystem.Core.Features.Students.Queries.Query
{
    public record class GetStudentByIdQuery(int id) : IRequest<Student>;
}
