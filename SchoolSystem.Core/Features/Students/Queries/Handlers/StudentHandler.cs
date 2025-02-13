using MediatR;
using SchoolSystem.Core.Features.Students.Queries.Models;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Interfaces;
using SchoolSystem.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Core.Features.Students.Queries.Handlers
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
