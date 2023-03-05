using DesignPatterns.Models.Data;

namespace DesignPatterns.Repository; 
public class UnitOfWork : IUnitOfWork {
    private DesignPatternsContext _context = null!;
    private IRepository<Beer> _beers = null!;
    private IRepository<Brand> _brands = null!;
    public IRepository<Beer> Beers {
        get {
            return _beers == null ?
                _beers = new Repository<Beer>(_context) : _beers;
        }
    }
    public IRepository<Brand> Brands {
        get {
            return _brands == null ?
                _brands = new Repository<Brand>(_context) : _brands;
        }
    }
    public void Save() {
        _context.SaveChanges();
    }
}
