using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockLandlordRepository : ILandlordRepository
    {
        private List<Landlord> Landlords = new List<Landlord>();

        public Landlord Create(Landlord newLandlord)
        {
            Guid g = new Guid();
            newLandlord.Id = g.ToString();
            // newLandlord.Id = Landlord.OrderByDescending(l => l.Id).Single().Id + 1;
            Landlords.Add(newLandlord);

            return newLandlord;
        }

        public bool deleteById(int landlordId)
        {
            var landlord = GetById(landlordId);
            Landlords.Remove(landlord);

            return true;
        }

        public Landlord GetById(int landlordId)
        {
            return Landlords.Single(l => l.LanlordId == landlordId);
        }

        public Landlord Update(Landlord updatedLandlord)
        {
            deleteById(updatedLandlord.LanlordId); 
            Landlords.Add(updatedLandlord);

            return updatedLandlord;
        }
    }
}
