using System.Linq.Expressions;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repository;
public class ClienteRepository : IGenericRepository<Cliente>
{
    public void Add(Cliente entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<Cliente> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Cliente> Find(Expression<Func<Cliente, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Cliente>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Cliente>? GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Cliente entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Cliente> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(Cliente entity)
    {
        throw new NotImplementedException();
    }
}
