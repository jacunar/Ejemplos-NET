using DesignPatterns.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Repository;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class {
    private DesignPatternsContext _context;
    private DbSet<TEntity> _dbSet;

    public Repository(DesignPatternsContext context) {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public void Add(TEntity data) => _dbSet.Add(data);

    public void Delete(int id) {
        var toDelete = _dbSet.Find(id);
        _dbSet.Remove(toDelete);
    }

    public IEnumerable<TEntity> Get() => _dbSet.ToList();

    public TEntity Get(int id) {
        return _dbSet.Find(id); 
    }

    public void Save() => _context.SaveChanges();

    public void Update(TEntity data) {
        _dbSet.Attach(data);
        _context.Entry(data).State = EntityState.Modified;
    }
}