using AutoMapper;
using MediatR;
using SchoolSystem.Core.Response;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;
using SchoolSystem.Infrastructure.Interfaces;

namespace SchoolSystem.Core.Features.Students.Commands
{
    public class AddStudentHandler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<StudentReadDto>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public AddStudentHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<Response<StudentReadDto?>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var addedStudent = await _studentRepository.AddAsync(request.Student);
            var studentReadDto = _mapper.Map<StudentReadDto>(addedStudent);
            return Created(studentReadDto);
        }
    }
}
