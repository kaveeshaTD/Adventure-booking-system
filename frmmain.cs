using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventuresport
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count<6)
            {
                piclist.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void btnoffroad_Click(object sender, EventArgs e)
        {
            frmoffroad offroad = new frmoffroad();
            offroad.Show();
            
        }

        private void btnhelicopter_Click(object sender, EventArgs e)
        {
            frmhelicopter fheli = new frmhelicopter();
            fheli.Show();
        }

        private void btnflyboard_Click(object sender, EventArgs e)
        {
            frmrafting frafting = new frmrafting();
            frafting.Show();
        }

       

        private void btnsky_Click(object sender, EventArgs e)
        {
            frmcheckdetails f8 = new frmcheckdetails();
            f8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmdtagrd fdgrd = new frmdtagrd();
            fdgrd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fro more details 091-2343567 / 077-2343212 / 011-2567894");
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            frmdetails f5 = new frmdetails();
            f5.ShowDialog();
        }
    }
}
