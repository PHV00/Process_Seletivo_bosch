using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Commun
{
    public interface IRepository<TEntity, IDTYPE> : IRepositoryQuery<TEntity, IDTYPE>, IRepositoryAsync, IRepositoryOperation<TEntity>, IRepositoryContext<TEntity> where TEntity : class, IBaseEntity
    {
        void SaveChanges();
    }
}
