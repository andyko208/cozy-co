using Cozy.Domain.Models;
using CozyData.Context;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.EFCore
{
    public class EFCoreLandlordRepository : ILandlordRepository
    {
        public Landlord Create(Landlord newLandlord)
        {
            using (var context = new CozyDbContext())
            {
                context.Landlords.Add(newLandlord);
                context.SaveChanges();

                return newLandlord;
            }
        }

        public bool deleteById(int landlordId)
        {
            using (var context = new CozyDbContext())
            {
                var LandlordToBeDeleted = GetById(landlordId);
                context.Remove(LandlordToBeDeleted);
                context.SaveChanges();
            }
            if (GetById(landlordId) == null)
                return true;
            return false;
        }

        public Landlord GetById(int landlordId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Landlords.Single(l => l.LanlordId == landlordId);
            }
        }

        public Landlord Update(Landlord updatedLandlord)
        {
            using (var context = new CozyDbContext())
            {
                var existingLandlord = GetById(updatedLandlord.LanlordId);
                context.Entry(existingLandlord).CurrentValues.SetValues(updatedLandlord);
                context.SaveChanges();

                return existingLandlord;
            }
        }
    }
}
