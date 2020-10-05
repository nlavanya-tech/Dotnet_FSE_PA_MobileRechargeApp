using MobileRechargeApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApiApp.BusinessLayer.Services.Repository
{
    public interface IPrepaidRepository
    {
        Task<IEnumerable<Prepaid>> PrePaidReadAsync();
        Task<Prepaid> PrepaidCreateAsync(Prepaid prepaid);
        Task<Prepaid> PrePaidUpdateAsync(Prepaid prepaid);
        Task<bool> PrePaidDeleteAsync(Prepaid prepaid);
    }
}
