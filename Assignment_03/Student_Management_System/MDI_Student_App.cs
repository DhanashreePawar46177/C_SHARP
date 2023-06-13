using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MDI_Student_App : Form
    {
        private int childFormNumber = 0;

        public MDI_Student_App()
        {
            InitializeComponent();
        }

        private void MDI_Student_App_Load(object sender, EventArgs e)
        {
            lbl_Log_UName.Text = "Welcome " + Common_Content.Log_Nm;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details Obj = new frm_Add_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details Obj = new frm_Update_Student_Details();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void viewStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_List Obj = new frm_View_Student_List();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Course Obj = new frm_Add_Course();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Courses_List Obj = new frm_Courses_List();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.Exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want to Log Out", "LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }
    }
}
