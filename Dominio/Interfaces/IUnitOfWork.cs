namespace Dominio.Interfaces;
    public interface IUnitOfWork<T> where T : class{
        IGenericRepository<T> ? GenericRepository { get; }
        Task<int> SaveAsync(); 
    }
