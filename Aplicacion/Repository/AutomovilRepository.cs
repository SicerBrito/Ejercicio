using System.Linq.Expressions;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repository;
public class AutomovilRepository : IGenericRepository<Automovil>
{
    public void Add(Automovil entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<Automovil> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Automovil> Find(Expression<Func<Automovil, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Automovil>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Automovil>? GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Automovil entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Automovil> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(Automovil entity)
    {
        throw new NotImplementedException();
    }
}
