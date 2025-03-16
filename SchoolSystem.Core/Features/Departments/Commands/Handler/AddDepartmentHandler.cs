using AutoMapper;
using MediatR;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Interfaces;

namespace SchoolSystem.Core.Features.Departments.Commands
{
    public class AddDepartmentHandler : IRequestHandler<AddDepartmentCommand, Department>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public AddDepartmentHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public  Task<Department?> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
        {
            return  _departmentRepository.AddAsync(request.Department);
        }
    }
}
