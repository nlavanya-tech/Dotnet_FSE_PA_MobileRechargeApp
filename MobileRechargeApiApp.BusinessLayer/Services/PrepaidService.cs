using MobileRechargeApiApp.BusinessLayer.Interface;
using MobileRechargeApiApp.BusinessLayer.Services.Repository;
using MobileRechargeApiApp.DataLayer.Context;
using MobileRechargeApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApiApp.BusinessLayer.Services
{
   public class PrepaidService : IPrepaidService
    {
        //create local instance 
        private readonly IPrepaidRepository _repositary;

        public PrepaidService(IPrepaidRepository repositary)
        {
            _repositary = repositary;
        }
        //Get pospaiddetails and retrun list of pospaiddetails
        public async Task<IEnumerable<Prepaid>> PrePaidReadAsync()
        {
            var result = await _repositary.PrePaidReadAsync();
            return result;
        }
        //Create pospaiddetails
        public async Task<Prepaid> PrepaidCreateAsync(Prepaid prepaid)
        {
            await _repositary.PrepaidCreateAsync(prepaid);
            return prepaid;
        }
        //Update pospaiddetails
        public async Task<Prepaid> PrePaidUpdateAsync(Prepaid prepaid)
        {
            var result = await _repositary.PrePaidUpdateAsync(prepaid);

            return result;
        }
        //Delete pospaiddetails 
        public async Task<bool> PrePaidDeleteAsync(Prepaid prepaid)
        {
            var result = await _repositary.PrePaidDeleteAsync(prepaid);
            return result;
        }
    }
}
