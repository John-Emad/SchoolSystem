﻿using MediatR;
using SchoolSystem.Domain;
using SchoolSystem.Service.Interfaces;

namespace SchoolSystem.Core.Features.Departments.Queries.Handler
{
    public class DepartmentHandler : IRequestHandler<GetAllDepartmentQuery, IEnumerable<Department>>
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentHandler(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public async Task<IEnumerable<Department>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            return await _departmentService.GetAllDepartmentsAsync();
        }
    }
}
