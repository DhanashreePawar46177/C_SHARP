using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_Assignment
{
    public partial class frm_Use_CheckBox_Checklist : Form
    {
        public frm_Use_CheckBox_Checklist()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void frm_Use_CheckBox_Checklist_Load(object sender, EventArgs e)
        {
            tb_Emp_Name.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Emp_Name.Clear();
            cmb_Emp_Dept.SelectedIndex = -1;

            rb_Female.Checked = false;
            rb_Male.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false; 
            cb_English.Checked = false;
            cb_French.Checked = false;

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
                clb_Hobbies.SelectedIndex = -1;
            }

            lbl_Result.Text = "";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true;

            if (tb_Emp_Name.Text != "")
            {
                Result = tb_Emp_Name.Text;
                lbl_Name_Error.Visible = false;
            }
            else
            {
                lbl_Name_Error.Visible = true;
                Flag = false;
            }

            if (cmb_Emp_Dept.Text != "")
            {
                Result += " from department " + cmb_Emp_Dept.Text + " is ";
                lbl_Dept_Error.Visible = false;
            }
            else
            {
                lbl_Dept_Error.Visible = true;
                Flag = false;
            }

            if (rb_Female.Checked == true)
            {
                Result += rb_Female.Text + " candidate.Known Languages";
                lbl_Gender_Error.Visible = false;
            }
            else if (rb_Male.Checked == true)
            {
                Result += rb_Male.Text + " candidate.Known Languages";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }

            if (cb_Marathi.Checked == true)
            {
                lbl_Lang_Error.Visible = false;

                if (cb_Hindi.Checked == true)
                {
                    if (cb_English.Checked == true)
                    {
                        if (cb_French.Checked == true)
                        {
                            Result += " are " + cb_Marathi.Text + " , " + cb_Hindi.Text + " , " + cb_English.Text + " , " + cb_French.Text + " . ";
                        }
                        else
                        {
                            Result += " are " + cb_Marathi.Text + " , " + cb_Hindi.Text + " , " + cb_English.Text + " . ";
                        }
                    }
                    else if (cb_French.Checked == true)
                    {
                        Result += " are " + cb_Marathi.Text + " , " + cb_Hindi.Text + " , " + cb_French.Text + " . ";
                    }
                    else
                    {
                        Result += " are " + cb_Marathi.Text + " , " + cb_Hindi.Text + " . ";
                    }
                }
                else if (cb_English.Checked == true)
                {
                    if (cb_French.Checked == true)
                    {
                        Result += " are " + cb_Marathi.Text + " , " + cb_English.Text + " , " + cb_French.Text + " . ";
                    }
                    else
                    {
                        Result += " are " + cb_Marathi.Text + " , " + cb_English.Text + " . ";
                    }
                }
                else if (cb_French.Checked == true)
                {
                    Result += " are " + cb_Marathi.Text + " , " + cb_French.Text + " . ";
                }
                else
                {
                    Result += " is " + cb_Marathi.Text + " . ";
                }
            }
            else if (cb_Hindi.Checked == true)
            {
                lbl_Lang_Error.Visible = false;

                if (cb_English.Checked == true)
                {
                    if (cb_French.Checked == true)
                    {
                        Result += " are " + cb_Hindi.Text + " , " + cb_English.Text + " , " + cb_French.Text + " . ";
                    }
                    else
                    {
                        Result += " are " + cb_Hindi.Text + " , " + cb_English.Text + " . ";
                    }
                }
                else if (cb_French.Checked == true)
                {
                    Result += " are " + cb_Hindi.Text + " , " + cb_French.Text + " . ";
                }
                else
                {
                    Result += " is " + cb_Hindi.Text + " . ";
                }
            }
            else if (cb_English.Checked == true)
            {
                lbl_Lang_Error.Visible = false;

                if (cb_French.Checked == true)
                {
                    Result += " are " + cb_English.Text + " , " + cb_French.Text + " . ";
                }
                else
                {
                    Result += " is " + cb_English.Text + " . ";
                }
            }
            else if (cb_French.Checked == true)
            {
                Result += " is " + cb_French.Text + " . ";
                lbl_Lang_Error.Visible = false;
            }
            else
            {
                lbl_Lang_Error.Visible = true;
                Flag = false;
            }

            int Cnt = clb_Hobbies.CheckedItems.Count;

            if(Cnt > 0)
            {
                Result += "Hobbies are ";
                lbl_Hobbies_Error.Visible = false;
            }
            else
            {
                lbl_Hobbies_Error.Visible = true;
                Flag = false;
            }
            
            for(int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                if(clb_Hobbies.GetItemChecked(i))
                {
                    if(Cnt > 1)
                    {
                        Result += clb_Hobbies.Items[i] + " , ";
                    }
                    else
                    {
                        Result += clb_Hobbies.Items[i] + " . ";
                    }
                    Cnt--;
                }
            }

            if (Flag == false)
            {
                lbl_Result.Visible = false;
            }
            else
            {
                lbl_Result.Text = Result;
                lbl_Result.Visible = true;
            }
        }
    }
}
