using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Reviews.API.DTO.FilmDtos;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FilmController : ControllerBase
{
    private readonly IFilmRepository _repository;
    private readonly IMapper _mapper;

    public FilmController(IFilmRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    // GET: api/<FilmController>
    [HttpGet]
    public async Task<IEnumerable<FilmDto>> GetAll(CancellationToken cancellationToken)
    {
        var models = await _repository.GetAll(cancellationToken);
        return _mapper.Map<List<FilmDto>>(models);

    }

    // GET api/<FilmController>/5
    [HttpGet("{id}")]
    public async Task<FilmDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var model = await _repository.GetById(id, cancellationToken);
        return _mapper.Map<FilmDto>(model);

    }

    // GET api/<FilmController>/5
    [HttpGet("/find/{query}")]
    public async Task<List<FilmDto>> FindByName(string query, CancellationToken cancellationToken)
    {
        var models = await _repository.GetByPredicate(x => x.Name.ToLower().Contains(query.ToLower()), cancellationToken);
        return _mapper.Map<List<FilmDto>>(models);
    }

    // POST api/<FilmController>
    [HttpPost(Name = "FilmPost")]
    public async Task<IActionResult> Create([FromBody] CreateFilmDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Film>(dto);
        var data = await _repository.Create(model, cancellationToken);
        return CreatedAtRoute("FilmPost", data);
    }

    // PUT api/<FilmController>/5
    [HttpPut("{id}")]
    public async Task<FilmDto> Update(Guid id, [FromBody] CreateFilmDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Film>(dto);
        var data = await _repository.Update(model, id, cancellationToken);
        return _mapper.Map<FilmDto>(data);
    }

    // DELETE api/<FilmController>/5
    [HttpDelete("{id}")]
    public async Task<FilmDto> Delete(Guid id, CancellationToken cancellationToken)
    {
        var data = await _repository.Delete(id, cancellationToken);
        return _mapper.Map<FilmDto>(data);
    }
}
