using MobileRechargeApiApp.DataLayer.Context;
using MobileRechargeApiApp.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileRechargeApiApp.BusinessLayer.Services.Repository
{
    public class PrepaidRepository : IPrepaidRepository
    {
        private readonly IMongoDbContext _context;
        public PrepaidRepository(IMongoDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Prepaid>> PrePaidReadAsync()
        {
            var prepaid = await _context.Prepaid.Find(team => true).ToListAsync();
            return prepaid;
        }
        //Add team into Inmemory Db and return teams
        public async Task<Prepaid> PrepaidCreateAsync(Prepaid prepaid)
        {
            await _context.Prepaid.InsertOneAsync(prepaid);
            return prepaid;
        }
        //Update team into Inmemory Db and return teams 
        public async Task<Prepaid> PrePaidUpdateAsync(Prepaid prepaid)
        {
            ReplaceOneResult updateResult = await _context.Prepaid.ReplaceOneAsync(filter: g => g.MobileNumber == prepaid.MobileNumber, replacement: prepaid);
            return prepaid;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> PrePaidDeleteAsync(Prepaid prepaid)
        {
            FilterDefinition<Prepaid> filter = Builders<Prepaid>.Filter.Eq(m => m.MobileNumber, prepaid.MobileNumber);
            DeleteResult deleteResult = await _context.Prepaid.DeleteOneAsync(filter);
            bool result = deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
            return result;
        }
    }
}
