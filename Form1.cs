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
    public partial class Frmlog : Form
    {
        public Frmlog()
        {
            InitializeComponent();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblregister_Click(object sender, EventArgs e)
        {
            frmregister f2 = new frmregister();
            f2.Show();
            
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin f3 = new frmlogin();
            f3.Show();
            
            
        }
    }
}
