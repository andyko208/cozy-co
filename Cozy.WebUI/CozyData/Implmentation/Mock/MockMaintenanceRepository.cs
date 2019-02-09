using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockMaintenanceRepository : IMaintenanceRepository
    {
        public Maintenance Create(Maintenance newMaintenance)
        {
            throw new NotImplementedException();
        }

        public bool deleteById(int maintenanceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Maintenance> GetByHomeId(int homeId)
        {
            throw new NotImplementedException();
        }

        public Maintenance GetById(int maintenanceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Maintenance> GetByMaintenanceStatusId(int maintenancestatusId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Maintenance> GetByTenantId(string tenantId)
        {
            throw new NotImplementedException();
        }

        public Maintenance Update(Maintenance updatedMaintenance)
        {
            throw new NotImplementedException();
        }
    }
}
