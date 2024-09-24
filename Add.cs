using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Add : Form
    {
        public string fname { get; private set; }
        public string sname { get; private set; }
        public string job_title { get; private set; }

        public Add()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //Update DB with new entry
            // Capture data from text boxes
            fname = Add_txt_Fname.Text;
            sname = Add_txt_Sname.Text;
            job_title = Add_txt_Job_title.Text;

            // Check if any fields are left blank
            if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(sname) || string.IsNullOrWhiteSpace(job_title))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method, preventing further execution
            }

            // Indicate success and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

