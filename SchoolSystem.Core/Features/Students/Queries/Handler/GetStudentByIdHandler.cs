using MediatR;
using SchoolSystem.Core.Features.Students.Queries.Query;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Students.Queries.Handler
{
    public class GetStudentByIdHandler : ResponseHandler, IRequestHandler<GetStudentByIdQuery, Response<Student>>
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
        public async Task<Response<Student>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return Success(await _studentService.GetStudentByIdAsync(request.id));
        }
        #endregion
    }
}
