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
    public partial class FormRecommendation : Form
    {
        private Form currentChildForm;
        BMI result = new BMI();
        public double resultValue;
        Connection SqlCon = new Connection();
        public static int A { get; set; }
        public static double H { get; set; }
        public static double W { get; set; }

        public FormRecommendation()
        {
            InitializeComponent();
            this.Text = "Recommendation";

            SqlConnection sqlCon = SqlCon.GetConn();
            string queryString = "SELECT Age, Height, Weight FROM dbo.UserData WHERE UserID = '" + LoginForm.userID + "'";
            SqlCommand command = new SqlCommand(queryString, sqlCon);
            sqlCon.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    A = Convert.ToInt32(reader[0]);
                    H = Convert.ToDouble(reader[1]);
                    W = Convert.ToDouble(reader[2]);
                }
            }

            resultValue = result.calculateValue(A, H, W);
            //MessageBox.Show(String.Format("Your result value is {0}", resultValue));

            if (resultValue > 6)
            {
                OpenChildForm(new HighCaloriesFood());
            }
            else if (resultValue > 4)
            {
                OpenChildForm(new MedCaloriesFood());
            }
            else
            {
                OpenChildForm(new LowCaloriesFood());
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            
        }
    }
}
