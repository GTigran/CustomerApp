using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Common.Tools
{
    public class GetListModel
    {
        public int PageIndex { get; set; }


        private int _pageSize;

        public int PageSize
        {
            get { return _pageSize == 0 ? 10 : _pageSize; }
            set { _pageSize = value; }
        }


        public int StartIndex => PageSize*PageIndex;

        public string SearchKeyword { get; set; }

    }
}
