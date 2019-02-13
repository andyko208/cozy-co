using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CozyData.Implmentation.Mock
{
    public class MockPaymentRespository : IPaymentRepository
    {
        private List<Payment> Payments = new List<Payment>();
        public Payment GetById(int paymentId)
        {
            return Payments.Single(p => p.Id == paymentId);
        }

        public ICollection<Payment> GetByLeaseId(int leaseId)
        {
            return Payments.FindAll(p => p.LeaseId == leaseId);
        }

        public ICollection<Payment> GetByTenantdId(string tenantId)
        {
            return Payments.FindAll(p => p.TenantId == tenantId);
        }
    }
}
