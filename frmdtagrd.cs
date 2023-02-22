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
    public partial class frmdtagrd : Form
    {
        public frmdtagrd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBconnection dbcon = new DBconnection();
                SqlConnection con = dbcon.Getdbconnection();

                string sql = "select * from bookingdetails";

                //creating sql commandlcass object
                SqlCommand command = new SqlCommand(sql, con);

                //sqldata adapter
                SqlDataAdapter adpter = new SqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adpter.Fill(datatable);

                //close obeject
                con.Close();

                //dat gride control
                dtagrd.DataSource = datatable;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
