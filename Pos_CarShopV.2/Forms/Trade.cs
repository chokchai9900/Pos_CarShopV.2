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
    public partial class Trade : Form
    {
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public readonly IMongoCollection<cartModel> _GetCartservice;
        public readonly IMongoCollection<logModel> _GetLogtservice;
        private FormMain _resetCart;
        public Trade(FormMain ResetCart)
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
            _GetCartservice = database.GetCollection<cartModel>("cart");
            _GetLogtservice = database.GetCollection<logModel>("log");
            _resetCart = ResetCart;
        }
        public void GetDataToGritView()
        {
            var ItemSelect = SelectTypeBox.SelectedItem.ToString();
            var GetDataByType = _GetDatabaseservice.Find(it => it.productType.Contains(ItemSelect)).ToList();
            if (GetDataByType.Count <= 0)
            {
                MessageBox.Show($"ไม่มีสินค้าประเภท {ItemSelect} ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (GetDataByType == null)
            {
                MessageBox.Show($"ไม่มีสินค้าประเภท {ItemSelect} ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataViewGrid.DataSource = GetDataByType;
            }
        }

        private void SelectTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataToGritView();

        }

        private void SelectProductBtn_Click(object sender, EventArgs e)
        {
            var data = DataViewGrid.CurrentRow.Cells["_productName"].Value.ToString();
            var getdata = _GetDatabaseservice.Find(it => it.productName == data).FirstOrDefault();

            var def = Builders<ProductModel>.Update
                .Set(it => it.Id, getdata.Id)
                .Set(it => it.productType, getdata.productType)
                .Set(it => it.productName, getdata.productName)
                .Set(it => it.brand, getdata.brand)
                .Set(it => it.countProduct, (getdata.countProduct - 1))
                .Set(it => it.price, getdata.price)
                .Set(it => it.discription, getdata.discription);
            _GetDatabaseservice.UpdateOne(it => it.Id == getdata.Id, def);

            cartModel defCart = new cartModel
            {
                productType = getdata.productType,
                productName = getdata.productName,
                brand = getdata.brand,
                price = getdata.price,
                discription = getdata.discription
            };
            _GetCartservice.InsertOne(defCart);
            _resetCart.ResetCart();

            var cartData = _GetCartservice.Find(it => true).ToList();

            GetDataToGritView();

            double allPrice = 0;

            foreach (var summary in cartData)
            {
                allPrice = allPrice + summary.price;
            }
        }
    }
}
