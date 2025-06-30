using Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Commun
{
    public interface IRepositoryAsync    
    {
        Task<int> SaveChangeAsync();
    }
}
