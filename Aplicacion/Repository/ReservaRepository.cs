using System.Linq.Expressions;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repository;
public class ReservaRepository : IGenericRepository<Reserva>
{
    public void Add(Reserva entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<Reserva> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Reserva> Find(Expression<Func<Reserva, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Reserva>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Reserva>? GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Reserva entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Reserva> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(Reserva entity)
    {
        throw new NotImplementedException();
    }
}
