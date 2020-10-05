using MobileRechargeApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApiApp.BusinessLayer.Services.Repository
{
   public interface IPostpaidRepository
    {
        Task<IEnumerable<Postpaid>> PostPaidReadAsync();
        Task<Postpaid> PostpaidCreateAsync(Postpaid postpaid);
        Task<Postpaid> PostPaidUpdateAsync(Postpaid postpaid);
        Task<bool> PostPaidDeleteAsync(Postpaid postpaid);
    }
}
