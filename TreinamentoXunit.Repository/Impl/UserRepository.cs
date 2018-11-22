using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoXunit.Domain.Entities;
using TreinamentoXunit.Repository.Interfaces;

namespace TreinamentoXunit.Repository.Impl
{
    public class UserRepository : IUserRepository
    {
        public async Task<IEnumerable<User>> GetAll()
        {
            ICollection<User> userList = new List<User>();

            userList.Add(new User() { Id = 1, Name = "Maria João", Document = "332.456.342-33", Active = true });
            userList.Add(new User() { Id = 1, Name = "Adalberto Silva", Document = "232.346.342-33", Active = true });
            userList.Add(new User() { Id = 1, Name = "Nicolinha", Document = "123.456.543-33", Active = true });

            userList.Add(new User() { Id = 1, Name = "Mendiguera", Document = "123.456.423-12", Active = false });
            userList.Add(new User() { Id = 1, Name = "Diet", Document = "222.456.423-12", Active = false });

            await Task.Run(() => { });

            return userList;
        }
    }
}
