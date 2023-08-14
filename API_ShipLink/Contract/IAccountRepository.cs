using API_ShipLink.Models;
using API_ShipLink.ViewModel;

namespace API_ShipLink.Contract
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<int> Register(RegisterVM register);
        Task<bool> Login(LoginVM login);

        Task<UserDateVM> GetUserData(string email);
        Task<List<string>>? GetRoles(string email);
    }
}
