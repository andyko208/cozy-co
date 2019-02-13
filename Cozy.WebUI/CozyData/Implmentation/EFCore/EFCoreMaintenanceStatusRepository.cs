using Cozy.Domain.Models;
using CozyData.Context;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.EFCore
{
    public class EFCoreMaintenanceStatusRepository : IMaintenanceStatusRepository
    {
        public ICollection<MaintenanceStatus> GetAll()
        {
            throw new NotImplementedException();
        }

        public MaintenanceStatus GetById(int maintenancestatusId)
        {
            using (var context = new CozyDbContext())
            {
                return context.MaintenanceStatuses.Single(m => m.Id == maintenancestatusId);
            }
        }
    }
}
