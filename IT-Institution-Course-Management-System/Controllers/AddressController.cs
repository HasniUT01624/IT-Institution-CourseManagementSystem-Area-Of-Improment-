using IT_Institution_Course_Management_System.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT_Institution_Course_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
    }
}
