using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain
{
    public abstract class BaseEntity<IDType> : IBaseEntity
    {
        public virtual IDType Id { get; set; }
        object IBaseEntity.Id { get => Id; set => throw new NotImplementedException(); }
    }
}
