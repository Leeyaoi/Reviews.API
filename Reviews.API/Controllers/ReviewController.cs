using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Reviews.API.DTO.ReviewDtos;
using Reviews.API.Interfaces;
using Reviews.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reviews.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ReviewController : ControllerBase
{
    private readonly IReviewRepository _repository;
    private readonly IMapper _mapper;

    public ReviewController(IReviewRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    // GET: api/<ReviewController>
    [HttpGet]
    public async Task<IEnumerable<ReviewDto>> GetAll(CancellationToken cancellationToken)
    {
        var models = await _repository.GetAll(cancellationToken);
        return _mapper.Map<List<ReviewDto>>(models);

    }

    // GET api/<ReviewController>/5
    [HttpGet("{id}")]
    public async Task<ReviewDto> GetById(Guid id, CancellationToken cancellationToken)
    {
        var model = await _repository.GetById(id, cancellationToken);
        return _mapper.Map<ReviewDto>(model);

    }

    // POST api/<ReviewController>
    [HttpPost(Name = "ReviewPost")]
    public async Task<IActionResult> Create([FromBody] CreateReviewDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Review>(dto);
        var data = await _repository.Create(model, cancellationToken);
        return CreatedAtRoute("ReviewPost", data);
    }

    // PUT api/<ReviewController>/5
    [HttpPut("{id}")]
    public async Task<ReviewDto> Update(Guid id, [FromBody] CreateReviewDto dto, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<Review>(dto);
        var data = await _repository.Update(model, id, cancellationToken);
        return _mapper.Map<ReviewDto>(data);
    }

    // DELETE api/<ReviewController>/5
    [HttpDelete("{id}")]
    public async Task<ReviewDto> Delete(Guid id, CancellationToken cancellationToken)
    {
        var data = await _repository.Delete(id, cancellationToken);
        return _mapper.Map<ReviewDto>(data);
    }
}
