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

namespace NOXHealth
{
    public partial class LoginForm : Form
    {
        Connection SqlCon = new Connection();
        
        public LoginForm()
        {
            InitializeComponent();
            
        }
        public static string uName { get; set; }
        public static string pass { get; set; }
        public static string userID;

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbUsername.Text) &&
                !string.IsNullOrEmpty(tbPassword.Text))
            {
                try
                {
                    //SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-OGFRNISR;Initial Catalog=UserData;Integrated Security=True");
                    //sqlCon.Open();

                    string queryString = "SELECT * FROM UserData WHERE Username = '"+ tbUsername.Text+ "' AND Password = '" + tbPassword.Text + "'";
                    using (SqlConnection sqlCon = SqlCon.GetConn())
                    {
                        SqlCommand command = new SqlCommand(queryString, sqlCon);
                        sqlCon.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //MessageBox.Show(String.Format("{0}, {1}", reader[1], reader[2]));
                                LoginForm.uName = (reader[1]).ToString();
                                LoginForm.pass = (reader[2]).ToString();
                                LoginForm.userID = reader[0].ToString();
                                this.Hide();
                                MainForm mf = new MainForm();
                                mf.Show();
                            }
                            else
                            {
                                MessageBox.Show("The Username or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                tbUsername.Focus();
                            }
                            
                        }
                    }

                    //string query = "SELECT * FROM UserData WHERE Username = '" + tbUsername.Text.Trim() + "' AND Password ='" + tbPassword.Text.Trim() + "'";

                    //SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    //DataTable UserData = new DataTable();

                    //adapter.Fill(UserData);

                    //if (UserData.Rows.Count > 0)
                    //{
                    //    //MessageBox.Show("Login Successful!");
                    //    this.Hide();
                    //    MainForm mf = new MainForm();
                    //    mf.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("The Username or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    tbUsername.Focus();
                    //}
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Username or Password field is empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            //this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '●';
            }
        }


    }
}
