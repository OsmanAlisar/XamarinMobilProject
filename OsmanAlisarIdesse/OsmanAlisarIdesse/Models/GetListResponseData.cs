using System;
using System.Collections.Generic;
using System.Text;
namespace OsmanAlisarIdesse.Models
{
    internal class GetListResponseData
    {
        public bool success { get; set; }
        public object data { get; set; }
        public int totalRowCount { get; set; }
    }
}
