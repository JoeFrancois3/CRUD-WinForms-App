namespace CRUD
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btn_Add = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            btn_Save = new Button();
            btn_Cancel = new Button();
            btn_Refresh = new Button();
            label2 = new Label();
            label3 = new Label();
            textboc20 = new Label();
            txt_Id = new TextBox();
            txt_fname = new TextBox();
            txt_Sname = new TextBox();
            label5 = new Label();
            txt_JobTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(594, 229);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 35);
            label1.TabIndex = 1;
            label1.Text = "CRUD:";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(59, 93);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(159, 93);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(94, 29);
            btn_Edit.TabIndex = 3;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(259, 93);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(359, 94);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(459, 94);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(559, 94);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(94, 29);
            btn_Refresh.TabIndex = 7;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 411);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 8;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 444);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Firstname:";
            // 
            // textboc20
            // 
            textboc20.AutoSize = true;
            textboc20.Location = new Point(104, 480);
            textboc20.Name = "textboc20";
            textboc20.Size = new Size(70, 20);
            textboc20.TabIndex = 10;
            textboc20.Text = "Surname:";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(228, 408);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(125, 27);
            txt_Id.TabIndex = 12;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(228, 441);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(125, 27);
            txt_fname.TabIndex = 13;
            // 
            // txt_Sname
            // 
            txt_Sname.Location = new Point(228, 473);
            txt_Sname.Name = "txt_Sname";
            txt_Sname.Size = new Size(125, 27);
            txt_Sname.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 513);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 11;
            label5.Text = "Job Title";
            // 
            // txt_JobTitle
            // 
            txt_JobTitle.Location = new Point(228, 506);
            txt_JobTitle.Name = "txt_JobTitle";
            txt_JobTitle.Size = new Size(125, 27);
            txt_JobTitle.TabIndex = 15;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(txt_JobTitle);
            Controls.Add(txt_Sname);
            Controls.Add(txt_fname);
            Controls.Add(txt_Id);
            Controls.Add(label5);
            Controls.Add(textboc20);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btn_Add;
        private Button btn_Edit;
        private Button btn_Delete;
        private Button btn_Save;
        private Button btn_Cancel;
        private Button btn_Refresh;
        private Label label2;
        private Label label3;
        private Label textboc20;
        private TextBox txt_Id;
        private TextBox txt_fname;
        private TextBox txt_Sname;
        private Label label5;
        private TextBox txt_JobTitle;
    }
}
