using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Commun
{
    public interface IRepositoryQuery<out TEntity, IDTYPE> where TEntity : class, IBaseEntity
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllNoTracking();
        IQueryable<TEntity> GetById(IDTYPE id);
        IQueryable<TEntity> GetByIdNoTracking(IDTYPE id);
    }
}
