using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface IMaintenanceStatusRepository
    {
        MaintenanceStatus GetById(int maintenancestatusId);
        ICollection<MaintenanceStatus> GetAll();
    }
}
