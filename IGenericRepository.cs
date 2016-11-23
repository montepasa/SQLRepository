using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WERService.SQLDB
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetFirstOrDefault(int recordId);
        IEnumerable<TEntity> GetAllRecords();
    }
}