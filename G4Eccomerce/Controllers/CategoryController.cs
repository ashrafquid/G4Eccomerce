using G4Eccomerce.Model;
using G4Eccomerce.Repository.IRepository;
using G4Eccomerce.Result;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace G4Eccomerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase    
    {
  
        private readonly ICategoryRepository repository;

        public CategoryController(ICategoryRepository repository)
        {
          
            this.repository = repository;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {

                var responce = await repository.GetAll();
                
                return Ok(Result<IEnumerable<Category>>.Sucess(responce));
            }
            catch(Exception ex)
            {
                return Ok(Result<IEnumerable<Category>>.Fail(ex.Message));
                
            }
         

        }
        

        [HttpPost("Add")]
        public async Task<IActionResult> Add(Category entity)
        {
            try
            {
               var res = await repository.AddAndReturn(entity);
                await repository.SaveChanges();
                

                return Ok(Result<Category>.Sucess(res));
            }
            catch (Exception ex)
            {
                return Ok(Result<Category>.Fail(ex.Message));
            }


        }



    } 
}
