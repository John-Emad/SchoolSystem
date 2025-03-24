using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Features.Departments.Queries;
using SchoolSystem.Core.Features.Departments.Commands;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;
using SchoolSystem.Core.Features.Departments.Queries.Query;

namespace SchoolSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public DepartmentController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpPost("/Department/AddNew")]
        public async Task<IActionResult> Post([FromBody] DepartmentWriteDto department)
        {
            var departmentToAdd = _mapper.Map<Department>(department);
            var departmentAdded = await _mediator.Send(new AddDepartmentCommand(departmentToAdd));
            return Ok(departmentAdded);
        }

        [HttpGet("/Department/List")]
        public async Task<IActionResult> GetAllDepartments()
        {
            var response = await _mediator.Send(new GetAllDepartmentsQuery());
            return Ok(response);
        }

        [HttpGet("/Department/")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var response = await _mediator.Send(new GetDepartmentByIdQuery(id));
            return Ok(response);
        }

    }
}
