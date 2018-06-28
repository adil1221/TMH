using Microsoft.EntityFrameworkCore;
using Recipe.NetCore.Base.Generic;
using Recipe.NetCore.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMH.Core.Entity;
using TMH.Core.IRepository;

namespace TMH.Repository
{
    public class UserRepository : Repository<ApplicationUser, long>, IUserRepository
    {
        private readonly IRequestInfo _requestInfo;

        public UserRepository(IRequestInfo requestInfo) : base(requestInfo)
        {
            this._requestInfo = requestInfo;
        }
    }
}
