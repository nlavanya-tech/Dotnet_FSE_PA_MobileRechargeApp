using Microsoft.Extensions.Options;
using MobileRechargeApiApp.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileRechargeApiApp.DataLayer.Context
{
   public class MongoDbContext : IMongoDbContext
    {
        //Create context of Mongo DB
        private readonly IMongoDatabase _db;

        //get mongodb connection string values options from app settings
        public MongoDbContext(IOptions<MongoDbSetting> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        //Get All notes Collection from MongoDB
        public IMongoCollection<Postpaid> Postpaid => _db.GetCollection<Postpaid>("Postpaid");
        public IMongoCollection<Prepaid> Prepaid => _db.GetCollection<Prepaid>("Prepaid");
    }
}
