using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
            Text = $"Task A Antonio {DateTime.Today:d}";
        }
        static int recordsCount;
        static int rowNum = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmCars_Load(object sender, EventArgs e)
        {
            LoadData();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnAdd, "Add a new car");
            toolTip1.SetToolTip(this.btnDelete, "Delete the selected car");
            toolTip1.SetToolTip(this.btnUpdate, "Update the selected car");
            toolTip1.SetToolTip(this.btnSearch, "Search for a car");

        }
        #region Form Buttons
        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DatabaseCars database = ReadyDatabase();
            bool success = database.AddData();
            if (success)
            {
                MessageBox.Show("Successfully added record to database.", "Success");
            }
            else
            {
                MessageBox.Show("Failed to add record to database.", "Error");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDateRegister.Text = "";
            txtEngine.Text = "";
            txtMake.Text = "";
            txtRecordNumber.Text = "";
            txtRentalPerDay.Text = "";
            txtVehicleRegistration.Text = "";
            chkAvailable.Checked = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var frmSearch = new frmSearch();

            frmSearch.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DatabaseCars database = ReadyDatabase();
            bool success = database.DeleteRecord();
            if (success)
            {
                MessageBox.Show("Successfully deleted record.", "Success");
            }
            else
            {
                MessageBox.Show("Failed to delete record.", "Error");
            }

            btnRecordFirst_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtDateRegister.Text != "")
            {
                DatabaseCars database = ReadyDatabase();
                bool success = database.UpdateDatabase();
                if (success)
                {
                    MessageBox.Show("Successfully updated the database.", "Success");
                }
                else
                {
                    MessageBox.Show("Failed to update the database.", "Error");
                }
            }
            else
            {
                MessageBox.Show("None of the fields may be left blank");
            }
        }
        #endregion
        
        #region Record Buttons
        private void btnRecordNext_Click(object sender, EventArgs e)
        {
            DatabaseCars database = ReadyDatabase();
            bool success = database.LoadData(out DataTable dataTable);
            if (!success)
            {
                MessageBox.Show("Failed to load data");
            }
            else
            {
                recordsCount = dataTable.Rows.Count;

                if (rowNum < recordsCount - 1)
                {
                    rowNum++;
                    txtVehicleRegistration.Text = dataTable.Rows[rowNum].Field<string>(0);
                    txtMake.Text = dataTable.Rows[rowNum].Field<string>(1);
                    txtEngine.Text = dataTable.Rows[rowNum].Field<string>(2);
                    txtDateRegister.Text = Convert.ToString(dataTable.Rows[rowNum].Field<DateTime>(3).ToString("dd/MM/yyyy"));
                    txtRentalPerDay.Text = Convert.ToString(dataTable.Rows[rowNum].Field<decimal>(4).ToString("C"));
                    chkAvailable.Checked = dataTable.Rows[rowNum].Field<bool>(5);
                }
                else
                {
                    btnRecordFirst_Click(sender, e);
                }

                UpdateRecordDisplay();
            }
        }

        private void btnRecordLast_Click(object sender, EventArgs e)
        {
            DatabaseCars database = ReadyDatabase();
            bool success = database.LoadData(out DataTable dataTable);
            if (!success)
            {
                MessageBox.Show("Failed to load data");
            }
            else
            {
                recordsCount = dataTable.Rows.Count;

                txtVehicleRegistration.Text = dataTable.Rows[0].Field<string>(0);
                txtMake.Text = dataTable.Rows[0].Field<string>(1);
                txtEngine.Text = dataTable.Rows[0].Field<string>(2);
                txtDateRegister.Text = Convert.ToString(dataTable.Rows[0].Field<DateTime>(3).ToString("dd/MM/yyyy"));
                txtRentalPerDay.Text = Convert.ToString(dataTable.Rows[0].Field<decimal>(4).ToString("C"));
                chkAvailable.Checked = dataTable.Rows[0].Field<bool>(5);

                rowNum = recordsCount - 1;
                UpdateRecordDisplay();
            }
        }

        private void btnRecordPrevious_Click(object sender, EventArgs e)
        {

            DatabaseCars database = ReadyDatabase();
            bool success = database.LoadData(out DataTable dataTable);
            if (!success)
            {
                MessageBox.Show("Failed to load data");
            }
            else
            {
                recordsCount = dataTable.Rows.Count;

                if (rowNum > 0)
                {
                    rowNum--;
                    txtVehicleRegistration.Text = dataTable.Rows[rowNum].Field<string>(0);
                    txtMake.Text = dataTable.Rows[rowNum].Field<string>(1);
                    txtEngine.Text = dataTable.Rows[rowNum].Field<string>(2);
                    txtDateRegister.Text = Convert.ToString(dataTable.Rows[rowNum].Field<DateTime>(3).ToString("dd/MM/yyyy"));
                    txtRentalPerDay.Text = Convert.ToString(dataTable.Rows[rowNum].Field<decimal>(4).ToString("C"));
                    chkAvailable.Checked = dataTable.Rows[rowNum].Field<bool>(5);
                }
                else
                {
                    btnRecordLast_Click(sender, e);
                }

                UpdateRecordDisplay();
            }
        }

        private void btnRecordFirst_Click(object sender, EventArgs e)
        {
            DatabaseCars database = ReadyDatabase();
            bool success = database.LoadData(out DataTable dataTable);
            if (!success)
            {
                MessageBox.Show("Failed to load data");
            }
            else
            {
                recordsCount = dataTable.Rows.Count;

                txtVehicleRegistration.Text = dataTable.Rows[0].Field<string>(0);
                txtMake.Text = dataTable.Rows[0].Field<string>(1);
                txtEngine.Text = dataTable.Rows[0].Field<string>(2);
                txtDateRegister.Text = Convert.ToString(dataTable.Rows[0].Field<DateTime>(3).ToString("dd/MM/yyyy"));
                txtRentalPerDay.Text = Convert.ToString(dataTable.Rows[0].Field<decimal>(4).ToString("C"));
                chkAvailable.Checked = dataTable.Rows[0].Field<bool>(5);

                rowNum = 0;
                UpdateRecordDisplay();
            }
        }
        #endregion
        
        #region Methods
        public void LoadData()
        {
            DatabaseCars database = ReadyDatabase();

            bool success = database.LoadData(out DataTable dataTable);
            if (!success)
            {
                MessageBox.Show("Failed to load data");
            }
            else if (dataTable.Rows.Count > 0)
            {
                recordsCount = dataTable.Rows.Count;
                txtVehicleRegistration.Text = dataTable.Rows[0].Field<string>(0);
                txtMake.Text = dataTable.Rows[0].Field<string>(1);
                txtEngine.Text = dataTable.Rows[0].Field<string>(2);
                txtDateRegister.Text = Convert.ToString(dataTable.Rows[0].Field<DateTime>(3).ToString("dd/MM/yyyy"));
                txtRentalPerDay.Text = Convert.ToString(dataTable.Rows[0].Field<decimal>(4).ToString("C"));
                chkAvailable.Checked = dataTable.Rows[0].Field<bool>(5);
                UpdateRecordDisplay();
            }
        }

        public DatabaseCars ReadyDatabase()
        {
            string dateRegistered = "";

            Console.WriteLine($"{txtRentalPerDay.Text}, {txtDateRegister.Text}");

            if (txtDateRegister.Text != "")
            {
                dateRegistered = DateTime.ParseExact(txtDateRegister.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
            }

            decimal rentalPerDay = 0;
            if (txtRentalPerDay.Text != "")
            {
                string fixedRPD = txtRentalPerDay.Text.Remove(0, 1);
                rentalPerDay = Convert.ToDecimal(fixedRPD);
            }

            return new DatabaseCars(txtVehicleRegistration.Text, txtMake.Text, txtEngine.Text, dateRegistered, rentalPerDay, chkAvailable.Checked);
        }
        public void UpdateRecordDisplay()
        {
            DatabaseCars database = ReadyDatabase();
            bool success = database.LoadData(out DataTable dataTable);
            if (!success)
            {
                MessageBox.Show("Failed to load data");
            }
            else
            {
                recordsCount = dataTable.Rows.Count;
                txtRecordNumber.Text = $"{rowNum + 1} of {recordsCount}";
            }
        }

        #endregion

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAdd, "Add a new record");
            toolTip.ShowAlways = true;
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnSearch, "Search for a record");
            toolTip.ShowAlways = true;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnUpdate, "Update existing record");
            toolTip.ShowAlways = true;
        }
    }


}

