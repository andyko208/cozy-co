using Cozy.Domain.Models;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cozy.Service.Services
{
    public interface IPaymentService
    {
        Payment GetById(int paymentId);
        ICollection<Payment> GetByTenantdId(string tenantId);
        ICollection<Payment> GetByLeaseId(int leaseId);
    }

    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Payment GetById(int paymentId)
        {
            return _paymentRepository.GetById(paymentId);
        }

        public ICollection<Payment> GetByLeaseId(int leaseId)
        {
            return _paymentRepository.GetByLeaseId(leaseId);
        }

        public ICollection<Payment> GetByTenantdId(string tenantId)
        {
            return _paymentRepository.GetByTenantdId(tenantId);
        }
    }
}
