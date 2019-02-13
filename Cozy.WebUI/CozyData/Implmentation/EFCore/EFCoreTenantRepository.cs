using Cozy.Domain.Models;
using CozyData.Context;
using CozyData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CozyData.Implmentation.EFCore
{
    public class EFCoreTenantRepository : ITenantRepository
    {
        public Tenant Create(Tenant newTenant)
        {
            using (var context = new CozyDbContext())
            {
                context.Tenants.Add(newTenant);
                context.SaveChanges();

                return newTenant; 
            }
        }

        public bool deleteById(string tenantId)
        {
            using (var context = new CozyDbContext())
            {
                var tenantToBeDeleted = GetById(tenantId);
                context.Remove(tenantToBeDeleted);
                context.SaveChanges();
            }
            if (GetById(tenantId) == null)
                return true;
            return false;
        }

        public Tenant GetById(string tenantId)
        {
            using (var context = new CozyDbContext())
            {
                return context.Tenants.Single(t => t.Id == tenantId);
            }
        }

        public Tenant Update(Tenant updatedTenant)
        {
            using (var context = new CozyDbContext())
            {
                var existingTenant = GetById(updatedTenant.Id);
                context.Entry(existingTenant).CurrentValues.SetValues(updatedTenant);
                context.SaveChanges();

                return existingTenant;
            }
        }
    }
}
