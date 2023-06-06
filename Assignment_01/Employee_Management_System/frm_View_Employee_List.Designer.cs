
namespace Employee_Management_System
{
    partial class frm_View_Employee_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Employee_List));
            this.lbl_View_Emlpoyee_List = new System.Windows.Forms.Label();
            this.dgv_Emp_List = new System.Windows.Forms.DataGridView();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_MGT_System_DBDataSet = new Employee_Management_System.Emp_MGT_System_DBDataSet();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.emp_DetailsTableAdapter = new Employee_Management_System.Emp_MGT_System_DBDataSetTableAdapters.Emp_DetailsTableAdapter();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_MGT_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Emlpoyee_List
            // 
            this.lbl_View_Emlpoyee_List.AutoSize = true;
            this.lbl_View_Emlpoyee_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_View_Emlpoyee_List.Font = new System.Drawing.Font("Modern No. 20", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Emlpoyee_List.ForeColor = System.Drawing.Color.Gray;
            this.lbl_View_Emlpoyee_List.Location = new System.Drawing.Point(235, 21);
            this.lbl_View_Emlpoyee_List.Name = "lbl_View_Emlpoyee_List";
            this.lbl_View_Emlpoyee_List.Size = new System.Drawing.Size(406, 48);
            this.lbl_View_Emlpoyee_List.TabIndex = 2;
            this.lbl_View_Emlpoyee_List.Text = "View Employee List";
            // 
            // dgv_Emp_List
            // 
            this.dgv_Emp_List.AllowUserToAddRows = false;
            this.dgv_Emp_List.AllowUserToDeleteRows = false;
            this.dgv_Emp_List.AutoGenerateColumns = false;
            this.dgv_Emp_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Emp_List.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Emp_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Emp_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emp_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.nameDataGridViewImageColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Emp_List.DataSource = this.empDetailsBindingSource;
            this.dgv_Emp_List.Location = new System.Drawing.Point(43, 98);
            this.dgv_Emp_List.Name = "dgv_Emp_List";
            this.dgv_Emp_List.ReadOnly = true;
            this.dgv_Emp_List.Size = new System.Drawing.Size(792, 333);
            this.dgv_Emp_List.TabIndex = 1;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewImageColumn
            // 
            this.nameDataGridViewImageColumn.DataPropertyName = "Name";
            this.nameDataGridViewImageColumn.HeaderText = "Name";
            this.nameDataGridViewImageColumn.Name = "nameDataGridViewImageColumn";
            this.nameDataGridViewImageColumn.ReadOnly = true;
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
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empDetailsBindingSource
            // 
            this.empDetailsBindingSource.DataMember = "Emp_Details";
            this.empDetailsBindingSource.DataSource = this.emp_MGT_System_DBDataSet;
            // 
            // emp_MGT_System_DBDataSet
            // 
            this.emp_MGT_System_DBDataSet.DataSetName = "Emp_MGT_System_DBDataSet";
            this.emp_MGT_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Tomato;
            this.btn_LogOut.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_LogOut.Location = new System.Drawing.Point(775, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(110, 35);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // emp_DetailsTableAdapter
            // 
            this.emp_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.Tomato;
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(310, 455);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(243, 44);
            this.btn_Add_New_Employee.TabIndex = 3;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.dgv_Emp_List);
            this.Controls.Add(this.lbl_View_Emlpoyee_List);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_MGT_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Emlpoyee_List;
        private System.Windows.Forms.DataGridView dgv_Emp_List;
        private System.Windows.Forms.Button btn_LogOut;
        private Emp_MGT_System_DBDataSet emp_MGT_System_DBDataSet;
        private System.Windows.Forms.BindingSource empDetailsBindingSource;
        private Emp_MGT_System_DBDataSetTableAdapters.Emp_DetailsTableAdapter emp_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn nameDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add_New_Employee;
    }
}