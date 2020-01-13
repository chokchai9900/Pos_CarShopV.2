using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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
    public partial class AddProduct : Form
    {
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public readonly IMongoCollection<cartModel> _GetCartservice;
        public readonly IMongoCollection<logModel> _GetLogtservice;
        public AddProduct()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
            _GetCartservice = database.GetCollection<cartModel>("cart");
            _GetLogtservice = database.GetCollection<logModel>("log");
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var def = new BsonDocument()
                .Add("productType", typeProductBox1.Text)
                .Add("productName", nameProductBox.Text.ToString())
                .Add("brand", brandBox.Text.ToString())
                .Add("countProduct", Convert.ToInt32(productCountBox.Value))
                .Add("price", Convert.ToDouble(priceProductBox.Value))
                .Add("discription", discriptionBox.Text.ToString());
            var data = BsonSerializer.Deserialize<ProductModel>(def);

            if (string.IsNullOrEmpty(data.productName) || string.IsNullOrEmpty(data.productType) || string.IsNullOrEmpty(data.brand))
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ กรุณากรอกใหม่ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _GetDatabaseservice.InsertOne(data);
                var validate = _GetDatabaseservice.Find(it => it.productName == data.productName);
                if (validate != null)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    typeProductBox1.Text = null;
                    nameProductBox.Text = null;
                    brandBox.Text = null;
                    productCountBox.Value = 0;
                    priceProductBox.Value = 0;
                    discriptionBox.Text = null;
                }
                else
                {
                    MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ", "ไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
