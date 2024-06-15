using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Core.Response
{
    public interface IDataResponse<out T>
    {
        public T Data { get; }
        public int StatusCode { get; }
        public string Message { get; }
        public Exception Exception { get; }

    }
}
