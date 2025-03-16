using MediatR;
using SchoolSystem.Core.Features.Students.Queries.Query;
using SchoolSystem.Domain;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Students.Queries.Handler
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        #region Fields
        private readonly IStudentService _studentService;
        #endregion

        #region Constructors
        public GetStudentByIdHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        #region Methods
        public async Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentByIdAsync(request.id);
        }
        #endregion
    }
}
