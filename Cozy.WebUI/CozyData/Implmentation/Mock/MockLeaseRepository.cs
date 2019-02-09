using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockLeaseRepository : ILeaseRepository
    {
        private List<Lease> Leases = new List<Lease>();
        
        public ICollection<Lease> GetByHomeId(int homeId)
        {
            return Leases.FindAll(l => l.HomeId == homeId);
        }

        public Lease GetById(int leaseId)
        {
            return Leases.Single(l => l.LeaseId == leaseId);
        }

        public ICollection<Lease> GetByTenantId(string tenantId)
        {
            return Leases.FindAll(l => l.TenantId == tenantId);
        }
    }
}
