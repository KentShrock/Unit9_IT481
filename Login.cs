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
using System.Linq;

namespace unit_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string username="";
        public static string pass="";


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //so, if they didn't fill out either the user name or password, don't do anything
            if (txtPass.Text == "" || txtUser.Text == "")
            {
                lblLoginError.Text = "Please fill in both username and password to login.";
                lblLoginError.Visible = true;
            }//end of if bad
            else
            {
                //if we get here, we can attempt to login
                lblLoginError.Visible = false;
                //save the text in the textboxes to save time typing
                 username = txtUser.Text;
                 pass = txtPass.Text;
                //create a connection to the database
                //  lblCon.Text = username;
                lblCon.Text = "Connecting.... ";

                SqlConnection connection = new SqlConnection(
               @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID="
                +username+"; Password="+pass);
                //Persist Security Info=True
                


                //ok, now that we have a connection string, lets try to login
                try
                {
                    
                    connection.Open();
                  //  lblCon.Visible = true;
                    lblCon.Text = "Connection succesful";
                    //if we are here, then we have logged in

                    //this loads the now updated form from unit 2
                    Form1 frm1 = new Form1();
                    frm1.Show();
                }
                catch(Exception ex)//if this activates, then something doesn't work
                {
                    lblCon.Text = "That isn't an account we have ";
                    lblLoginError.Visible = true;
                    lblLoginError.Text = "Error: " + ex;
                    //txterr.Text = ex.ToString();
                }

            }//end of else
        }//end of login button

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }//end of partial class
}//end of namespace
