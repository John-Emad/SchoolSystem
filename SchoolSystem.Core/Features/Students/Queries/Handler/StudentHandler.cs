using MediatR;
using SchoolSystem.Domain;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Students.Queries
{
    public class StudentHandler : IRequestHandler<GetAllStudentQuery, List<Student>>
    {
        #region Fields
            private readonly IStudentService _studentService;
        #endregion

        #region Constructors
        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        #endregion

        #region Methods
            public async Task<List<Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
            {
                return await _studentService.GetAllStudentsAsynch();
            }
        #endregion
    }
}
