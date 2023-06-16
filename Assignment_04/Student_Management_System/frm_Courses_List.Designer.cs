
namespace Student_Management_System
{
    partial class frm_Courses_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Courses_List = new System.Windows.Forms.Label();
            this.dgv_Courses_List = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet3 = new Student_Management_System.Student_Management_System_DBDataSet3();
            this.coursesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet2 = new Student_Management_System.Student_Management_System_DBDataSet2();
            this.courses_DetailsTableAdapter = new Student_Management_System.Student_Management_System_DBDataSet2TableAdapters.Courses_DetailsTableAdapter();
            this.courses_DetailsTableAdapter1 = new Student_Management_System.Student_Management_System_DBDataSet3TableAdapters.Courses_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Courses_List
            // 
            this.lbl_Courses_List.AutoSize = true;
            this.lbl_Courses_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Courses_List.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Courses_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Courses_List.Location = new System.Drawing.Point(327, 40);
            this.lbl_Courses_List.Name = "lbl_Courses_List";
            this.lbl_Courses_List.Size = new System.Drawing.Size(215, 41);
            this.lbl_Courses_List.TabIndex = 2;
            this.lbl_Courses_List.Text = "Courses List";
            // 
            // dgv_Courses_List
            // 
            this.dgv_Courses_List.AllowUserToAddRows = false;
            this.dgv_Courses_List.AllowUserToDeleteRows = false;
            this.dgv_Courses_List.AutoGenerateColumns = false;
            this.dgv_Courses_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Courses_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Courses_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Courses_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Courses_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_Courses_List.DataSource = this.coursesDetailsBindingSource1;
            this.dgv_Courses_List.Location = new System.Drawing.Point(95, 129);
            this.dgv_Courses_List.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Courses_List.Name = "dgv_Courses_List";
            this.dgv_Courses_List.ReadOnly = true;
            this.dgv_Courses_List.Size = new System.Drawing.Size(690, 337);
            this.dgv_Courses_List.TabIndex = 3;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDetailsBindingSource1
            // 
            this.coursesDetailsBindingSource1.DataMember = "Courses_Details";
            this.coursesDetailsBindingSource1.DataSource = this.student_Management_System_DBDataSet3;
            // 
            // student_Management_System_DBDataSet3
            // 
            this.student_Management_System_DBDataSet3.DataSetName = "Student_Management_System_DBDataSet3";
            this.student_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesDetailsBindingSource
            // 
            this.coursesDetailsBindingSource.DataMember = "Courses_Details";
            this.coursesDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet2;
            // 
            // student_Management_System_DBDataSet2
            // 
            this.student_Management_System_DBDataSet2.DataSetName = "Student_Management_System_DBDataSet2";
            this.student_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courses_DetailsTableAdapter
            // 
            this.courses_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // courses_DetailsTableAdapter1
            // 
            this.courses_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Courses_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Courses_List);
            this.Controls.Add(this.lbl_Courses_List);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Courses_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Courses List";
            this.Load += new System.EventHandler(this.frm_Courses_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Courses_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Courses_List;
        private System.Windows.Forms.DataGridView dgv_Courses_List;
        private Student_Management_System_DBDataSet2 student_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource coursesDetailsBindingSource;
        private Student_Management_System_DBDataSet2TableAdapters.Courses_DetailsTableAdapter courses_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private Student_Management_System_DBDataSet3 student_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource coursesDetailsBindingSource1;
        private Student_Management_System_DBDataSet3TableAdapters.Courses_DetailsTableAdapter courses_DetailsTableAdapter1;
    }
}