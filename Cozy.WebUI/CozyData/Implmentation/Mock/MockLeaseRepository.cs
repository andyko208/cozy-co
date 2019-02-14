using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockLeaseRepository : ILeaseRepository
    {
        private List<Lease> Leases = new List<Lease>()
        {
            new Lease {Id = 1, HomeId = 1, StartDate = DateTime.Now.AddMonths(-5), EndDate = DateTime.Now.AddMonths(3), RentPrice = 800},
            new Lease {Id = 2, HomeId = 1, StartDate = DateTime.Now.AddMonths(-10), EndDate = DateTime.Now.AddMonths(-5), RentPrice = 740},
            new Lease {Id = 3, HomeId = 1, StartDate = DateTime.Now.AddMonths(-20), EndDate = DateTime.Now.AddMonths(-12), RentPrice = 730}
        };
        
        public ICollection<Lease> GetByHomeId(int homeId)
        {
            return Leases.FindAll(l => l.HomeId == homeId);
        }

        public Lease GetById(int leaseId)
        {
            return Leases.Single(l => l.Id == leaseId);
        }

        public ICollection<Lease> GetByTenantId(string tenantId)
        {
            return Leases.FindAll(l => l.TenantId == tenantId);
        }
    }
}
