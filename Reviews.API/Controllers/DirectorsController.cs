using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Reviews.API.DTO.DirectorDtos;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper _mapper;

        public DirectorsController(IDirectorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/<DirectorController>
        [HttpGet]
        public async Task<IEnumerable<DirectorDto>> GetAll(CancellationToken cancellationToken)
        {
            var models = await _repository.GetAll(cancellationToken);
            return _mapper.Map<List<DirectorDto>>(models);
        }

        // GET api/<DirectorController>/5
        [HttpGet("{id}")]
        public async Task<DirectorDto> GetById(Guid id, CancellationToken cancellationToken)
        {
            var model = await _repository.GetById(id, cancellationToken);
            return _mapper.Map<DirectorDto>(model);
        }

        // POST api/<DirectorController>
        [HttpPost(Name = "DirectorPost")]
        public async Task<IActionResult> Create([FromBody] CreateDirectorDto dto, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Director>(dto);
            var data = await _repository.Create(model, cancellationToken);
            return CreatedAtRoute("DirectorPost", data);
        }

        // PUT api/<DirectorController>/5
        [HttpPut("{id}")]
        public async Task<DirectorDto> Update(Guid id, [FromBody] CreateDirectorDto dto, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Director>(dto);
            var data = await _repository.Update(model, id, cancellationToken);
            return _mapper.Map<DirectorDto>(data);
        }

        // DELETE api/<DirectorController>/5
        [HttpDelete("{id}")]
        public async Task<DirectorDto> Delete(Guid id, CancellationToken cancellationToken)
        {
            var data = await _repository.Delete(id, cancellationToken);
            return _mapper.Map<DirectorDto>(data);
        }
    }
}
