using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Features.Students.Commands;
using SchoolSystem.Core.Features.Students.Queries;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;

namespace SchoolSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public StudentController(IMediator mediator, IMapper mapper) 
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetAllStudents()
        {
            var response = await _mediator.Send(new GetAllStudentQuery());
            var result = _mapper.Map<List<StudentReadDto>>(response);
            return Ok(result);
        }
        [HttpPost("/Student/AddNew")]
        public async Task<IActionResult> Post([FromBody]StudentWriteDto student)
        {
            var studentToAdd = _mapper.Map<Student>(student);
            var studentAdded = await _mediator.Send(new AddStudentCommand(studentToAdd));
            return Ok(_mapper.Map<StudentReadDto>(studentAdded));
        }
    }
}
