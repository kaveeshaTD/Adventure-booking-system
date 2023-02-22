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
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validate()
        {
            bool rtn;
            if(txtuname.Text=="" ||txtpswd.Text=="" )
            {
                rtn = false;
            }
            else
            {
                rtn = true;
            }
            return rtn;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(validate()==true)//add validation
            {
                try
                {
                    //connect obj = new connect();
                    // obj.con.ConnectionString = obj.con;
                    string connection = @"data source =DESKTOP-CNC0FHC ;initial Catalog = adventure ;integrated security = true";

                    //creating object & open the conection
                    SqlConnection con = new SqlConnection(connection);
                    con.Open();
      
                    //insert values
                    string sql = "insert into regstation (username,parsword) values('" + txtuname.Text+"','"+txtpswd.Text+"' )";

                    //creating sql commandlcass object
                    SqlCommand command = new SqlCommand(sql, con);

                    //executing command
                    command.ExecuteNonQuery();
       
                    //close obeject
                    con.Close();
                    this.Close();
                    
                    MessageBox.Show("registation compleat");
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("some data is missingplease check again");
            }
        }

        private void frmregister_Load(object sender, EventArgs e)
        {
            txtpswd.PasswordChar = '*';
        }

        private void txtpswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuname.Text = "";
            txtpswd.Text = "";
            txtuname.Focus();
        }
    }
}
