using MobileRechargeApiApp.BusinessLayer.Interface;
using MobileRechargeApiApp.BusinessLayer.Services.Repository;
using MobileRechargeApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApiApp.BusinessLayer.Services
{
   public class PostpaidService : IPostpaidService
    {
        //create local instance 
        private readonly IPostpaidRepository _repositary;

        public PostpaidService(IPostpaidRepository repositary)
        {
            _repositary = repositary;
        }

        //Get pospaiddetails and retrun list of pospaiddetails
        public async Task<IEnumerable<Postpaid>> PostPaidReadAsync()
        {
            var result = await _repositary.PostPaidReadAsync();
            return result;
        }
        //Create pospaiddetails
        public async Task<Postpaid> PostpaidCreateAsync(Postpaid postpaid)
        {
            await _repositary.PostpaidCreateAsync(postpaid);
            return postpaid;
        }
        //Update pospaiddetails
        public async Task<Postpaid> PostPaidUpdateAsync(Postpaid postpaid)
        {
            var postpaid1 = await _repositary.PostPaidUpdateAsync(postpaid);

            return postpaid1;
        }
        //Delete pospaiddetails 
        public async Task<bool> PostPaidDeleteAsync(Postpaid postpaid)
        {
            var result = await _repositary.PostPaidDeleteAsync(postpaid);
            return result;
        }
    }
}
