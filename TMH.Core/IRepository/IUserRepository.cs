using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using TMH.Core.Entity;

namespace TMH.Core.IRepository
{
    public interface IUserRepository : IRepository<ApplicationUser, long>
    {
    }
}
