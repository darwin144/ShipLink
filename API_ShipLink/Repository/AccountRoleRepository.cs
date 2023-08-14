using API_ShipLink.Context;
using API_ShipLink.Contract;
using API_ShipLink.Models;

namespace API_ShipLink.Repository
{
    public class AccountRoleRepository : GeneralRepository<AccountRole>, IAccountRoleRepository
    {
        public AccountRoleRepository(ShiplinkContext context) : base(context)
        {
        }
    }
}
