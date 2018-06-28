using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using TMH.Core.DTO;
using TMH.Core.Entity;
using TMH.Core.IRepository;

namespace TMH.Core.IService
{
    public interface IUserService : IService<IUserRepository, ApplicationUser, UserDTO, long>
    {

    }
}
