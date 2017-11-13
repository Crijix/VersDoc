using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpetingShopV2._0
{
    public partial class myCarptingShop : Form
    {
        public myCarptingShop() {
            InitializeComponent();
        }

        private void BtnArea_Click(object sender, EventArgs e) {

            int area;
            int length;
            int width;

            length = Convert.ToInt32(txtLength.Text);
            width = Convert.ToInt32(txtWidth.Text);

            area = length * width;

            lblAreaCost.Text = area.ToString("n");
        }

        private void BtnRoomCost_Click(object sender, EventArgs e) {

            int length;
            int width;

            double price;
            double roomCost;

            width = Convert.ToInt32(txtWidth.Text);
            length = Convert.ToInt32(txtLength.Text);
            price = Convert.ToDouble(txtPSF.Text);

            roomCost = price * width * length;
            lblRoom.Text = roomCost.ToString("c");
        }

        private void BtnClear_Click(object sender, EventArgs e) {

            lblAreaCost.Text = "";
            lblRoom.Text = "";
        }
    }
}
