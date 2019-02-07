using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Implmentation.EFCore
{
    public class EFCoreHomeRepository : IHomeRepository
    {
        public Home Create(Home newHome)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int homeId)
        {
            throw new NotImplementedException();
        }

        public Home GetById(int homeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Home> GetByLandlordId(string landlordId)
        {
            throw new NotImplementedException();
        }

        public Home Update(Home updatedHome)
        {
            throw new NotImplementedException();
        }
    }
}
