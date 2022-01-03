using CleanArchitecture.Application.IService;
using CleanArchitecture.Application.Model.EmployeeModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        public readonly IService _service;

        public EmployeeController(IService service)
        {
            _service = service;
        }

        [HttpPost]
        public Task<bool> Insert(EmployeeWriteModel model) => _service.Insert(model);
    }
}
