
namespace Student_Management_System
{
    partial class frm_Add_Student_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Student_Details));
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_Courses = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_Courses = new System.Windows.Forms.Label();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Save.Location = new System.Drawing.Point(360, 423);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(160, 43);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_Courses
            // 
            this.cmb_Courses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Courses.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Courses.FormattingEnabled = true;
            this.cmb_Courses.Items.AddRange(new object[] {
            "BCA",
            "MCA",
            "BSC",
            "MSC",
            "BBA",
            "MBA"});
            this.cmb_Courses.Location = new System.Drawing.Point(508, 355);
            this.cmb_Courses.MaxLength = 50;
            this.cmb_Courses.Name = "cmb_Courses";
            this.cmb_Courses.Size = new System.Drawing.Size(200, 29);
            this.cmb_Courses.TabIndex = 5;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(508, 292);
            this.dtp_DOB.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(200, 31);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // lbl_Courses
            // 
            this.lbl_Courses.AutoSize = true;
            this.lbl_Courses.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Courses.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Courses.Location = new System.Drawing.Point(176, 355);
            this.lbl_Courses.Name = "lbl_Courses";
            this.lbl_Courses.Size = new System.Drawing.Size(102, 29);
            this.lbl_Courses.TabIndex = 24;
            this.lbl_Courses.Text = "Courses";
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(508, 232);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(200, 31);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Mob_No.Location = new System.Drawing.Point(176, 234);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(134, 29);
            this.lbl_Mob_No.TabIndex = 23;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Roll_No.Location = new System.Drawing.Point(176, 129);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(102, 29);
            this.lbl_Roll_No.TabIndex = 22;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(508, 181);
            this.tb_Name.MaxLength = 120;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(200, 31);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_DOB.Location = new System.Drawing.Point(176, 294);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(92, 29);
            this.lbl_DOB.TabIndex = 21;
            this.lbl_DOB.Text = "D.O.B.";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Name.Location = new System.Drawing.Point(176, 183);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 29);
            this.lbl_Name.TabIndex = 19;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.Turquoise;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(272, 43);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(345, 41);
            this.lbl_Add_New_Student.TabIndex = 14;
            this.lbl_Add_New_Student.Text = "Add Student Details";
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Enabled = false;
            this.tb_Roll_No.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(508, 129);
            this.tb_Roll_No.MaxLength = 10;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(200, 31);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // frm_Add_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Courses);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_Courses);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Student Details";
            this.Load += new System.EventHandler(this.frm_Add_Student_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Courses;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_Courses;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.TextBox tb_Roll_No;
    }
}