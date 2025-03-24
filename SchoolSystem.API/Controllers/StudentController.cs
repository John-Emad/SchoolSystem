using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Features.Students.Commands;
using SchoolSystem.Core.Features.Students.Queries;
using SchoolSystem.Core.Features.Students.Queries.Query;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;

namespace SchoolSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public StudentController(IMediator mediator, IMapper mapper) 
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        #endregion

        #region Controllers
        [HttpPost("/Student/AddNew")]
        public async Task<IActionResult> Post([FromBody] StudentWriteDto student)
        {
            var studentToAdd = _mapper.Map<Student>(student);
            var studentAdded = await _mediator.Send(new AddStudentCommand(studentToAdd));
            return Ok(studentAdded);
        }

        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetAllStudents()
        {
            var response = await _mediator.Send(new GetAllStudentQuery());
            return Ok(response);
        }

        [HttpGet("/Student/")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var response = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(response);
        }

        #endregion
    }
}
