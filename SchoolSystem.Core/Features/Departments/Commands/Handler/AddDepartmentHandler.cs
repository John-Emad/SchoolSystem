using AutoMapper;
using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Interfaces;

namespace SchoolSystem.Core.Features.Departments.Commands
{
    public class AddDepartmentHandler :ResponseHandler, IRequestHandler<AddDepartmentCommand, Response<Department>>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public AddDepartmentHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public  async Task<Response<Department?>> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
        {
            var addedDepartment = await _departmentRepository.AddAsync(request.Department);
            return Created(addedDepartment) ;
        }
    }
}
