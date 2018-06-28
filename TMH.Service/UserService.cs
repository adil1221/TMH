using Recipe.NetCore.Base.Abstract;
using Recipe.NetCore.Base.Generic;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using TMH.Core.DTO;
using TMH.Core.Entity;
using TMH.Core.IRepository;
using TMH.Core.IService;

namespace TMH.Service
{
    public class UserService : Service<IUserRepository, ApplicationUser, UserDTO, long>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork
            , IUserRepository repository)
            : base(unitOfWork, repository)
        {
           
        }
    }
}
