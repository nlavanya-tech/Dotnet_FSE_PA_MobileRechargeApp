using MobileRechargeApiApp.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileRechargeApiApp.DataLayer.Context
{
   public interface IMongoDbContext
    {
        // IMongoCollection<TEntity> GetCollection<TEntity>(string name);
        IMongoCollection<Postpaid> Postpaid { get; }
        IMongoCollection<Prepaid> Prepaid { get; }
    }
}
