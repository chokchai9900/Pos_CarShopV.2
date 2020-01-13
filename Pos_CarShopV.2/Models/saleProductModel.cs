using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_CarShopV._2.Models
{
    public class saleProductModel
    {
        public string Name { get; set; }
        public int count { get; set; }
    }
}
