using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMH.Api.Utils;

namespace TMH.Api.Controllers
{
    public class BaseController : Controller
    {
        protected virtual dynamic JsonResponse(dynamic dtoObject)
        {
            if (dtoObject.HasErrors)
            {
                return new ValidationFailedResult(dtoObject.Error);
            }
            else
            {
                return this.Ok(dtoObject);
            }
        }
    }
}