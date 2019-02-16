using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Services
{
    public interface ILeaseService
    {
        Lease GetById(int leaseId);
        ICollection<Lease> GetByTenantId(string tenantId);
        ICollection<Lease> GetByHomeId(int homeId);

    }
    public class LeaseService : ILeaseService
    {
        private readonly ILeaseRepository _leaseRepository;

        public LeaseService(ILeaseRepository leaseRepository)
        {
            _leaseRepository = leaseRepository;
        }
        public ICollection<Lease> GetByHomeId(int homeId)
        {
            return _leaseRepository.GetByHomeId(homeId);
        }

        public Lease GetById(int leaseId)
        {
            return _leaseRepository.GetById(leaseId);
        }

        public ICollection<Lease> GetByTenantId(string tenantId)
        {
            return _leaseRepository.GetByTenantId(tenantId);
        }
    }
}
