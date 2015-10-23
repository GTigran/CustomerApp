using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Common.Tools
{
    public class ResponseResult
    {
        public bool Success { get; set; }

        public ResponseResult(bool isScuccess = true)
        {
            Success = isScuccess;
        }



    }
}
