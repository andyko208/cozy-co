using Cozy.Domain.Models;
using CozyData.Context;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.EFCore
{
    public class EFCorePaymentRepository : IPaymentRepository
    {
        public Payment GetById(int paymentId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Payments.Single(p => p.Id == paymentId);
            }
        }

        public ICollection<Payment> GetByLeaseId(int leaseId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Payments
                    .Where(p => p.LeaseId == leaseId)
                    .ToList();
            }
        }

        public ICollection<Payment> GetByTenantdId(string tenantId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Payments
                    .Where(p => p.TenantId == tenantId)
                    .ToList();
            }
        }
    }
}
