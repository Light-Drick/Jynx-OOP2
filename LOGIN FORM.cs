using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Food_Waste_Tracker
{

    public partial class logInForm : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        

        public logInForm()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userNameTbx.Text = "";
            passwordTbx.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

            try
            {
                using (OleDbConnection myConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\wing_\Documents\Food Waste Tracking System.accdb;"))
                {
                    myConn.Open();

                    string userid = userNameTbx.Text.Trim();
                    string password = passwordTbx.Text.Trim();

                    string query = "SELECT COUNT(*) FROM Users WHERE UserID = ? AND [Password] = ?";

                    //what is this?
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        // Use parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("?", userid);
                        cmd.Parameters.AddWithValue("?", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // go to dashboard
                            DASHBOARD_FORM dashboardForm = new DASHBOARD_FORM();
                            dashboardForm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            DASHBOARD_FORM dashboardForm = new DASHBOARD_FORM();
            dashboardForm.Show();
            this.Hide();
        }

        private void conTestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\wing_\Documents\Food Waste Tracking System.accdb;");
                ds = new DataSet();
                myConn.Open();
                MessageBox.Show("Connected successfully!");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }
    }
}
