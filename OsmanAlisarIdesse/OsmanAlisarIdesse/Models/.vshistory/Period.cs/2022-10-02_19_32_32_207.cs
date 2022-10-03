using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    public class Period
    {
        long _id;
        string _code;
        string _beginDate;
        string _endDate;
        char _status;

        public long Id { get => _id; set => _id = value; }
        public string Code { get => _code; set => _code = value; }
        public string EndDate { get => _endDate; set => _endDate = value; }
        public char Status { get => _status; set => _status = value; }
    }
}
