using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUD
{
    public partial class Edit : Form
    {
        private int _id;
        public Edit(int id, string fname, string sname, string job_title)
        {
            InitializeComponent();

            // Initialize form with current values
            _id = id;
            Edit_txt_Fname.Text = fname;
            Edit_txt_Sname.Text = sname;
            Edit_txt_Job_title.Text = job_title;
        }
        private void LoadEditData()
        {

        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // Update DB
            // Capture data from text boxes
            string fname = Edit_txt_Fname.Text;
            string sname = Edit_txt_Sname.Text;
            string job_title = Edit_txt_Job_title.Text;

            // Check if any fields are left blank
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(sname) || string.IsNullOrWhiteSpace(job_title))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method, preventing further execution
            }
            // Update the database

            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=users;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "UPDATE Users SET fname = @fname, sname = @sname, job_title = @job_title WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fname", fname);
                        command.Parameters.AddWithValue("@sname", sname);
                        command.Parameters.AddWithValue("@job_title", job_title);
                        command.Parameters.AddWithValue("@id", _id);

                        int rowsAffected = command.ExecuteNonQuery(); // Execute the update command

                        // If no rows were affected
                        if (rowsAffected > 0)
                        {
                            // Indicate success and close the form
                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            // Handle case where no rows were affected
                            MessageBox.Show("No record found to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
