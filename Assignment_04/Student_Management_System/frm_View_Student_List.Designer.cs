
namespace Student_Management_System
{
    partial class frm_View_Student_List
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
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Management_System_DBDataSet1 = new Student_Management_System.Student_Management_System_DBDataSet1();
            this.student_DetailsTableAdapter = new Student_Management_System.Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(295, 31);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(309, 41);
            this.lbl_View_Student_List.TabIndex = 15;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_Student_List.Location = new System.Drawing.Point(53, 100);
            this.dgv_Student_List.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.Size = new System.Drawing.Size(783, 384);
            this.dgv_Student_List.TabIndex = 16;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "Courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "Courses";
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_Management_System_DBDataSet1;
            // 
            // student_Management_System_DBDataSet1
            // 
            this.student_Management_System_DBDataSet1.DataSetName = "Student_Management_System_DBDataSet1";
            this.student_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_View_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Student List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private Student_Management_System_DBDataSet1 student_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Management_System_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
    }
}