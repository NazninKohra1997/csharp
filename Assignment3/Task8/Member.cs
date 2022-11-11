﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Member
    {
        private string membershipId;
        public string Name { get; set; }
        public DateTime MembershipExpirationDate { get; private set; }

        public Member()
        {
            membershipId = Guid.NewGuid().ToString();
        }
    }
}
