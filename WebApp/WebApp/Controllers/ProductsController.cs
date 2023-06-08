using AutoMapper;
using JwtExample.Data.Entities;
using JwtExample.DTO_s.ProductDto_s;
using Microsoft.AspNetCore.Mvc;
using WebApp.Repositories.Abstract;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(Roles = "Admin", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_mapper.Map<List<ProductGetDto>>(await _unitOfWork.ProductRepository.GetAllAsync(x => !x.IsDeleted)));
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductPostDto productPostDto)
        {
            await _unitOfWork.ProductRepository.Create(_mapper.Map<Product>(productPostDto));
            await _unitOfWork.SaveChangesAsync();
            return Ok("Successfully Created");
        }
    }
}