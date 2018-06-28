using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe.NetCore.Base.Abstract
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
