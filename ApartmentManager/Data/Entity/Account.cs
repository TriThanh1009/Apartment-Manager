﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Account : DomainObject
    {
        public string Acc { get; set; }
        public string Pass { get; set; }
    }
}