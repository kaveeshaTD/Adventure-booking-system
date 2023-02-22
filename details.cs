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
    public partial class frmdetails : Form
    {
        public frmdetails()
        {
            InitializeComponent();
        }

        private void txtmobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbexit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        private bool valid()
        {
            bool rt;

            if (txtage.Text == "" || txtemail.Text == "" || txtmobile.Text == "" || txtname.Text == "" || txtnuofmember.Text == "" || cmbptype.SelectedIndex==-1 || cmbride.SelectedIndex==-1)
            {
                rt = false;
            }
            else
            {
                rt = true;
            }
            return rt;
        }
        private void btndsave_Click(object sender, EventArgs e)
        {
            if (valid() == true)//textbox validation
            {
                try
                {
                    int ptype = cmbptype.SelectedIndex;
                    int ride = cmbride.SelectedIndex;
                    int membeer = Convert.ToInt32(txtnuofmember.Text);
                    int bill = 0;
                    
                    if(membeer<12)//check max member count

                    {
                       

                        if (ride == 0 && ptype == 0)// offroad package 01
                        {
                            if(membeer<=4)//member count4
                            {
                                bill = 8000;
                            }
                            else if(4<membeer & membeer<=8)//members between 4 and 8
                            {
                                bill = 8000 + 3000;
                            }
                            else if(8<membeer & membeer<=12)//member between 8 and 12
                            {
                                bill = 8000 + 6000;
                            }

                        }
                        else if(ride == 0 && ptype ==1 )//off road package type 2
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 10000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 10000 + 3000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill = 10000 + 6000;
                            }
                        }
                        else if(ride == 0 && ptype == 2) //off road package type 3
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 15000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 15000 + 3000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill = 15000 + 6000;
                            }
                        }
                        else if(ride == 1 && ptype == 0) //helicopter package 1
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 10000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 10000 + 10000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill = 10000 + 20000;
                            }
                        }
                        else if(ride == 1 && ptype == 1) //helicopter package 2
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 15000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 15000 + 10000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill = 15000 + 20000;
                            }
                        } 
                        else if(ride == 1 && ptype == 2) //helicopter package 3
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 20000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 20000 + 10000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill = 20000 + 20000;
                            }
                        }
                       
                        else if (ride == 2 && ptype == 0)//rafting package1
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 5000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 5000 + 4000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill=5000+8000;
                            }
                        }
                        else if (ride == 2 && ptype == 1)//rafting package2
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 10000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 10000 + 4000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill = 10000 + 8000;
                            }
                        }
                        else if (ride == 2 && ptype == 2)//rafting package3
                        {
                            if (membeer <= 4)//member count4
                            {
                                bill = 15000;
                            }
                            else if (4 < membeer & membeer <= 8)//members between 4 and 8
                            {
                                bill = 15000 + 4000;
                            }
                            else if (8 < membeer & membeer <= 12)//member between 8 and 12
                            {
                                bill = 15000 + 8000;
                            }
                        }
                        MessageBox.Show("your payment value is = " + bill.ToString());

                        
                                   
                                  

                        //databse connection and statements
                        DBconnection dbcon = new DBconnection();
                        SqlConnection con = dbcon.Getdbconnection();

                        //sql ststement
                        string sql = "insert into bookingdetails values('" + cmbptype.Text + "','" + cmbride.Text + "','" + txtname.Text + "','" + txtage.Text + "','" + txtemail.Text + "','" + txtmobile.Text + "','" + txtnuofmember.Text + "','" + datetimepick.Value.ToString() + "')";

                        SqlCommand command = new SqlCommand(sql, con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("data insert sucsesfull");
                        con.Close();


                    }
                    else
                    {
                        MessageBox.Show("You  exceeding maximum member count");
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("required dat is missing");
            }
        }

        private void btndclear_Click(object sender, EventArgs e)
        {
            cmbptype.SelectedIndex = -1;
            cmbride.SelectedIndex = -1;
            txtname.Text = "";
            txtage.Text = "";
            txtemail.Text = "";
            txtmobile.Text = "";
            txtnuofmember.Text = "";
            
        }

        private void btndback_Click(object sender, EventArgs e)
        {
            frmupdate fupdate = new frmupdate();
            fupdate.ShowDialog();
            
            
            
        }
    }
}
