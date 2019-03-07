using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Services
{
    public interface IHomeService
    {
        Home GetById(int homeId);
        ICollection<Home> GetByLandlordId(string landlordId);
        void Create(Home newHome);
    }

    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public void Create(Home newHome)
        {
            _homeRepository.Create(newHome);
        }

        public Home GetById(int homeId)
        {
            // Here we consume the Data Service
            return _homeRepository.GetById(homeId);
        }

        public ICollection<Home> GetByLandlordId(string landlordId)
        {
            return _homeRepository.GetByLandlordId(landlordId);
        }

    }
}
