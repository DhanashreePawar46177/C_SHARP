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

namespace Picture_Box
{
    public partial class frm_Add_Image : Form
    {
        public frm_Add_Image()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Nature_Images_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Image_ID.Clear();
            tb_Description.Clear();
            pb_Add_Image.Image = null;
        }

        private void btn_Show_Image_Click(object sender, EventArgs e)
        {
            frm_Show_Image Obj = new frm_Show_Image();
            Obj.Show();
            this.Hide();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_Image_Load(object sender, EventArgs e)
        {
            tb_Image_ID.Focus();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpeg; *.jpg; *.gif; *.bmp)|*.jpeg; *.jpg; *.gif; *.bmp";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Add_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Image_ID.Text != "" && tb_Description.Text != "" && pb_Add_Image != null)
            {
                SqlCommand cmd = new SqlCommand("Insert Into Nature_Images Values (@Id, @Image_Description, @Image)", Con);

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = tb_Image_ID.Text;
                cmd.Parameters.Add("@Image_Description", SqlDbType.NVarChar).Value = tb_Description.Text;

                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Add_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All the Fields!!!");
            }
        }
    }
}
