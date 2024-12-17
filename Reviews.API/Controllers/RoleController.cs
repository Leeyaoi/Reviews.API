using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Reviews.API.DTO.RoleDtos;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RoleController : ControllerBase
{
    private readonly IRoleRepository _repository;
    private readonly IMapper _mapper;

    public RoleController(IRoleRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    // GET: api/<RoleController>
    [HttpGet]
    public async Task<IEnumerable<RoleDto>> GetAll(CancellationToken cancellationToken)
    {
        var models = await _repository.GetAll(cancellationToken);
        return _mapper.Map<List<RoleDto>>(models);

    }

    // GET api/<RoleController>/5
    [HttpGet("{id}")]
    public async Task<RoleDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var model = await _repository.GetById(id, cancellationToken);
        return _mapper.Map<RoleDto>(model);
    }

    // POST api/<RoleController>
    [HttpPost(Name = "RolePost")]
    public async Task<IActionResult> Create([FromBody] CreateRoleDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Role>(dto);
        var data = await _repository.Create(model, cancellationToken);
        return CreatedAtRoute("RolePost", data);
    }

    // PUT api/<RoleController>/5
    [HttpPut("{id}")]
    public async Task<RoleDto> Update(Guid id, [FromBody] CreateRoleDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Role>(dto);
        var data = await _repository.Update(model, id, cancellationToken);
        return _mapper.Map<RoleDto>(data);
    }

    // DELETE api/<RoleController>/5
    [HttpDelete("{id}")]
    public async Task<RoleDto> Delete(Guid id, CancellationToken cancellationToken)
    {
        var data = await _repository.Delete(id, cancellationToken);
        return _mapper.Map<RoleDto>(data);
    }
}
