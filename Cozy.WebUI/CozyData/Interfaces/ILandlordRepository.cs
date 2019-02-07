using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface ILandlordRepository
    {
        Landlord GetById(int landlordId);
    }
}
