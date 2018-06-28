using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMH.Core.IService;
using Microsoft.AspNetCore.Http.Internal;
using TMH.Api.Utils;

namespace TMH.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        public async Task<IActionResult> GetAllUsers()
        {
            var request = new DefaultHttpRequest(HttpContext).GetRequest();
            return this.JsonResponse(await this._userService.GetAllAsync(request));
        }
    }
}