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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Mgt_System_DB;Integrated Security=True");

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

        void Enable_Controls()
        {
            tb_Roll_No.Enabled = false;
            tb_Name.Enabled = true;
            tb_Mob_No.Enabled = true;
            dtp_DOB.Enabled = true;
            cmb_Courses.Enabled = true;
        }
        void Disable_Controls()
        {
            tb_Roll_No.Enabled = true;
            tb_Name.Enabled = false;
            tb_Mob_No.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Courses.Enabled = false;
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
        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
            Disable_Controls();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Roll_No.Text != "")
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

                    Enable_Controls();
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
                MessageBox.Show("Enter Roll Number", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Courses.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Update Student_Details Set Name = @Nm, Mob_No = @MNo, DOB = @DOB, Courses = @Courses where Roll_No = @RN";

                Cmd.Parameters.Add("RN", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Courses", SqlDbType.NVarChar).Value = cmb_Courses.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();
            }

            else
            {
                MessageBox.Show("Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }
    }
}
