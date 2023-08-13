using API_ShipLink.Models;

namespace API_ShipLink.Contract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        int CreateWithValidate(User user);

    }
}
