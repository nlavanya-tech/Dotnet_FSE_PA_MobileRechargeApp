using MobileRechargeApiApp.DataLayer.Context;
using MobileRechargeApiApp.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApiApp.BusinessLayer.Services.Repository
{
   public class PostpaidRepository : IPostpaidRepository
    {
        private readonly IMongoDbContext _context;
        public PostpaidRepository(IMongoDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Postpaid>> PostPaidReadAsync()
        {
            var postpaid = await _context.Postpaid.Find(team => true).ToListAsync();
            return postpaid;
        }
        //Add team into Inmemory Db and return teams
        public async Task<Postpaid> PostpaidCreateAsync(Postpaid postpaid)
        {
            await _context.Postpaid.InsertOneAsync(postpaid);
            return postpaid;
        }
        //Update team into Inmemory Db and return teams 
        public async Task<Postpaid> PostPaidUpdateAsync(Postpaid postpaid)
        {
            ReplaceOneResult updateResult = await _context.Postpaid.ReplaceOneAsync(filter: g => g.MobileNumber == postpaid.MobileNumber, replacement: postpaid);
            return postpaid;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> PostPaidDeleteAsync(Postpaid postpaid)
        {
            FilterDefinition<Postpaid> filter = Builders<Postpaid>.Filter.Eq(m => m.MobileNumber, postpaid.MobileNumber);
            DeleteResult deleteResult = await _context.Postpaid.DeleteOneAsync(filter);
            bool result = deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
            return result;
        }


    }
}
