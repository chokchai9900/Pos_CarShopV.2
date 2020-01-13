using MongoDB.Driver;
using Pos_CarShopV._2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_CarShopV._2
{
    public partial class CheckStock : Form
    {
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public readonly IMongoCollection<cartModel> _GetCartservice;
        public readonly IMongoCollection<logModel> _GetLogtservice;
        public CheckStock()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
            _GetCartservice = database.GetCollection<cartModel>("cart");
            _GetLogtservice = database.GetCollection<logModel>("log");
        }
    }
}
