using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockMaintenanceStatusRepository : IMaintenanceStatusRepository
    {
        private List<Maintenance> Maintenances = new List<Maintenance>();

        public ICollection<MaintenanceStatus> GetAll()
        {
            throw new NotImplementedException();
        }

        public MaintenanceStatus GetById(int maintenancestatusId)
        {
            return Maintenances.Single(m => m.MaintenanceStatusId == maintenancestatusId);
        }
    }
}
