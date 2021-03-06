﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Domain.Models
{
    public class Landlord
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int LanlordId { get; set; }
        // Navigation Collection
        public IEnumerable<Home> Homes { get; set; }
    }
}
