using API_ShipLink.Context;
using API_ShipLink.Contract;
using API_ShipLink.Models;
using API_ShipLink.Utilities;
using API_ShipLink.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace API_ShipLink.Repository
{
    public class AccountRepository : GeneralRepository<Account>, IAccountRepository
    {
       
        private readonly IUserRepository _userRepository;

        public AccountRepository(IUserRepository userRepository, ShiplinkContext context):base(context)
        {
            _userRepository = userRepository;
        }

        public async Task<List<string>>? GetRoles(string email)
        {

            try
            {
                var employee = await _context.User.FirstOrDefaultAsync(e => e.Email == email);
                var roles = await _context.AccountRole.Where(ar => ar.Account_id == employee.Id)
                                .Join(_context.Role, ar => ar.Role_id, r => r.Id, (ar, r) => r.Name)
                                .ToListAsync();
                return roles;
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserDateVM> GetUserData(string email)
        {
            try
            {                
                var account = await _context.User.Select(e => new UserDateVM
                {
                    User_Id = e.Id.ToString(),
                    Email = e.Email,
                    FullName = String.Concat(e.Name),
                }).FirstOrDefaultAsync(e => e.Email == email);
                return account;
            }
            catch
            {
                return null;
            }

        }

        public async Task<bool> Login(LoginVM login)
        {
            try
            {
                var account = await _context.User.Join(_context.Account, a => a.Id,
                        b => b.User_id, (a, b) => new LoginVM
                        {
                            Email = a.Email,
                            Password = b.Password
                        }).FirstOrDefaultAsync();

                if (account != null) return Hashing.ValidatePassword(login.Password,account.Password);
                return false;               
            }
            catch {
                return false; 
            }
        }

        public async Task<int> Register(RegisterVM register)
        {
            try
            {
                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    var user = new User
                    {
                        Name = register.Name,
                        Email = register.Email,
                        Phone = register.Phone,
                        Country = register.Country,
                        Password = register.Password,
                    };
                    var result = _userRepository.CreateWithValidate(user);
                    if (result != 3) return result;

                    var account = new Account
                    {
                        Id = user.Id,
                        User_id = user.Id,
                        Password = Hashing.HashPassword(register.Password)
                    };
                    Create(account);

                    var accountRole = new AccountRole
                    {
                        Role_id = Guid.Parse("f147a695-1a4f-4960-bffc-08db60bf618f"),
                        Account_id = account.Id
                    };
                    await _context.AccountRole.AddAsync(accountRole);
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return 3;
                }

            }
            catch {
                return 0;
            }
        }



    }
}
