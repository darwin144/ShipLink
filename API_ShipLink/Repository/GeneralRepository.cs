using API_ShipLink.Context;
using API_ShipLink.Contract;

namespace API_ShipLink.Repository
{
    public abstract class GeneralRepository<Tentity> : IGenericRepository<Tentity> where Tentity : class
    {
        protected readonly ShiplinkContext _context;

        public GeneralRepository(ShiplinkContext context)
        {
            _context = context;
        }
 
        public Tentity? Create(Tentity item)
        {
            try
            {
                _context.Set<Tentity>().Add(item);
                _context.SaveChanges();
                return item;
            }
            catch
            {
                return null;
            }
        }

        public bool Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tentity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tentity? GetByGuid(Guid guid)
        {
            throw new NotImplementedException();
        }

        public bool Update(Tentity item)
        {
            throw new NotImplementedException();
        }
    }
}
