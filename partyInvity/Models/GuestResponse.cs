﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace partyInvity.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? willAttend { get; set; }
    }
}
