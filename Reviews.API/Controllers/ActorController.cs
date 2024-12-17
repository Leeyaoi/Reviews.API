using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Reviews.API.DTO.ActorDtos;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ActorController : ControllerBase
{
    private readonly IActorRepository _repository;
    private readonly IMapper _mapper;

    public ActorController(IActorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    // GET: api/<ActorController>
    [HttpGet]
    public async Task<IEnumerable<ActorDto>> GetAll(CancellationToken cancellationToken)
    {
        var models = await _repository.GetAll(cancellationToken);
        return _mapper.Map<List<ActorDto>>(models);
    }

    // GET api/<ActorController>/5
    [HttpGet("{id}")]
    public async Task<ActorDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var model = await _repository.GetById(id, cancellationToken);
        return _mapper.Map<ActorDto>(model);
    }

    // POST api/<ActorController>
    [HttpPost(Name = "ActorPost")]
    public async Task<IActionResult> Create([FromBody] CreateActorDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Actor>(dto);
        var data = await _repository.Create(model, cancellationToken);
        return CreatedAtRoute("ActorPost", data);
    }

    // PUT api/<ActorController>/5
    [HttpPut("{id}")]
    public async Task<ActorDto> Update(Guid id, [FromBody] CreateActorDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Actor>(dto);
        var data = await _repository.Update(model, id, cancellationToken);
        return _mapper.Map<ActorDto>(data);
    }

    // DELETE api/<ActorController>/5
    [HttpDelete("{id}")]
    public async Task<ActorDto> Delete(Guid id, CancellationToken cancellationToken)
    {
        var data = await _repository.Delete(id, cancellationToken);
        return _mapper.Map<ActorDto>(data);
    }
}
