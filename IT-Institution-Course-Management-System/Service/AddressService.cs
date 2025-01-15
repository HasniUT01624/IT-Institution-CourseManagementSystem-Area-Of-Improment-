using IT_Institution_Course_Management_System.IRepository;
using IT_Institution_Course_Management_System.IService;

namespace IT_Institution_Course_Management_System.Service
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
    }
}
