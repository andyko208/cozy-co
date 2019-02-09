using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface ITenantRepository
    {
        Tenant GetById(int tenantId);

        Tenant Create(Tenant newTenant);

        Tenant Update(Tenant updatedTenant);

        bool deleteById(int tenantId);
    }
}
