
namespace Controls_Assignment
{
    partial class frm_Use_CheckBox_Checklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Use_CheckBox_Checklist));
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.cmb_Emp_Dept = new System.Windows.Forms.ComboBox();
            this.tb_Emp_Name = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Emp_Dept = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_Details = new System.Windows.Forms.Label();
            this.pnl_Output = new System.Windows.Forms.Panel();
            this.lbl_Ans = new System.Windows.Forms.Label();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.lbl_Lang = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.lbl_Name_Error = new System.Windows.Forms.Label();
            this.lbl_Dept_Error = new System.Windows.Forms.Label();
            this.lbl_Gender_Error = new System.Windows.Forms.Label();
            this.lbl_Lang_Error = new System.Windows.Forms.Label();
            this.lbl_Hobbies_Error = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.pnl_Output.SuspendLayout();
            this.gb_Shift_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Location = new System.Drawing.Point(389, 404);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(131, 37);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Blue;
            this.btn_Submit.Location = new System.Drawing.Point(675, 404);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(131, 37);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Output.Location = new System.Drawing.Point(41, 468);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(93, 25);
            this.lbl_Output.TabIndex = 22;
            this.lbl_Output.Text = "Output : ";
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.SystemColors.Info;
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(262, 295);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(259, 55);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(155, 24);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(58, 22);
            this.rb_Male.TabIndex = 5;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(43, 22);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(72, 22);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // cmb_Emp_Dept
            // 
            this.cmb_Emp_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Emp_Dept.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Emp_Dept.FormattingEnabled = true;
            this.cmb_Emp_Dept.Items.AddRange(new object[] {
            "R&D",
            "HRD",
            "Testing",
            "Management"});
            this.cmb_Emp_Dept.Location = new System.Drawing.Point(262, 198);
            this.cmb_Emp_Dept.Name = "cmb_Emp_Dept";
            this.cmb_Emp_Dept.Size = new System.Drawing.Size(259, 26);
            this.cmb_Emp_Dept.TabIndex = 2;
            // 
            // tb_Emp_Name
            // 
            this.tb_Emp_Name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_Emp_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Name.Location = new System.Drawing.Point(262, 95);
            this.tb_Emp_Name.MaxLength = 60;
            this.tb_Emp_Name.Name = "tb_Emp_Name";
            this.tb_Emp_Name.Size = new System.Drawing.Size(259, 25);
            this.tb_Emp_Name.TabIndex = 1;
            this.tb_Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Gender.Location = new System.Drawing.Point(17, 295);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(77, 25);
            this.lbl_Gender.TabIndex = 19;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Emp_Dept
            // 
            this.lbl_Emp_Dept.AutoSize = true;
            this.lbl_Emp_Dept.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Dept.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Emp_Dept.Location = new System.Drawing.Point(17, 196);
            this.lbl_Emp_Dept.Name = "lbl_Emp_Dept";
            this.lbl_Emp_Dept.Size = new System.Drawing.Size(216, 25);
            this.lbl_Emp_Dept.TabIndex = 17;
            this.lbl_Emp_Dept.Text = "Employee Department";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Emp_Name.Location = new System.Drawing.Point(17, 90);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(160, 25);
            this.lbl_Emp_Name.TabIndex = 15;
            this.lbl_Emp_Name.Text = "Employee Name";
            // 
            // lbl_Emp_Details
            // 
            this.lbl_Emp_Details.AutoSize = true;
            this.lbl_Emp_Details.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Emp_Details.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Details.ForeColor = System.Drawing.Color.Red;
            this.lbl_Emp_Details.Location = new System.Drawing.Point(397, 9);
            this.lbl_Emp_Details.Name = "lbl_Emp_Details";
            this.lbl_Emp_Details.Size = new System.Drawing.Size(302, 41);
            this.lbl_Emp_Details.TabIndex = 13;
            this.lbl_Emp_Details.Text = "Employee Details";
            // 
            // pnl_Output
            // 
            this.pnl_Output.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Output.Controls.Add(this.lbl_Ans);
            this.pnl_Output.Location = new System.Drawing.Point(152, 468);
            this.pnl_Output.Name = "pnl_Output";
            this.pnl_Output.Size = new System.Drawing.Size(908, 25);
            this.pnl_Output.TabIndex = 26;
            // 
            // lbl_Ans
            // 
            this.lbl_Ans.AutoSize = true;
            this.lbl_Ans.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ans.Location = new System.Drawing.Point(3, 0);
            this.lbl_Ans.Name = "lbl_Ans";
            this.lbl_Ans.Size = new System.Drawing.Size(329, 22);
            this.lbl_Ans.TabIndex = 12;
            this.lbl_Ans.Text = "Output Of Submit Button Appears Here";
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.BackColor = System.Drawing.SystemColors.Info;
            this.gb_Shift_Time.Controls.Add(this.cb_French);
            this.gb_Shift_Time.Controls.Add(this.cb_English);
            this.gb_Shift_Time.Controls.Add(this.cb_Hindi);
            this.gb_Shift_Time.Controls.Add(this.cb_Marathi);
            this.gb_Shift_Time.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Shift_Time.Location = new System.Drawing.Point(781, 73);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(282, 96);
            this.gb_Shift_Time.TabIndex = 27;
            this.gb_Shift_Time.TabStop = false;
            // 
            // lbl_Lang
            // 
            this.lbl_Lang.AutoSize = true;
            this.lbl_Lang.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lang.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Lang.Location = new System.Drawing.Point(570, 95);
            this.lbl_Lang.Name = "lbl_Lang";
            this.lbl_Lang.Size = new System.Drawing.Size(183, 25);
            this.lbl_Lang.TabIndex = 28;
            this.lbl_Lang.Text = "Known Languages";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Hobbies.Location = new System.Drawing.Point(570, 214);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(87, 25);
            this.lbl_Hobbies.TabIndex = 29;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Location = new System.Drawing.Point(22, 26);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(80, 22);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Location = new System.Drawing.Point(144, 26);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(67, 22);
            this.cb_Hindi.TabIndex = 1;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Location = new System.Drawing.Point(22, 71);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(79, 22);
            this.cb_English.TabIndex = 2;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Location = new System.Drawing.Point(144, 71);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(73, 22);
            this.cb_French.TabIndex = 3;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.BackColor = System.Drawing.SystemColors.Info;
            this.clb_Hobbies.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Driving",
            "Swimming",
            "Reading",
            "Gaming",
            "Drawing",
            "Cooking"});
            this.clb_Hobbies.Location = new System.Drawing.Point(781, 214);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(282, 148);
            this.clb_Hobbies.TabIndex = 30;
            // 
            // lbl_Name_Error
            // 
            this.lbl_Name_Error.AutoSize = true;
            this.lbl_Name_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Name_Error.Location = new System.Drawing.Point(259, 144);
            this.lbl_Name_Error.Name = "lbl_Name_Error";
            this.lbl_Name_Error.Size = new System.Drawing.Size(85, 18);
            this.lbl_Name_Error.TabIndex = 31;
            this.lbl_Name_Error.Text = "Name Error";
            // 
            // lbl_Dept_Error
            // 
            this.lbl_Dept_Error.AutoSize = true;
            this.lbl_Dept_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Dept_Error.Location = new System.Drawing.Point(259, 245);
            this.lbl_Dept_Error.Name = "lbl_Dept_Error";
            this.lbl_Dept_Error.Size = new System.Drawing.Size(87, 18);
            this.lbl_Dept_Error.TabIndex = 32;
            this.lbl_Dept_Error.Text = "Dept_Error";
            // 
            // lbl_Gender_Error
            // 
            this.lbl_Gender_Error.AutoSize = true;
            this.lbl_Gender_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Gender_Error.Location = new System.Drawing.Point(259, 374);
            this.lbl_Gender_Error.Name = "lbl_Gender_Error";
            this.lbl_Gender_Error.Size = new System.Drawing.Size(95, 18);
            this.lbl_Gender_Error.TabIndex = 33;
            this.lbl_Gender_Error.Text = "Gender Error";
            // 
            // lbl_Lang_Error
            // 
            this.lbl_Lang_Error.AutoSize = true;
            this.lbl_Lang_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lang_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Lang_Error.Location = new System.Drawing.Point(778, 183);
            this.lbl_Lang_Error.Name = "lbl_Lang_Error";
            this.lbl_Lang_Error.Size = new System.Drawing.Size(83, 18);
            this.lbl_Lang_Error.TabIndex = 34;
            this.lbl_Lang_Error.Text = "Lang Error";
            // 
            // lbl_Hobbies_Error
            // 
            this.lbl_Hobbies_Error.AutoSize = true;
            this.lbl_Hobbies_Error.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies_Error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Hobbies_Error.Location = new System.Drawing.Point(780, 374);
            this.lbl_Hobbies_Error.Name = "lbl_Hobbies_Error";
            this.lbl_Hobbies_Error.Size = new System.Drawing.Size(102, 18);
            this.lbl_Hobbies_Error.TabIndex = 35;
            this.lbl_Hobbies_Error.Text = "Hobbies Error";
            // 
            // frm_Use_CheckBox_Checklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.lbl_Hobbies_Error);
            this.Controls.Add(this.lbl_Lang_Error);
            this.Controls.Add(this.lbl_Gender_Error);
            this.Controls.Add(this.lbl_Dept_Error);
            this.Controls.Add(this.lbl_Name_Error);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.lbl_Lang);
            this.Controls.Add(this.pnl_Output);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Emp_Dept);
            this.Controls.Add(this.tb_Emp_Name);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Emp_Dept);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Emp_Details);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Use_CheckBox_Checklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use CheckBox Checklist";
            this.Load += new System.EventHandler(this.frm_Use_CheckBox_Checklist_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.pnl_Output.ResumeLayout(false);
            this.pnl_Output.PerformLayout();
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.ComboBox cmb_Emp_Dept;
        private System.Windows.Forms.TextBox tb_Emp_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Emp_Dept;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.Label lbl_Emp_Details;
        private System.Windows.Forms.Panel pnl_Output;
        private System.Windows.Forms.Label lbl_Ans;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.Label lbl_Lang;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.Label lbl_Name_Error;
        private System.Windows.Forms.Label lbl_Dept_Error;
        private System.Windows.Forms.Label lbl_Gender_Error;
        private System.Windows.Forms.Label lbl_Lang_Error;
        private System.Windows.Forms.Label lbl_Hobbies_Error;
    }
}