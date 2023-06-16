using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
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

        void Clear_Controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Text = "";
            tb_Mob_No.Text = "";
            dtp_DOB.Text = "31 December 2010";
            cmb_Courses.SelectedIndex = -1;

            tb_Roll_No.Focus();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_Roll_No.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Student_Details where Roll_No = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mob_No.Text = (Dr["Mob_No"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    cmb_Courses.Text = Dr.GetString(Dr.GetOrdinal("Courses"));
                }
                else
                {
                    MessageBox.Show("No Student Found With Given Roll Number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("First Enter Roll Number", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }
    }
}
