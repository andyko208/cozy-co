using Cozy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CozyData.Interfaces
{
    public interface IPaymentRepository
    {
        Payment GetById(int paymentId);
        ICollection<Payment> GetByTenantdId(string tenantId);
        ICollection<Payment> GetByLeaseId(int leaseId);
    }
}
