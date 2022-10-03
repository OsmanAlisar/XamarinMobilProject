using System;
using System.Collections.Generic;
using System.Text;
namespace OsmanAlisarIdesse.Models
{
    public class Product
    {
        long _id;
        string _code;
        string _description;
        char _status;
        int _sortOrderNo;
        public long Id { get => _id; set => _id = value; }
        public string Code { get => _code; set => _code = value; }
        public string Description { get => _description; set => _description = value; }
        public char Status { get => _status; set => _status = value; }
        public int SortOrderNo { get => _sortOrderNo; set => _sortOrderNo = value; }
    }
}
