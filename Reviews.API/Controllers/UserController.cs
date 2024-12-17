using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Reviews.API.DTO.UserDtos;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserController(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    // GET: api/<UserController>
    [HttpGet]
    public async Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken)
    {
        var models = await _repository.GetAll(cancellationToken);
        return _mapper.Map<List<UserDto>>(models);
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public async Task<UserDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var model = await _repository.GetById(id, cancellationToken);
        return _mapper.Map<UserDto>(model);

    }

    // POST api/<UserController>
    [HttpPost(Name = "UserPost")]
    public async Task<IActionResult> Create([FromBody] CreateUserDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<User>(dto);
        var data = await _repository.Create(model, cancellationToken);
        return CreatedAtRoute("UserPost", data);
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public async Task<UserDto> Update(Guid id, [FromBody] CreateUserDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<User>(dto);
        var data = await _repository.Update(model, id, cancellationToken);
        return _mapper.Map<UserDto>(data);
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public async Task<UserDto> Delete(Guid id, CancellationToken cancellationToken)
    {
        var data = await _repository.Delete(id, cancellationToken);
        return _mapper.Map<UserDto>(data);
    }
}
