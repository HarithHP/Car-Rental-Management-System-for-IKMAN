namespace IKMAN_APP
{
    partial class Rent_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent_form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_about_us = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_rent = new System.Windows.Forms.Button();
            this.btn_vehicle_details = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_cid = new MetroFramework.Controls.MetroComboBox();
            this.picker_rent_date = new MetroFramework.Controls.MetroDateTime();
            this.picker_return_date = new MetroFramework.Controls.MetroDateTime();
            this.txt_fees = new MetroFramework.Controls.MetroTextBox();
            this.btn_pay_rent = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_car_reg_number = new MetroFramework.Controls.MetroComboBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 92;
            this.label1.Text = "Car Reg Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_about_us);
            this.panel2.Controls.Add(this.btn_return);
            this.panel2.Controls.Add(this.btn_rent);
            this.panel2.Controls.Add(this.btn_vehicle_details);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 441);
            this.panel2.TabIndex = 91;
            // 
            // btn_about_us
            // 
            this.btn_about_us.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about_us.FlatAppearance.BorderSize = 0;
            this.btn_about_us.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_about_us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about_us.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about_us.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about_us.Location = new System.Drawing.Point(0, 153);
            this.btn_about_us.Name = "btn_about_us";
            this.btn_about_us.Size = new System.Drawing.Size(173, 51);
            this.btn_about_us.TabIndex = 19;
            this.btn_about_us.Text = "About us";
            this.btn_about_us.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_about_us.UseVisualStyleBackColor = true;
            this.btn_about_us.Click += new System.EventHandler(this.btn_about_us_Click);
            // 
            // btn_return
            // 
            this.btn_return.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_return.Location = new System.Drawing.Point(0, 102);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(173, 51);
            this.btn_return.TabIndex = 18;
            this.btn_return.Text = "Return";
            this.btn_return.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_rent
            // 
            this.btn_rent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rent.FlatAppearance.BorderSize = 0;
            this.btn_rent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rent.Location = new System.Drawing.Point(0, 51);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(173, 51);
            this.btn_rent.TabIndex = 17;
            this.btn_rent.Text = "Rent";
            this.btn_rent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rent.UseVisualStyleBackColor = true;
            // 
            // btn_vehicle_details
            // 
            this.btn_vehicle_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vehicle_details.FlatAppearance.BorderSize = 0;
            this.btn_vehicle_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_vehicle_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicle_details.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicle_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vehicle_details.Location = new System.Drawing.Point(0, 0);
            this.btn_vehicle_details.Name = "btn_vehicle_details";
            this.btn_vehicle_details.Size = new System.Drawing.Size(173, 51);
            this.btn_vehicle_details.TabIndex = 16;
            this.btn_vehicle_details.Text = "vehicle details";
            this.btn_vehicle_details.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_vehicle_details.UseVisualStyleBackColor = true;
            this.btn_vehicle_details.Click += new System.EventHandler(this.btn_vehicle_details_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 235);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 205);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(242)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 61);
            this.panel1.TabIndex = 90;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(668, 23);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(119, 24);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "user name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rent a car";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(601, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::IKMAN_APP.Properties.Resources.ikmn_copy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 93;
            this.label2.Text = "Customer ID";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(487, 205);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(154, 23);
            this.txt_name.TabIndex = 95;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 94;
            this.label5.Text = "Customer name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 96;
            this.label6.Text = "Rent Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 97;
            this.label7.Text = "Return Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 98;
            this.label8.Text = "Fees";
            // 
            // cmb_cid
            // 
            this.cmb_cid.FormattingEnabled = true;
            this.cmb_cid.ItemHeight = 23;
            this.cmb_cid.Location = new System.Drawing.Point(487, 137);
            this.cmb_cid.Name = "cmb_cid";
            this.cmb_cid.Size = new System.Drawing.Size(154, 29);
            this.cmb_cid.TabIndex = 100;
            this.cmb_cid.UseSelectable = true;
            // 
            // picker_rent_date
            // 
            this.picker_rent_date.Location = new System.Drawing.Point(487, 261);
            this.picker_rent_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.picker_rent_date.Name = "picker_rent_date";
            this.picker_rent_date.Size = new System.Drawing.Size(154, 29);
            this.picker_rent_date.TabIndex = 101;
            // 
            // picker_return_date
            // 
            this.picker_return_date.Location = new System.Drawing.Point(487, 315);
            this.picker_return_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.picker_return_date.Name = "picker_return_date";
            this.picker_return_date.Size = new System.Drawing.Size(154, 29);
            this.picker_return_date.TabIndex = 102;
            // 
            // txt_fees
            // 
            // 
            // 
            // 
            this.txt_fees.CustomButton.Image = null;
            this.txt_fees.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txt_fees.CustomButton.Name = "";
            this.txt_fees.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fees.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fees.CustomButton.TabIndex = 1;
            this.txt_fees.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fees.CustomButton.UseSelectable = true;
            this.txt_fees.CustomButton.Visible = false;
            this.txt_fees.Lines = new string[0];
            this.txt_fees.Location = new System.Drawing.Point(487, 371);
            this.txt_fees.MaxLength = 32767;
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.PasswordChar = '\0';
            this.txt_fees.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fees.SelectedText = "";
            this.txt_fees.SelectionLength = 0;
            this.txt_fees.SelectionStart = 0;
            this.txt_fees.ShortcutsEnabled = true;
            this.txt_fees.Size = new System.Drawing.Size(154, 23);
            this.txt_fees.TabIndex = 103;
            this.txt_fees.UseSelectable = true;
            this.txt_fees.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fees.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_pay_rent
            // 
            this.btn_pay_rent.FlatAppearance.BorderSize = 0;
            this.btn_pay_rent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_pay_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay_rent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay_rent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pay_rent.Location = new System.Drawing.Point(251, 436);
            this.btn_pay_rent.Name = "btn_pay_rent";
            this.btn_pay_rent.Size = new System.Drawing.Size(121, 30);
            this.btn_pay_rent.TabIndex = 104;
            this.btn_pay_rent.Text = "Pay / Rent";
            this.btn_pay_rent.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(575, 436);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(121, 30);
            this.btn_clear.TabIndex = 105;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cmb_car_reg_number
            // 
            this.cmb_car_reg_number.FormattingEnabled = true;
            this.cmb_car_reg_number.ItemHeight = 23;
            this.cmb_car_reg_number.Location = new System.Drawing.Point(487, 93);
            this.cmb_car_reg_number.Name = "cmb_car_reg_number";
            this.cmb_car_reg_number.Size = new System.Drawing.Size(154, 29);
            this.cmb_car_reg_number.TabIndex = 99;
            this.cmb_car_reg_number.UseSelectable = true;
            // 
            // btn_logout
            // 
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(33, 258);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(121, 30);
            this.btn_logout.TabIndex = 44;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // Rent_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_pay_rent);
            this.Controls.Add(this.txt_fees);
            this.Controls.Add(this.picker_return_date);
            this.Controls.Add(this.picker_rent_date);
            this.Controls.Add(this.cmb_cid);
            this.Controls.Add(this.cmb_car_reg_number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Rent_form";
            this.Load += new System.EventHandler(this.Rent_form_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroComboBox cmb_cid;
        private MetroFramework.Controls.MetroDateTime picker_rent_date;
        private MetroFramework.Controls.MetroDateTime picker_return_date;
        private MetroFramework.Controls.MetroTextBox txt_fees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_pay_rent;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_about_us;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.Button btn_vehicle_details;
        private MetroFramework.Controls.MetroComboBox cmb_car_reg_number;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_logout;
    }
}