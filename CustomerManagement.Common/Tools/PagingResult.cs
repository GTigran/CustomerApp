using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Common.Tools
{
    public class PagingResult<TResult> : ResponseResult
    {
        public IEnumerable<TResult> Result { get; set; }

        public int Count { get; set; }
    }
}
