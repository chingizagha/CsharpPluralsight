using CoreCodeCamp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : ControllerBase
    {
        private readonly ICampRepository _campRepository;

        public CampsController(ICampRepository campRepository)
        {
            _campRepository = campRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCamps()
        {
            try
            {
                var result =  await _campRepository.GetAllCampsAsync();

                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}
