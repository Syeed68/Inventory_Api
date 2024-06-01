using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepositories.Common
{
    public interface IRepository<T> where T : class
    {
        public ICollection<T> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
