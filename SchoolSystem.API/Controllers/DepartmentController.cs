using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Core.Features.Departments.Queries;
using SchoolSystem.Core.Features.Departments.Commands;
using SchoolSystem.Domain;
using SchoolSystem.Domain.DTOs;

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
        [HttpGet("/Department/List")]
        public async Task<IActionResult> GetAllDepartments()
        {
            var response = await _mediator.Send(new GetAllDepartmentQuery());
            var result = _mapper.Map<List<DepartmentReadDto>>(response);
            return Ok(result);
        }
        [HttpPost("/Department/AddNew")]
        public async Task<IActionResult> Post([FromBody] DepartmentWriteDto department)
        {
            var departmentToAdd = _mapper.Map<Department>(department);
            var departmentAdded = await _mediator.Send(new AddDepartmentCommand(departmentToAdd));
            return Ok(_mapper.Map<DepartmentWriteDto>(department));
        }
    }
}
