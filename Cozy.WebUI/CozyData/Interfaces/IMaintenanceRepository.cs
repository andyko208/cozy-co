using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface IMaintenanceRepository
    {
        // Read
        Maintenance GetById(int maintenanceId);
        ICollection<Maintenance> GetByHomeId(int homeId);
        ICollection<Maintenance> GetByTenantId(string tenantId);
        ICollection<Maintenance> GetByMaintenanceStatusId(int maintenancestatusId);

        // Create 
        Maintenance Create(Maintenance newMaintenance);

        // Update
        Maintenance Update(Maintenance updatedMaintenance);

        // Delete
        bool deleteById(int maintenanceId);


    }
}
