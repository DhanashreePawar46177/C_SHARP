using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "D" && tb_Password.Text == "123")
            {
                MessageBox.Show("Login Successfully");

                frm_Add_New_Employee Obj = new frm_Add_New_Employee();
                Obj.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Enter Valid Username and Password");
            }
        }
    }
}
