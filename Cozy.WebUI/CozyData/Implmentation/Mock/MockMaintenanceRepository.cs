using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockMaintenanceRepository : IMaintenanceRepository
    {
        private List<Maintenance> Maintenances = new List<Maintenance>();
        public Maintenance Create(Maintenance newMaintenance)
        {
            newMaintenance.Id = Maintenances.OrderByDescending(h => h.Id).Single().Id + 1;
            Maintenances.Add(newMaintenance);

            return newMaintenance;
        }

        public bool deleteById(int maintenanceId)
        {
            var maintenance = GetById(maintenanceId);
            Maintenances.Remove(maintenance);

            return true;
        }

        public ICollection<Maintenance> GetByHomeId(int homeId)
        {
            return Maintenances.FindAll(m => m.HomeId == homeId);
        }

        public Maintenance GetById(int maintenanceId)
        {
            return Maintenances.Single(m => m.Id == maintenanceId);
        }

        public ICollection<Maintenance> GetByMaintenanceStatusId(int maintenancestatusId)
        {
            return Maintenances.FindAll(m => m.MaintenanceStatusId == maintenancestatusId);
        }

        public ICollection<Maintenance> GetByTenantId(string tenantId)
        {
            return Maintenances.FindAll(m => m.TenantId == tenantId);
        }

        public Maintenance Update(Maintenance updatedMaintenance)
        {
            deleteById(updatedMaintenance.Id); 
            Maintenances.Add(updatedMaintenance);

            return updatedMaintenance;
        }
    }
}
