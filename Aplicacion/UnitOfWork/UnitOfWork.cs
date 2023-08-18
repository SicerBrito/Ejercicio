using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly SicerContext _context;
    public UnitOfWork(SicerContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
