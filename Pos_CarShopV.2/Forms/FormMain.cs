using FontAwesome.Sharp;
using MongoDB.Driver;
using Pos_CarShopV._2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_CarShopV._2
{
    public partial class FormMain : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //MongoDB
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public readonly IMongoCollection<cartModel> _GetCartservice;
        public readonly IMongoCollection<logModel> _GetLogtservice;

        public FormMain()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
            _GetCartservice = database.GetCollection<cartModel>("cart");
            _GetLogtservice = database.GetCollection<logModel>("log");

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Method
        private void ActivateButton(object senderBtn,Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LbTltieChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.MediumPurple;
            LbTltieChildForm.Text = "หน้าหลัก";
        }


        private void IconCurrentChildForm_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();

        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);
            OpenChildForm(new Home());
        }

        private void TradeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Trade());
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new AddProduct());
        }

        private void CheckStockButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new CheckStock());
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new EditProduct());
        }

        private void SaleSumButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new SalesSum());
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Banner_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Closeicon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WindowMaximizeIcon_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void WindowMinimizeIcon_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
