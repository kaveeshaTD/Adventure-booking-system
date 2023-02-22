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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool validation()
        {
            bool retn;
            if(txtluname.Text=="" || txtlpswd.Text=="")
            {
                retn = false;
            }
            else
            {
                retn = true;
            }
            return retn;
        }
        private void btnllog_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                try
                {
                    //craeting connection
                    string connection = @"data source =DESKTOP-CNC0FHC ;initial Catalog =adventure  ;integrated security = true";



                    //creating object & open the conection
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();



                    string sql = "select count (*) from regstation where username ='" + txtluname.Text + "' and parsword='" + txtlpswd.Text + "'";

                    //creating sql commandlcass object
                    SqlCommand command = new SqlCommand(sql, con);

                    //sqldata adapter
                    SqlDataAdapter adpter = new SqlDataAdapter(command);//*******
                    DataTable datatable = new DataTable();
                    adpter.Fill(datatable);
                    if (datatable.Rows[0][0].ToString() == "1")
                    {
                        this.Close();
                        frmmain f4 = new frmmain();
                        f4.Show();
                    }
                    else
                    {
                        MessageBox.Show("login faild");
                    }
                    //close obeject
                    con.Close();

                  
                }

                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("required data is missing check again");
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            txtlpswd.PasswordChar = '*';
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

    

       
    }
}
