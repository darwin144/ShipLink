using API_ShipLink.Context;
using API_ShipLink.Contract;
using API_ShipLink.Models;
using Microsoft.EntityFrameworkCore;

namespace API_ShipLink.Repository
{
    public class UserRepository : GeneralRepository<User>, IUserRepository
    {
        public UserRepository(ShiplinkContext context) : base(context)
        {
        }

        public int CreateWithValidate(User user)
        {
            try
            {
                bool ExistsByEmail = _context.User.Any(e => e.Email == user.Email);
                if (ExistsByEmail) return 1;
                
                bool ExistsByPhoneNumber = _context.User.Any(e => e.Phone == user.Phone);
                if (ExistsByPhoneNumber) return 2;
 
                Create(user);
                return 3;
            }
            catch
            {
                return 0;
            }
        }
    }
}
