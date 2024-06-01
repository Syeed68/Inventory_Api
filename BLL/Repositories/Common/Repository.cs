using BLL.IRepositories.Common;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BLL.Repositories.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }
        private DbSet<T> Table
        {
            get
            {
                return _db.Set<T>();
            }
        }
        public ICollection<T> GetAll()
        {
            return Table.ToList();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).AsNoTracking();
        }
    }
}
