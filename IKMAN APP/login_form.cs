using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IKMAN_APP
{
    public partial class login_form : MetroFramework.Forms.MetroForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
      (
       int nLeftRect,
       int nTopRect,
       int RightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse

       );

        public login_form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_newuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            register_form obj = new register_form();
            obj.Show();
        }

        

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_car_detail_form obj = new user_car_detail_form();
            obj.Show();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_continue_as_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login_form obj = new Admin_login_form();
            obj.Show();
        }
    }
}
