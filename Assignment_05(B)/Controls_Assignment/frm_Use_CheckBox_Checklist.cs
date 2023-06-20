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

        void UnVisible_Controls()
        {
            lbl_Name_Error.Visible = false;
            lbl_Dept_Error.Visible = false;
            lbl_Gender_Error.Visible = false;
            lbl_Lang_Error.Visible = false;
            lbl_Hobbies_Error.Visible = false;
        }

        void Visible_Controls()
        {
            lbl_Name_Error.Visible = true;
            lbl_Dept_Error.Visible = true;
            lbl_Gender_Error.Visible = true;
            lbl_Lang_Error.Visible = true;
            lbl_Hobbies_Error.Visible = true;
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
            UnVisible_Controls();
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

            lbl_Result.Text = "";
            UnVisible_Controls();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = false;

            UnVisible_Controls();

            if (tb_Emp_Name.Text != "")
            {
                Result = tb_Emp_Name.Text;

                if (cmb_Emp_Dept.Text != "")
                {
                    Result += " from department " + cmb_Emp_Dept.Text + " is ";

                    if (rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " candidate.Known Languages ";
                    }
                    else if (rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " candidate.Known Languages ";
                    }
                    else
                    {
                        lbl_Gender_Error.Visible = true;
                        lbl_Gender_Error.Text = "Select Gender";
                        Flag = true;
                    }

                    if(cb_Marathi.Checked == true)
                    {
                        if(cb_Hindi.Checked == true)
                        {
                            if(cb_English.Checked == true)
                            {
                                if(cb_French.Checked == true)
                                {
                                    Result += " are " + cb_Marathi.Text + " , " + cb_Hindi.Text + " , " + cb_English.Text + " , " + cb_French.Text + " . ";
                                }
                                else
                                {
                                    Result += " are " + cb_Marathi.Text + " , " + cb_Hindi.Text + " , " + cb_English.Text + " . ";
                                }
                            }
                            else if(cb_French.Checked == true)
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
                        else if(cb_French.Checked == true)
                        {
                            Result += " are " + cb_Marathi.Text + " , " + cb_French.Text + " . ";
                        }
                        else
                        {
                            Result += " is " + cb_Marathi.Text + " . ";
                        }
                    }
                    else if(cb_Hindi.Checked == true)
                    {
                        if(cb_English.Checked == true)
                        {
                            if(cb_French.Checked == true)
                            {
                                Result += " are " + cb_Hindi.Text + " , " + cb_English.Text + " , " + cb_French.Text + " . ";
                            }
                            else
                            {
                                Result += " are " + cb_Hindi.Text + " , " + cb_English.Text + " . ";
                            }
                        }
                        else if(cb_French.Checked == true)
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
                        if(cb_French.Checked == true)
                        {
                            Result += " are " + cb_English.Text + " , " + cb_French.Text + " . ";
                        }
                        else
                        {
                            Result += " are " + cb_English.Text + " . ";
                        }
                    }
                    else if (cb_French.Checked == true)
                    {
                        Result += " is " + cb_French.Text + " . ";
                    }
                    else
                    {
                        lbl_Lang_Error.Visible = true;
                        lbl_Lang_Error.Text = "Enter At Least One Language.";
                    }
                }
                else
                {
                    lbl_Dept_Error.Visible = true;
                    lbl_Dept_Error.Text = "Select Department";
                    Flag = true;
                }
            }
            else
            {
                lbl_Name_Error.Visible = true;
                lbl_Name_Error.Text = "Enter Employee Name";
                Flag = true;
            }
            if (Flag == false)
            {
                lbl_Result.Text = Result;
            }
        }
    }
}
