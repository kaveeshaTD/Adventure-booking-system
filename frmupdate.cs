using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace adventuresport
{
    public partial class frmupdate : Form
    {
        public frmupdate()
        {
            InitializeComponent();
        }
        private bool check()
           
        {
            bool ch;
             if (txtid.Text==""||txtage.Text == "" || txtemail.Text == "" || txtmobile.Text == "" || txtname.Text == "" || txtnuofmember.Text == "" || cmbptype.SelectedIndex == -1 || cmbride.SelectedIndex == -1)
            {
                ch = false;
            }
            else
            {
                ch = true;
            }
            return ch;
        }
        private void btnnewupdate_Click(object sender, EventArgs e)
        {
         if(check()==true)
            {
                try
                {

                    DBconnection dbcon = new DBconnection();
                    SqlConnection con = dbcon.Getdbconnection();

                    string sql = " update bookingdetails set package_type = '" + cmbptype.Text + "',Ride = '" + cmbride.Text + "',Name='"+txtname.Text+ "',Age='"+txtage.Text+ "',Email='"+txtemail.Text+ "',Mobile='"+txtmobile.Text+ "',NO_of_members='"+txtnuofmember.Text+ "',date='"+ datetimepick.Value.ToString() + "' where Id = '" + txtid.Text + "'";

                    //creating sql commandlcass object
                    SqlCommand command = new SqlCommand(sql, con);

                    //executing command
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record update sucsesfull");

                    //close obeject
                    con.Close();

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                   

            }
         else
            {
                MessageBox.Show("Required data is missing.. ");
            }
        }

        private void btnnexit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private bool dvalidate()
        {
            bool d;

            if(txtid.Text=="")
            {
                d = false;
            }
            else
            {
                d = true;
            }
            return d;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dvalidate() == true)
            {
                try
                {
                    DBconnection dbcon = new DBconnection();
                    SqlConnection con = dbcon.Getdbconnection();

                    string sql = "delete from bookingdetails where id ='" + txtid.Text + "'";

                    //creating sql commandlcass object
                    SqlCommand command = new SqlCommand(sql, con);

                    //executing command
                    command.ExecuteNonQuery();
                    MessageBox.Show("Record delete sucsesfull");

                    //close obeject
                    con.Close();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("First you need to enter your id number..");
            }
        }
    }
}
