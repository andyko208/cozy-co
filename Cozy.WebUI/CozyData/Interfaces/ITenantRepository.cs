using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface ITenantRepository
    {
        Tenant GetById(string tenantId);

        Tenant Create(Tenant newTenant);

        Tenant Update(Tenant updatedTenant);

        bool deleteById(string tenantId);
    }
}
