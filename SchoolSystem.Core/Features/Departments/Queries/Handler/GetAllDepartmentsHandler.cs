using AutoMapper;
using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Departments.Queries.Handler
{
    public class GetAllDepartmentsHandler : ResponseHandler,  IRequestHandler<GetAllDepartmentsQuery, Response<List<DepartmentReadDto>>>
    {
        #region Fields
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public GetAllDepartmentsHandler(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<Response<List<DepartmentReadDto>>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            var departmentReadDtos = _mapper.Map<List<DepartmentReadDto>>(departments);
            return Success(departmentReadDtos);
        }
        #endregion
    }
}
