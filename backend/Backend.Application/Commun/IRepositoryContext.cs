using Backend.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Commun
{
    public interface IRepositoryContext<TEntity> where TEntity : class, IBaseEntity
    {
        DbContext Context { get; }
        DbSet<TEntity> DataSet { get; }
    }
}
