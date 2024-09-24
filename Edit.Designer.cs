namespace CRUD
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Cancel = new Button();
            btn_Submit = new Button();
            Edit_txt_Job_title = new TextBox();
            Edit_txt_Sname = new TextBox();
            Edit_txt_Fname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(326, 54);
            label1.Name = "label1";
            label1.Size = new Size(84, 46);
            label1.TabIndex = 1;
            label1.Text = "Edit:";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(432, 289);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 33;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(274, 289);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(94, 29);
            btn_Submit.TabIndex = 32;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // Edit_txt_Job_title
            // 
            Edit_txt_Job_title.Location = new Point(401, 197);
            Edit_txt_Job_title.Name = "Edit_txt_Job_title";
            Edit_txt_Job_title.Size = new Size(125, 27);
            Edit_txt_Job_title.TabIndex = 31;
            // 
            // Edit_txt_Sname
            // 
            Edit_txt_Sname.Location = new Point(401, 164);
            Edit_txt_Sname.Name = "Edit_txt_Sname";
            Edit_txt_Sname.Size = new Size(125, 27);
            Edit_txt_Sname.TabIndex = 30;
            // 
            // Edit_txt_Fname
            // 
            Edit_txt_Fname.Location = new Point(401, 132);
            Edit_txt_Fname.Name = "Edit_txt_Fname";
            Edit_txt_Fname.Size = new Size(125, 27);
            Edit_txt_Fname.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 204);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 28;
            label5.Text = "Job Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 171);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 27;
            label4.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 135);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 26;
            label3.Text = "First Name";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Submit);
            Controls.Add(Edit_txt_Job_title);
            Controls.Add(Edit_txt_Sname);
            Controls.Add(Edit_txt_Fname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Cancel;
        private Button btn_Submit;
        private TextBox Edit_txt_Job_title;
        private TextBox Edit_txt_Sname;
        private TextBox Edit_txt_Fname;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}