using BLL.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepository _branchRepository;
        public BranchController(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        [Route("GetBranch")]
        [HttpGet]
        public async Task<ActionResult> GetBranch()
        {
            return Ok(_branchRepository.GetAll());
        }
    }
}
