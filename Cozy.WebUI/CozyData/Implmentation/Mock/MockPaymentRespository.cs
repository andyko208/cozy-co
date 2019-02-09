using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Implmentation.Mock
{
    public class MockPaymentRespository : IPaymentRepository
    {
        public Payment GetById(int paymentId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Payment> GetByLeaseId(string leaseId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Payment> GetByTenantdId(string tenantId)
        {
            throw new NotImplementedException();
        }
    }
}
