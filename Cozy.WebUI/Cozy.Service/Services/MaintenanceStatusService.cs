using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Services
{
    public interface IMaintenanceStatusService
    {
        MaintenanceStatus GetById(int maintenancestatusId);
        ICollection<MaintenanceStatus> GetAll();
    }

    public class MaintenanceStatusService : IMaintenanceStatusService
    {
        private readonly IMaintenanceStatusRepository _maintenancestatusRepository;

        public MaintenanceStatusService(IMaintenanceStatusRepository maintenancestatusRepository)
        {
            _maintenancestatusRepository = maintenancestatusRepository;
        }

        public ICollection<MaintenanceStatus> GetAll()
        {
            return _maintenancestatusRepository.GetAll();
        }

        public MaintenanceStatus GetById(int maintenancestatusId)
        {
            return _maintenancestatusRepository.GetById(maintenancestatusId);
        }
    }
}
