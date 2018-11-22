using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoXunit.Repository;
using TreinamentoXunit.Repository.Impl;
using TreinamentoXunit.Repository.Interfaces;
using TreinamentoXunit.Services.Impl;
using TreinamentoXunit.Services.Interfaces;

namespace TreinamentoXunit.Services
{
    public static class ConfiguracaoIoCServices
    {
        public static void Configure(Container container)
        {
            ConfiguracaoIoCRepository.Configure(container);

            container.Register<IUserService, UserService>();
        }
    }
}
