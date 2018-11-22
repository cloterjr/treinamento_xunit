using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoXunit.Domain.Entities;

namespace TreinamentoXunit.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetActiveUsers();
    }
}
