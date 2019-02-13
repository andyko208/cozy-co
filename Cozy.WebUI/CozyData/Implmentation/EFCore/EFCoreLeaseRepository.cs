using Cozy.Domain.Models;
using CozyData.Context;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.EFCore
{
    public class EFCoreLeaseRepository : ILeaseRepository
    {
        public ICollection<Lease> GetByHomeId(int homeId)
        {
            throw new NotImplementedException();
        }

        public Lease GetById(int leaseId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Leases.Single(l => l.Id == leaseId);
            }
        }

        public ICollection<Lease> GetByTenantId(string tenantId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Leases
                    .Where(m => m.TenantId == tenantId)
                    .ToList();
            }
        }
    }
}
