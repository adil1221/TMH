using System;
using System.Collections.Generic;
using System.Text;

namespace TMH.Core.DTO
{
    public class DTOBase
    {
        public bool HasErrors { get; set; }

        public Exception Error { get; set; }
    }
}
