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
    public partial class FormUserData : Form
    {
        Connection SqlCon = new Connection();
        MainForm refresh = new MainForm();

        public FormUserData()
        {
            InitializeComponent();
            this.Text = "User Data";

        }

        public void ShowData()
        {
            SqlConnection sqlCon = SqlCon.GetConn();
            string queryString = "SELECT Username, Password, Name, Age, Height, Weight FROM dbo.UserData;";
            SqlCommand command = new SqlCommand(queryString, sqlCon);
            sqlCon.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (LoginForm.uName == (reader[0]).ToString() && LoginForm.pass == reader[1].ToString())
                    {
                        lblName2.Text = String.Format("{0}", reader[2]);
                        lblAge2.Text = String.Format("{0} years old", reader[3]);
                        lblHeight2.Text = String.Format("{0} Meters", reader[4]);
                        lblWeight2.Text = String.Format("{0} Kilograms", reader[5]);
                    }
                }
            }

            //cmd = new SqlCommand(queryString, sqlCon);
            //ds = new DataSet();
            //da = new SqlDataAdapter(cmd);
            //da.Fill(ds, "UserData");

            sqlCon.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserDataEditForm edit = new UserDataEditForm();
            edit.Show();
        }

        private void FormUserData_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void FormUserData_MouseMove(object sender, MouseEventArgs e)
        {
            ShowData();
            refresh.ShowUsername();
        }
    }
}
