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

namespace Employee_Mgt_System
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Employee_Management_System_DB;Integrated Security=True");
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

        void Clear_Controls()
        {
            tb_MobNo.Clear();
            tb_Name.Clear();
            dtp_DOB.Text = "31 December 2010";
            cmb_Designation.SelectedIndex = -1;

            Auto_Increment();
            tb_Name.Focus();
        }

        void Auto_Increment()
        {
            int Cnt = 0;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Emp_Id) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }

            else
            {
                Cnt = 101;
            }

            tb_ID.Text = Convert.ToString(Cnt);

            Con_Close();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Common_Content.Log_Name;

            Clear_Controls();
            tb_Name.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_View_Employee_List Obj = new frm_View_Employee_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_ID.Text != "" && tb_Name.Text != "" && tb_MobNo.Text != "" && cmb_Designation.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details values(@ID, @Nm, @MobNo, @DOB, @Des)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_MobNo.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Designation.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Successfully Inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }

            else
            {
                MessageBox.Show("Fill all Fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
