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
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }

        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mgt_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Mgt_System_DBDataSet.Student_Details);

        }
    }
}
