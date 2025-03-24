using AutoMapper;
using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain.DTOs;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Students.Queries
{
    public class GetAllStudentsHandler : ResponseHandler, IRequestHandler<GetAllStudentQuery, Response<List<StudentReadDto>>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllStudentsHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        #endregion

        #region Methods
        public async Task<Response<List<StudentReadDto>>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var StudentsList = await _studentService.GetAllStudentsAsync();
            var StudentsListDto = _mapper.Map<List<StudentReadDto>>(StudentsList);
            return Success(StudentsListDto);
        }
        #endregion
    }
}
