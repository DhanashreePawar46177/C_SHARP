
namespace Picture_Box
{
    partial class frm_Show_Image
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Show_Image));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Image_List = new System.Windows.Forms.Label();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(362, 41);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(148, 29);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Show Image";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image.Location = new System.Drawing.Point(164, 106);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(59, 22);
            this.lbl_Image.TabIndex = 2;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Image_List
            // 
            this.lbl_Image_List.AutoSize = true;
            this.lbl_Image_List.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_List.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image_List.Location = new System.Drawing.Point(593, 106);
            this.lbl_Image_List.Name = "lbl_Image_List";
            this.lbl_Image_List.Size = new System.Drawing.Size(97, 22);
            this.lbl_Image_List.TabIndex = 3;
            this.lbl_Image_List.Text = "Image List";
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Add_Image.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Image.Location = new System.Drawing.Point(367, 442);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(147, 43);
            this.btn_Add_Image.TabIndex = 6;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = false;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.AllowUserToAddRows = false;
            this.dgv_Image_List.AllowUserToDeleteRows = false;
            this.dgv_Image_List.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(487, 150);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.ReadOnly = true;
            this.dgv_Image_List.Size = new System.Drawing.Size(351, 256);
            this.dgv_Image_List.TabIndex = 7;
            this.dgv_Image_List.SelectionChanged += new System.EventHandler(this.dgv_Image_List_Selection_Changed);
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(56, 150);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(355, 256);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 8;
            this.pb_Image.TabStop = false;
            // 
            // frm_Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.lbl_Image_List);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Image";
            this.Load += new System.EventHandler(this.frm_Show_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Image_List;
        private System.Windows.Forms.Button btn_Add_Image;
        private System.Windows.Forms.DataGridView dgv_Image_List;
        private System.Windows.Forms.PictureBox pb_Image;
    }
}