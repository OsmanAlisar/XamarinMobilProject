﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public int CardId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string EMail { get; set; }


    }
}
