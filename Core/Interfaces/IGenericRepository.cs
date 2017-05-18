using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        //CRUD Methods
        void Insert(Entity entity);

        void Delete<T>(T Id);

        void Update(Entity entityObj);

        Entity FindById<T>(T Id);

        IEnumerable<Entity> GetAllProducts();

        IQueryable<Entity> GetWhere(System.Linq.Expressions.Expression<Func<Entity, bool>> where);

    }
}
