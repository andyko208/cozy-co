using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CozyData.Implmentation.Mock
{
    public class MockHomeRepository : IHomeRepository
    {
        private List<Home> Homes = new List<Home>();

        public Home Create(Home newHome)
        {
            newHome.Id = Homes.OrderByDescending(h => h.Id).Single().Id + 1;
            Homes.Add(newHome);

            return newHome;
        }                               
        public bool DeleteById(int homeId)
        {
            var home = GetById(homeId);
            Homes.Remove(home);

            return true;
        }

        public Home GetById(int homeId)
        {
            return Homes.Single(h => h.Id == homeId);
        }

        public ICollection<Home> GetByLandlordId(string landlordId)
        {
            return Homes.FindAll(h => h.LandlordId == landlordId);
        }

        public Home Update(Home updatedHome)
        {
            DeleteById(updatedHome.Id); // Delete the existing home that is in the array
            Homes.Add(updatedHome);

            return updatedHome;
        }
    }
}
