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
    public partial class UserDataEditForm : Form
    {
        Connection SqlCon = new Connection();
        FormUserData showData = new FormUserData();
        MainForm showUser = new MainForm();


        public UserDataEditForm()
        {
            InitializeComponent();

        }

        void ShowCurrentData()
        {
                SqlConnection sqlCon = SqlCon.GetConn();
                string queryString = "SELECT Username, Password, Name, Age, Height, Weight FROM dbo.UserData;";
                SqlCommand command = new SqlCommand(queryString, sqlCon);
                sqlCon.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (LoginForm.uName == reader[0].ToString() && LoginForm.pass == reader[1].ToString())
                        {
                            tbNewName.Text = reader[2].ToString();
                            tbNewAge.Text = reader[3].ToString();
                            tbNewHeight.Text = reader[4].ToString();
                            tbNewWeight.Text = reader[5].ToString();
                        }
                    }
                }
                sqlCon.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbNewName.Text) ||
                string.IsNullOrEmpty(tbNewAge.Text) ||
                string.IsNullOrEmpty(tbNewHeight.Text) ||
                string.IsNullOrEmpty(tbNewWeight.Text) )
            {
                MessageBox.Show("There is cannot be an empty data");
            }
            else
            {
                {
                    SqlConnection sqlCon = SqlCon.GetConn();
                    using SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandText = "UPDATE dbo.userData set Name = '" + tbNewName.Text + "', Age = '" + tbNewAge.Text + "'," +
                        "Height = '" + tbNewHeight.Text + "', Weight = '" + tbNewWeight.Text + "' WHERE UserID = '"+LoginForm.userID+"'";
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been successfully updated!");
                    sqlCon.Close();
                }

                this.Close();
                //showData.ShowData();
                //showUser.ShowUsername();
            }
                
                        
        }

        private void UserDataEditForm_Load(object sender, EventArgs e)
        {
            ShowCurrentData();
        }

        private void UserDataEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            showData.ShowData();
            showUser.ShowUsername();
        }

        private void UserDataEditForm_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
