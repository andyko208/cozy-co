﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Domain.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ImageURL { get; set; }

        public int HomeId { get; set; }
        public string LandlordId { get; set; }
        public Landlord Landlord { get; set; } // Navigation reference
    }
}
