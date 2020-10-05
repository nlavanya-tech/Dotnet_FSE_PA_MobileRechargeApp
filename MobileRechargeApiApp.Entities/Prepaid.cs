using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileRechargeApiApp.Entities
{
   public class Prepaid
    {
        public String MobileNumber { get; set; }
        public String Operator { get; set; }
        public String Amount { get; set; }
    }
}
