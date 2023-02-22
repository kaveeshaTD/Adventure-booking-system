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
    public partial class frmcheckdetails : Form
    {
        public frmcheckdetails()
        {
            InitializeComponent();
        }

        private void btnccancel_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }
    }
}
