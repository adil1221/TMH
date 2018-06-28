using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMH.Common.Helper;

namespace TMH.Api.Utils
{
    public static class FilterRequest
    {
        public static JSONAPIRequest GetRequest(this DefaultHttpRequest request)
        {
            var parameters = request.Query.ToDictionary(q => q.Key, q => q.Value.ToString());
            var jsonApiRequest = JSONAPIEFQueryBuilder.GetJSONAPIRequest(parameters);
            return jsonApiRequest;
        }
    }
}
