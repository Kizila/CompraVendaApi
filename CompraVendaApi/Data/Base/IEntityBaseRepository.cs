namespace CompraVendaApi.Data.Base
{
    public interface IEntityBaseRepository
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIDAsync(int id);
    }
}
