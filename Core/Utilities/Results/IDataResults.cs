using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResults<T>:IResult
    {
        T Data { get; }
    }
}
