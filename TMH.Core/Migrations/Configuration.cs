using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMH.Core.DbContext;

namespace TMH.Core.Migrations
{
    public class Configuration
    {
        private readonly TMHContext _context;

        public Configuration(TMHContext context)
        {
            this._context = context;
        }

        public async Task SeedData()
        {
           
        }
    }
}
