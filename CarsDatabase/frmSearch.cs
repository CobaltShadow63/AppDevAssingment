using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace CarsDatabase
{

    public partial class frmSearch : Form
    {
        public frmCars cars { get; set; }

        public frmSearch()
        {
            InitializeComponent();
        }

        public frmSearch(frmCars cars)
        {
            InitializeComponent();
            Initialise();
            this.cars = cars;
        }

        private void Initialise()
        {
            Text = $"Task A Search Antonio {DateTime.Today:d}";
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void btnRun_Click(object sender, EventArgs e)
        {
            string field, sOperator, value;

            field = cboField.Text;
            sOperator = cboOperator.Text;
            value = txtValue.Text;

            if (field == "Available" && value == "Yes")
            {
                value = true.ToString();
            }
            else if (field == "Available" && value == "No")
            {
                value = false.ToString();
            }

            SqlConnection sqlCon = new SqlConnection(myconnstring);
            DataTable dataTable = new DataTable();

            try
            {
                string sqlQuery = "SELECT * FROM tblCar WHERE " + field + sOperator + "@Value";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlCon);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                sqlCon.Open();
                cmd.Parameters.AddWithValue("@Value", value);

                adapter.Fill(dataTable);

                if (field == "VehicleRegNo" && sOperator != "=" || field == "Make" && sOperator != "=" || field == "Available" && sOperator != "=")
                {
                    MessageBox.Show($"You can't use the {field} field with the {sOperator} operator", "Invalid Input", MessageBoxButtons.OK);
                    dataTable.Clear();
                }

                dgvCars.DataSource = dataTable;


            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);

            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCars carsFormHome = new frmCars();
            carsFormHome.Show();
            Hide();
        }


    }

}    

