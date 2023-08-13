namespace API_ShipLink.Contract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        bool Update(TEntity item);
        bool Delete(Guid guid);
        IEnumerable<TEntity> GetAll();
        TEntity? GetByGuid(Guid guid);
    }
}
