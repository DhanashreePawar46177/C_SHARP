using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        void Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Courses_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Course_ID) from Courses_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }

            else
            {
                Cnt = 1;
            }

            tb_Course_ID.Text = Convert.ToString(Cnt);

            Con_Close();

        }

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Courses_details Values(@Course_ID, @Course_Name)";

                Cmd.Parameters.Add("Course_ID", SqlDbType.Int).Value = tb_Course_ID.Text;
                Cmd.Parameters.Add("Course_Name", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Added Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Course_Name.Clear();
                Auto_Incr();
            }
            else
            {
                MessageBox.Show("Enter Course Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }
    }
}
