using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface IHomeDataService
    {
        // Read
        Home GetById(int homeId);
        ICollection<Home> GetByLandlordid(int landlordId);

        // Create 
        Home Create(Home newHome);

        // Update
        Home Update(Home updatedHome);

        // Delete
        bool DeleteById(int homeId);

    }
}
