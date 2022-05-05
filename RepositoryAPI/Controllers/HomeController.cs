using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryAPI.Database;
using RepositoryAPI.Repository;
using System.Threading.Tasks;

namespace RepositoryAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IEndUserRepository endUserRerpository;

        public HomeController(MyDBContext myDBContext)
        {
            endUserRerpository = new EndUserRepository(myDBContext);
        }

        [HttpGet]
        public IActionResult index()
        {
            return new OkObjectResult("Welcome");
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> Get()
        {
            var result = await endUserRerpository.GetEmployees();
            return new OkObjectResult(result);
        }
    }
}
