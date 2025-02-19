using AutoMapper;
using MediatR;
using SchoolSystem.Domain;
using SchoolSystem.Infrastructure.Interfaces;

namespace SchoolSystem.Core.Features.Students.Commands
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public AddStudentHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public Task<Student?> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return _studentRepository.AddStudentAsynch(request.Student);
        }
    }
}
