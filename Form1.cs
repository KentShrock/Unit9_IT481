using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace unit_2
{
    //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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblMessages.Text = "Loading form";
            //all of this wiil happenw when the form is initially loaded
            System.Diagnostics.Debug.WriteLine("Form1_() now called");

            try
            {
                //set teh path to the connection to the database
                SqlConnection connection = new SqlConnection(
                @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");

                connection.Open();
                //if we reach this point, then it opened succesfully, 
                lblMessages.Text = "Connection was successful. Logged in as "+Login.username;
                //always good practice to close anything that conencts our of the program itself
                connection.Close();
            }//end of try
            catch (Exception ex)
            {
                //if this is activated, then we did not connect to the databse
                lblMessages.Text = "Error: " + ex;
            }//end of catch

        }//end of form load
        private void btnNumNames_Click_1(object sender, EventArgs e)
        {
            //connect to the database
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(
                @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
            connection.Open();
            lblMessages.Text = "Retrieving info";
            //give the command the connection link
            command.Connection = connection;
            //give the actaul sql statement
            command.CommandText = "SELECT count(*) FROM Customers";
            //retrieve the number
            int numNames = (int)command.ExecuteScalar();
            //finally, tell the user
            lblMessages.Text = "The number of customers: " + numNames;
            connection.Close();
        }

        private void btnGetNames_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(
                @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
            connection.Open();
            //lblMessages.Text = "Retrieving info";
            //give the command the connection link
            command.Connection = connection;
            //give the actaul sql statement
            command.CommandText = "SELECT  ContactName FROM Customers;";
            //since we are receving more complex data, use a data adapter andn table
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //fill out the grid for the users
            dataGridView1.DataSource = dt;
            connection.Close();
            lblMessages.Text = "Names have been loaded.";
        }//end of get names click

        private void btnView_Click(object sender, EventArgs e)
        {
            string selectTable = "";
            //check which table is selected
            if (radCust.Checked)
            {
                selectTable = "Customers";
            }
            else if (radEmp.Checked)
            {
                selectTable = "Employees";
            }
            else if (radOrders.Checked)
            {
                selectTable = "Orders";
            }
            dataGridView1.DataSource = null;
            //now we will try to fill out that data source based on a selected table
            try {
                string user = Login.username;
                string pass = Login.pass;
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(
               @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID="
                + user + ";Password=" + pass);
                connection.Open();
                //if we reached here, then things are working smoothly
                lblMessages.Text = "Retrieving Records...";
                command.Connection = connection;
                command.CommandText = "select * from " + selectTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //fill out the view
                dataGridView1.DataSource = dt;
                lblMessages.Text = "Retrieval Successful! Showing table "+selectTable;
                //close connection when done
                connection.Close();

            }
            catch (Exception ex)
            {
                lblMessages.Text = "You lack permission for the "+selectTable+" table.";
            }



        }
    }//end of class form
}
