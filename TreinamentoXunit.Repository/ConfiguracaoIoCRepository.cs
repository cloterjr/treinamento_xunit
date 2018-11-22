using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoXunit.Repository.Impl;
using TreinamentoXunit.Repository.Interfaces;

namespace TreinamentoXunit.Repository
{
    public static class ConfiguracaoIoCRepository
    {

        public static void Configure(Container container)
        {
            container.Register<IUserRepository, UserRepository>();

        }
    }
}
