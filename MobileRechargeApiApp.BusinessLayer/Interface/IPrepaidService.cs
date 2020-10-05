using MobileRechargeApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApiApp.BusinessLayer.Interface
{
   public interface IPrepaidService
    {
        Task<IEnumerable<Prepaid>> PrePaidReadAsync();
        Task<Prepaid> PrepaidCreateAsync(Prepaid prepaid);
        Task<Prepaid> PrePaidUpdateAsync(Prepaid prepaid);
        Task<bool> PrePaidDeleteAsync(Prepaid prepaid);
    }
}
