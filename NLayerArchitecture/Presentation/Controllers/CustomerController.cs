using Core;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBusiness customerBusiness;
        public CustomerController(ICustomerBusiness customerBusiness)
        {
            this.customerBusiness = customerBusiness;
        }

        [HttpGet]
        public int GetCustomerCount()
        {
            return this.customerBusiness.GetCustomerCount();
        }
    }
}
