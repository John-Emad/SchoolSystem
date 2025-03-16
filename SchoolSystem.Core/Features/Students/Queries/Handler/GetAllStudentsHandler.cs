using MediatR;
using SchoolSystem.Domain;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Students.Queries
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentQuery, IEnumerable<Student>>
    {
        #region Fields
            private readonly IStudentService _studentService;
        #endregion

        #region Constructors
        public GetAllStudentsHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        #endregion

        #region Methods
            public async Task<IEnumerable<Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
            {
                return await _studentService.GetAllStudentsAsync();
            }
        #endregion
    }
}
