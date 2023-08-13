using API_ShipLink.Context;
using API_ShipLink.Contract;
using API_ShipLink.Models;

namespace API_ShipLink.Repository
{
    public class RoleRepository : GeneralRepository<Role>, IRoleRepository
    {
        public RoleRepository(ShiplinkContext context) : base(context)
        {
        }
    }
}
