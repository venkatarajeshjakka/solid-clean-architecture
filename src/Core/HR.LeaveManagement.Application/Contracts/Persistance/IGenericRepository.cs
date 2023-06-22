namespace HR.LeaveManagement.Application.Contracts.Persistance;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> GetAsync();
    Task<T> GetByIdAsync(int Id);
    Task<T> CreateAsync(T Entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T Entity);
}
