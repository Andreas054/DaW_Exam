using DaW_Exam.Data;
using DaW_Exam.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace DaW_Exam.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDatabaseContext _appDatabaseContext;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(AppDatabaseContext appDatabaseContext)
        {
            {
                _appDatabaseContext = appDatabaseContext;
                _table = _appDatabaseContext.Set<TEntity>();
            }
        }

        // get all
        public List<TEntity> GetAll()
        {
            return _table.AsNoTracking().ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        // create
        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        // update
        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        // find
        public TEntity FindById(Guid id)
        {
            return _table.Find(id);
        }

        public async Task<TEntity> FindByIdAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }

        // save
        public bool Save()
        {
            return _appDatabaseContext.SaveChanges() > 0;
        }

        public async Task<bool> SaveAsync(TEntity entity)
        {
            return await _appDatabaseContext.SaveChangesAsync() > 0;
        }
    }
}