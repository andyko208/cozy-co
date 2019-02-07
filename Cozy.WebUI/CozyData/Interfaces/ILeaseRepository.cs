using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface ILeaseRepository
    {
        // Read
        Lease GetById(int leaseId);
        ICollection<Lease> GetByTenantId(string tenantId);
        ICollection<Lease> GetByHomeId(int homeId);
    }
}
