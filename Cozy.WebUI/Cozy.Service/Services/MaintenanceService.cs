using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Services
{
    public interface IMaintenanceService
    {
        Maintenance GetById(int maintenanceId);
        ICollection<Maintenance> GetByHomeId(int homeId);
        ICollection<Maintenance> GetByTenantId(string tenantId);
        ICollection<Maintenance> GetByMaintenanceStatusId(int maintenancestatusId);
    }

    public class MaintenanceService : IMaintenanceService
    {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            _maintenanceRepository = maintenanceRepository;
        }

        public ICollection<Maintenance> GetByHomeId(int homeId)
        {
            return _maintenanceRepository.GetByHomeId(homeId);
        }

        public Maintenance GetById(int maintenanceId)
        {
            return _maintenanceRepository.GetById(maintenanceId);
        }

        public ICollection<Maintenance> GetByMaintenanceStatusId(int maintenancestatusId)
        {
            return _maintenanceRepository.GetByMaintenanceStatusId(maintenancestatusId);
        }

        public ICollection<Maintenance> GetByTenantId(string tenantId)
        {
            return _maintenanceRepository.GetByTenantId(tenantId);
        }
    }
}
