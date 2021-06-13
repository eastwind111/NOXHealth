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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static string connectionString = @"Data Source=LAPTOP-OGFRNISR;Initial Catalog=UserData;Integrated Security=True";

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
                MessageBox.Show("Username or Password field is empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbName.Text == "" || tbAge.Text == "" || tbHeight.Text == "" || tbWeight.Text == "")
                MessageBox.Show("Please complete your data", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("The Password does not match, please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                tbPassword.Focus();
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {

                    //sqlCon.Open();
                    //SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);

                    /*string queryString = "INSERT INTO dbo.userData('Username','Password') VALUES("+tbUsername.Text+","+tbPassword.Text +")";
                    MessageBox.Show(tbName.Text.Trim(), queryString, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCommand command = new SqlCommand(queryString, sqlCon);*/

                    using SqlCommand command = new SqlCommand();
                    command.Connection = sqlCon;
                    command.CommandText = "INSERT INTO dbo.userData(Username, Password, Name, Age, Height, Weight) " +
                    "VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";
                    command.Parameters.AddWithValue("@param1", tbUsername.Text);
                    command.Parameters.AddWithValue("@param2", tbPassword.Text);
                    command.Parameters.AddWithValue("@param3", tbName.Text);
                    command.Parameters.AddWithValue("@param4", tbAge.Text);
                    command.Parameters.AddWithValue("@param5", tbHeight.Text);
                    command.Parameters.AddWithValue("@param6", tbWeight.Text);
                    sqlCon.Open();
                    command.ExecuteNonQuery();


                    /*sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Clear();
                    sqlCmd.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", tbPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                    sqlCmd.Parameters.AddWithValue("@Age", tbAge.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Height", tbHeight.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Weight", tbWeight.Text.Trim());
                    sqlCmd.ExecuteNonQuery();*/
                    sqlCon.Close();
                    Clear();

                    //RUN coba
                    //coba username sama name aja

                    MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
           
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '●';
                tbConfirmPassword.PasswordChar = '●';
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            tbUsername.Focus();
        }
        void Clear()
        {
            tbUsername.Text = tbPassword.Text = tbConfirmPassword.Text = tbName.Text = tbAge.Text = tbHeight.Text = tbWeight.Text = "";
        }

        private void lblBacktoLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
