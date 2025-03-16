
using MediatR;
using SchoolSystem.Core.Features.Departments.Queries.Query;
using SchoolSystem.Domain;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Departments.Queries.Handler
{
    public class GetDepartmentByIdHandler : IRequestHandler<GetDepartmentByIdQuery, Department>
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
        public Task<Department> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            return _departmentService.GetDepartmentByIdAsync(request.id);
        }
        #endregion
    }
}
