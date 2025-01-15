using IT_Institution_Course_Management_System.DBContext;
using IT_Institution_Course_Management_System.IRepository;

namespace IT_Institution_Course_Management_System.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDBContext _dbContext;

        AddressRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
