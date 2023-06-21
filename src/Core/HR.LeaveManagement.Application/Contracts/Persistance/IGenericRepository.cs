namespace HR.LeaveManagement.Application.Contracts.Persistance;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync();
    Task<T> GetByIdAsync();
    Task<T> CreateAsync(T Entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T Entity);
}
