using G4Eccomerce.Model;
using G4Eccomerce.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace G4Eccomerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase    
    {
  
        private readonly IProductRepository repository;

        public ProductController(IProductRepository repository)
        {
          
            this.repository = repository;
        }
         

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
               // var responce = await context.Categories.ToListAsync();
                //var responce = await context.Set<Category>().ToListAsync();
                var responce = await repository.GetAll();

                return Ok(responce);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
         

        }

        [HttpGet("GetAllProductByCatID")]
        public async Task<IActionResult> GetAllProductByCatID(int catId)
        {
            try
            {
             
                var responce = await repository.GetAll(x=>x.CategoryId==catId);

                return Ok(responce);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add(Product entity)
        {
            try
            {
               var res = await repository.AddAndReturn(entity);
                await repository.SaveChanges();
                

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }



    }
}
