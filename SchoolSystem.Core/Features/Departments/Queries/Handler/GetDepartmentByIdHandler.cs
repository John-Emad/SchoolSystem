using MediatR;
using SchoolSystem.Core.Features.Departments.Queries.Query;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Departments.Queries.Handler
{
    public class GetDepartmentByIdHandler :ResponseHandler, IRequestHandler<GetDepartmentByIdQuery, Response<Department>>
    {
        #region Fields
        private readonly IDepartmentService _departmentService;
        #endregion

        #region Constructor
        public GetDepartmentByIdHandler(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        #endregion

        #region Methods
        public async Task<Response<Department>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await _departmentService.GetDepartmentByIdAsync(request.id);
            return Success(department);
        }
        #endregion
    }
}
