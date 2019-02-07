using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface ITenantRepository
    {
        Tenant GetById(int tenantId);
    }
}
