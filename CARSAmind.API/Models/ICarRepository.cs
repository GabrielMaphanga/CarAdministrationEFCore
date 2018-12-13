using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CARSAmind.API.Models
{
    public interface ICarRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(Car car, TEntity entity);
        void Delete(Car car);
    }
}
