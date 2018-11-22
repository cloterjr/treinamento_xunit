using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoXunit.Domain.Entities;
using TreinamentoXunit.Repository.Interfaces;
using TreinamentoXunit.Services.Interfaces;

namespace TreinamentoXunit.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> GetActiveUsers()
        {
            var result = await _userRepository.GetAll();
            return result.Where(u => u.Active).ToList();
        }
    }
}
