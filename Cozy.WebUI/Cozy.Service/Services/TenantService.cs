using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Services
{
    public interface ITenantService
    {
        Tenant GetById(string tenantId);
    }

    public class TenantService : ITenantService
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantService(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public Tenant GetById(string tenantId)
        {
            return _tenantRepository.GetById(tenantId);
        }
    }
}
