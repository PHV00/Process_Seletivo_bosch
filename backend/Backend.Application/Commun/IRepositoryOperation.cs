using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Commun
{
    public interface IRepositoryOperation<in TEntity> where TEntity : class, IBaseEntity
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
