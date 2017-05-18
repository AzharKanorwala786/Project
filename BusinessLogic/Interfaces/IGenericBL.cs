using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IGenericBL<Entity> : IDisposable where Entity : class
    {
        //BL CRUD Opreations
        void Insert(Entity entity);
        void Delete<T>(T Id);
        void Update(Entity entityObj);
        void SaveChanges();
    }
}
