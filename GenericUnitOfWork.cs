using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WERService.entity;

namespace WERService.SQLDB
{
    public class GenericUnitOfWork
    {
        private WerEntities _dbContext = new WerEntities();
        public Type TheType { get; set; }
        public GenericRepository<TEntitiesType> GetRepoInstance<TEntitiesType>() where TEntitiesType : class
        {
            return new GenericRepository<TEntitiesType>(_dbContext);
        }
    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
    }
}