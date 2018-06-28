using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMH.Core.IRepository;
using TMH.Core.IService;
using TMH.Core.Migrations;
using TMH.Repository;
using TMH.Service;

namespace TMH.Api
{
    public class DependencyInjection
    {
        public void Map(IServiceCollection services)
        {
            services.AddTransient<Configuration>();
            services.AddTransient<IUnitOfWork, Recipe.NetCore.Base.Abstract.UnitOfWork>();
            services.AddSingleton(typeof(IUserService), typeof(UserService));
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(typeof(IUserRepository), typeof(UserRepository));            
            services.AddSingleton(typeof(IService), typeof(Recipe.NetCore.Base.Generic.Service));
        }
    }
}
