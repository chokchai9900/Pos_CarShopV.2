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
    public partial class EditProduct : Form
    {
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public readonly IMongoCollection<cartModel> _GetCartservice;
        public readonly IMongoCollection<logModel> _GetLogtservice;
        public EditProduct()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
            _GetCartservice = database.GetCollection<cartModel>("cart");
            _GetLogtservice = database.GetCollection<logModel>("log");
        }

        public void Loaddata()
        {
            SelectItemBox.Items.Clear();
            var productData = _GetDatabaseservice.Find(it => true).ToList();
            var ProductList = new List<string>();
            foreach (var name in productData)
            {
                ProductList.Add(name.Id);
            }
            foreach (var item in ProductList)
            {
                var getProduct = _GetDatabaseservice.Find(it => it.Id == item).FirstOrDefault();
                SelectItemBox.Items.Add(getProduct.productName);
            }
        }
        private void EditProduct_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void SelectItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ItemSelected = SelectItemBox.SelectedItem.ToString();
            var getData = _GetDatabaseservice.Find(it => it.productName.Contains(ItemSelected)).FirstOrDefault();

            EditTypeProductBox.Text = getData.productType;
            EditNameBox.Text = getData.productName;
            EditBrandBox.Text = getData.brand;
            EditcountBox.Value = getData.countProduct;
            EditPriceBox.Value = Convert.ToDecimal(getData.price.ToString());
            EditDiscriptionBox.Text = getData.discription;
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            var ItemSelected = SelectItemBox.SelectedItem.ToString();
            var getData = _GetDatabaseservice.Find(it => it.productName.Contains(ItemSelected)).FirstOrDefault();

            var def = Builders<ProductModel>.Update
                .Set(it => it.Id, getData.Id)
                .Set(it => it.productType, EditTypeProductBox.Text)
                .Set(it => it.productName, EditNameBox.Text)
                .Set(it => it.brand, EditBrandBox.Text)
                .Set(it => it.countProduct, EditcountBox.Value)
                .Set(it => it.price, Convert.ToDouble(EditPriceBox.Value))
                .Set(it => it.discription, EditDiscriptionBox.Text);
            _GetDatabaseservice.UpdateOne(it => it.Id == getData.Id,def);

            if (string.IsNullOrEmpty(EditNameBox.Text) || string.IsNullOrEmpty(EditTypeProductBox.Text) || string.IsNullOrEmpty(EditBrandBox.Text))
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ กรุณากรอกใหม่ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var validate = _GetDatabaseservice.Find(it => it.Id == getData.Id);
                if (validate != null)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditTypeProductBox.Text = null;
                    EditNameBox.Text = null;
                    EditBrandBox.Text = null;
                    EditcountBox.Value = 0;
                    EditPriceBox.Value = 0;
                    EditDiscriptionBox.Text = null;
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ", "ไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
