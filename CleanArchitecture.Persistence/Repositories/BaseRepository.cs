using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        protected readonly AppDbContext _appDbContext;

        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _appDbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellation)
        {
            return await _appDbContext.Set<T>().ToListAsync(cancellation);
        }

        public void Save(T entity)
        {
            entity.DateCreated = DateTime.UtcNow;
            _appDbContext.Add(entity);
        }

        public void Update(T entity)
        {
            entity.DateUpdated = DateTime.UtcNow;
            _appDbContext.Update(entity);
        }

        public void Delete(T entity)
        {
            entity.DateDeleted = DateTime.UtcNow;
            _appDbContext.Remove(entity);
        }
        
    }
}
