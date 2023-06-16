
namespace Student_Management_System
{
    partial class MDI_Student_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Student_App));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Log_UName = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.viewStudentListToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.updateStudentToolStripMenuItem.Text = "Update Student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // viewStudentListToolStripMenuItem
            // 
            this.viewStudentListToolStripMenuItem.Name = "viewStudentListToolStripMenuItem";
            this.viewStudentListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewStudentListToolStripMenuItem.Text = "View Student List";
            this.viewStudentListToolStripMenuItem.Click += new System.EventHandler(this.viewStudentListToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.courseListToolStripMenuItem});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // courseListToolStripMenuItem
            // 
            this.courseListToolStripMenuItem.Name = "courseListToolStripMenuItem";
            this.courseListToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.courseListToolStripMenuItem.Text = "Courses List";
            this.courseListToolStripMenuItem.Click += new System.EventHandler(this.courseListToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Crimson;
            this.btn_LogOut.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_LogOut.Location = new System.Drawing.Point(790, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(94, 24);
            this.btn_LogOut.TabIndex = 14;
            this.btn_LogOut.Text = "LOG OUT";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_Log_UName
            // 
            this.lbl_Log_UName.AutoSize = true;
            this.lbl_Log_UName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_Log_UName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_Log_UName.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log_UName.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Log_UName.Location = new System.Drawing.Point(576, 0);
            this.lbl_Log_UName.Name = "lbl_Log_UName";
            this.lbl_Log_UName.Size = new System.Drawing.Size(138, 24);
            this.lbl_Log_UName.TabIndex = 15;
            this.lbl_Log_UName.Text = "LoggedInUser";
            this.lbl_Log_UName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MDI_Student_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 535);
            this.Controls.Add(this.lbl_Log_UName);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_Student_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student App";
            this.Load += new System.EventHandler(this.MDI_Student_App_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_Log_UName;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseListToolStripMenuItem;
    }
}



