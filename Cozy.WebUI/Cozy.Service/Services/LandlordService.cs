using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Services
{
    public interface ILandlordService
    {
        Landlord GetById(int landlordId);
    }
    public class LandlordService : ILandlordService
    {
        private readonly ILandlordRepository _landlordRepository;

        public LandlordService(ILandlordRepository landlordRepository)
        {
            _landlordRepository = landlordRepository;
        }

        public Landlord GetById(int landlordId)
        {
            return _landlordRepository.GetById(landlordId);
        }
    }
}
