using System;
using System.Collections.Generic;
using System.Text;

namespace TMH.Core.DTO
{
    public class DataTransferObject<T> : DTOBase
    {
        public DataTransferObject(T result)
        {
            this.Result = result;
        }

        public T Result { get; set; }
    }
}
