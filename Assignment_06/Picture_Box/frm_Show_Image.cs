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
using System.IO;

namespace Picture_Box
{
    public partial class frm_Show_Image : Form
    {
        public frm_Show_Image()
        {
            InitializeComponent();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Nature_Images_DB;Integrated Security=True");

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

        void Bind_Grid(string Query, DataGridView Obj)
        {
            Con_Open();
            Obj.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            Obj.DataSource = dt;

            Con_Close();
        }

        void View_Image(string Query, PictureBox pb)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand(Query, Con);

            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pb.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Invalid Image ID");
            }

            Con_Close();
        }

        private void btn_Add_Image_Click(object sender, EventArgs e)
        {
            frm_Add_Image Obj = new frm_Add_Image();
            Obj.Show();
            this.Hide();
        }

        private void frm_Show_Image_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select Id, Image_Description from Nature_Images", dgv_Image_List);
        }

        private void dgv_Image_List_Selection_Changed(object sender, EventArgs e)
        {
            int selectedRowCount = dgv_Image_List.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(selectedRowCount == 1)
            {
                string value = dgv_Image_List.SelectedCells[0].RowIndex.ToString();

                int Index = Convert.ToInt32(value);

                int ID = Convert.ToInt32(dgv_Image_List.Rows[Index].Cells[0].Value);

                View_Image("Select Image from Nature_Images where Id = " + ID + "", pb_Image);
            }
        }
    }
}
