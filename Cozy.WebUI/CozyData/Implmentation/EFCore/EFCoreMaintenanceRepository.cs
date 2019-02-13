using Cozy.Domain.Models;
using CozyData.Context;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.EFCore
{
    public class EFCoreMaintenanceRepository : IMaintenanceRepository
    {
        public Maintenance Create(Maintenance newMaintenance)
        {
            using (var context = new CozyDbContext())
            {
                context.Maintenances.Add(newMaintenance);
                context.SaveChanges();

                return newMaintenance;
            }
        }

        public bool deleteById(int maintenanceId)
        {
            using (var context = new CozyDbContext())
            {
                var maintenanceToBeDeleted = GetById(maintenanceId);
                context.Remove(maintenanceToBeDeleted);
                context.SaveChanges();
            }
            if (GetById(maintenanceId) == null)
                return true;
            return false;
        }

        public ICollection<Maintenance> GetByHomeId(int homeId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Maintenances
                    .Where(m => m.HomeId == homeId)
                    .ToList();
            }

        }

        public Maintenance GetById(int maintenanceId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Maintenances.Single(m => m.Id == maintenanceId);
            }
        }

        public ICollection<Maintenance> GetByMaintenanceStatusId(int maintenancestatusId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Maintenances
                    .Where(m => m.MaintenanceStatusId == maintenancestatusId)
                    .ToList();
            }
        }

        public ICollection<Maintenance> GetByTenantId(string tenantId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Maintenances
                    .Where(m => m.TenantId == tenantId)
                    .ToList();
            }
        }

        public Maintenance Update(Maintenance updatedMaintenance)
        {
            using (var context = new CozyDbContext())
            {
                var existingMaintenance = GetById(updatedMaintenance.Id);
                context.Entry(existingMaintenance).CurrentValues.SetValues(updatedMaintenance);
                context.SaveChanges();

                return existingMaintenance;
            }
        }
    }
}
