using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockMaintenanceStatusRepository : IMaintenanceStatusRepository
    {
        private List<MaintenanceStatus> Maintenancestatuses = new List<MaintenanceStatus>();

        public ICollection<MaintenanceStatus> GetAll()
        {
            return Maintenancestatuses;
        }

        public MaintenanceStatus GetById(int maintenancestatusId)
        {
            return Maintenancestatuses.Single(m => m.Id == maintenancestatusId);
        }
    }
}
