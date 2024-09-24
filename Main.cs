using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CRUD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            LoadData();

        }
        private SqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Database=users;Integrated Security=True;";
            return new SqlConnection(connectionString);

        }

        private void LoadData() //Used on Launch + When Refresh button is pressed.
        {
            using SqlConnection connection = GetConnection();
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private List<(string fname, string sname, string job_title)> newRecords = new List<(string, string, string)>();
        private int tempIdCounter = -1; // Temp ID for newly added rows, decrements to avoid duplicate temp IDs
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Open the Add form to get new record data
            Add AddForm = new Add();
            if (AddForm.ShowDialog() == DialogResult.OK)
            {
                int tempId = tempIdCounter--;

                // Get the DataTable from the DataGridView
                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                // Add the new record to the DataTable
                DataRow newRow = dataTable.NewRow();
                newRow["id"] = tempId;
                newRow["fname"] = AddForm.fname;
                newRow["sname"] = AddForm.sname;
                newRow["job_title"] = AddForm.job_title;

                // Add the row to the DataTable (not the database yet)
                dataTable.Rows.Add(newRow);

                // Track this new record to insert into the database later
                newRecords.Add((AddForm.fname, AddForm.sname, AddForm.job_title));
            }
        }
        private Add AddForm;

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            //User has selected a row to edit
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve values from selected row
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string fname = selectedRow.Cells["fname"].Value.ToString();
                string sname = selectedRow.Cells["sname"].Value.ToString();
                string jobTitle = selectedRow.Cells["job_title"].Value.ToString();
                // Open the edit form and pass the data

                try
                {
                    Edit editForm = new Edit(id, fname, sname, jobTitle);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Reload data after updating
                        LoadData();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // If not row selected    
            }
            else
            {
                MessageBox.Show("Please select a row in order to access the edit window.");
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Check if the ID is null or a temporary ID
                object idValue = selectedRow.Cells["id"].Value;
                int id = idValue != DBNull.Value ? Convert.ToInt32(idValue) : -1; // Use -1 for new rows

                // Retrieve values from the selected row
                string fname = selectedRow.Cells["fname"].Value.ToString();
                string sname = selectedRow.Cells["sname"].Value.ToString();
                string jobTitle = selectedRow.Cells["job_title"].Value.ToString();

                // Display info

                txt_Id.Text = id != -1 ? id.ToString() : "New"; // Display "New" for unsaved rows
                txt_fname.Text = fname;
                txt_Sname.Text = sname;
                txt_JobTitle.Text = jobTitle;
            }
            else
            {
                // Clear the labels or handle the case when no row is selected
                txt_Id.Text = "";
                txt_fname.Text = "";
                txt_Sname.Text = "";
                txt_JobTitle.Text = "";
            }
        }

        private List<int> deletedRecords = new List<int>();
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve ID from selected row
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // Confirm with user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                              "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Add the ID to the list of records marked for deletion
                    deletedRecords.Add(id);

                    // Remove the row from DataGridView (not from the database yet)
                    dataGridView1.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    // Handle new records (inserts)
                    foreach (var newRecord in newRecords)
                    {
                        string query = "INSERT INTO Users (fname, sname, job_title) VALUES (@fname, @sname, @job_title)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@fname", newRecord.fname);
                            command.Parameters.AddWithValue("@sname", newRecord.sname);
                            command.Parameters.AddWithValue("@job_title", newRecord.job_title);
                            command.ExecuteNonQuery();
                        }
                    }


                    // Handle Deletion
                    foreach (int id in deletedRecords)
                    {
                        string query = "DELETE FROM Users WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                newRecords.Clear();
                deletedRecords.Clear();

                // Refresh the DataGridView after saving
                LoadData();

                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Confirm with user
            DialogResult result = MessageBox.Show("Are you sure you want to cancel all changes? All unsaved changes will be lost.",
                                                  "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear lists
                newRecords.Clear();
                deletedRecords.Clear();

                LoadData();

                MessageBox.Show("All changes have been discarded.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}



