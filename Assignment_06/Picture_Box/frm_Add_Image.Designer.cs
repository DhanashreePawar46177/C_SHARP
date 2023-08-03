
namespace Picture_Box
{
    partial class frm_Add_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Image));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pb_Add_Image = new System.Windows.Forms.PictureBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Image_Description = new System.Windows.Forms.Label();
            this.lbl_Img_ID = new System.Windows.Forms.Label();
            this.tb_Image_ID = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Show_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.White;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(358, 31);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(154, 29);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Insert Image";
            // 
            // pb_Add_Image
            // 
            this.pb_Add_Image.BackColor = System.Drawing.Color.White;
            this.pb_Add_Image.Image = global::Picture_Box.Properties.Resources.Title1;
            this.pb_Add_Image.Location = new System.Drawing.Point(520, 97);
            this.pb_Add_Image.Name = "pb_Add_Image";
            this.pb_Add_Image.Size = new System.Drawing.Size(329, 252);
            this.pb_Add_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Add_Image.TabIndex = 1;
            this.pb_Add_Image.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Violet;
            this.btn_Browse.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(646, 355);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(99, 35);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(206, 173);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(245, 203);
            this.tb_Description.TabIndex = 2;
            // 
            // lbl_Image_Description
            // 
            this.lbl_Image_Description.AutoSize = true;
            this.lbl_Image_Description.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Description.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Image_Description.Location = new System.Drawing.Point(33, 173);
            this.lbl_Image_Description.Name = "lbl_Image_Description";
            this.lbl_Image_Description.Size = new System.Drawing.Size(158, 22);
            this.lbl_Image_Description.TabIndex = 5;
            this.lbl_Image_Description.Text = "Image Description";
            // 
            // lbl_Img_ID
            // 
            this.lbl_Img_ID.AutoSize = true;
            this.lbl_Img_ID.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Img_ID.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Img_ID.Location = new System.Drawing.Point(33, 97);
            this.lbl_Img_ID.Name = "lbl_Img_ID";
            this.lbl_Img_ID.Size = new System.Drawing.Size(87, 22);
            this.lbl_Img_ID.TabIndex = 7;
            this.lbl_Img_ID.Text = "Image ID";
            // 
            // tb_Image_ID
            // 
            this.tb_Image_ID.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_ID.Location = new System.Drawing.Point(206, 97);
            this.tb_Image_ID.Name = "tb_Image_ID";
            this.tb_Image_ID.Size = new System.Drawing.Size(245, 29);
            this.tb_Image_ID.TabIndex = 1;
            this.tb_Image_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(88, 444);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(147, 43);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(363, 444);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(147, 43);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Show_Image
            // 
            this.btn_Show_Image.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Show_Image.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Image.ForeColor = System.Drawing.Color.White;
            this.btn_Show_Image.Location = new System.Drawing.Point(646, 444);
            this.btn_Show_Image.Name = "btn_Show_Image";
            this.btn_Show_Image.Size = new System.Drawing.Size(147, 43);
            this.btn_Show_Image.TabIndex = 11;
            this.btn_Show_Image.Text = " Show Image";
            this.btn_Show_Image.UseVisualStyleBackColor = false;
            this.btn_Show_Image.Click += new System.EventHandler(this.btn_Show_Image_Click);
            // 
            // frm_Add_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btn_Show_Image);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tb_Image_ID);
            this.Controls.Add(this.lbl_Img_ID);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.lbl_Image_Description);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.pb_Add_Image);
            this.Controls.Add(this.lbl_Header);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Image";
            this.Load += new System.EventHandler(this.frm_Add_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.PictureBox pb_Add_Image;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label lbl_Image_Description;
        private System.Windows.Forms.Label lbl_Img_ID;
        private System.Windows.Forms.TextBox tb_Image_ID;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Show_Image;
    }
}

