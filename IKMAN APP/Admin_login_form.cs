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
    public partial class Admin_login_form : MetroFramework.Forms.MetroForm
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

        public Admin_login_form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Admin_login_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form obj = new login_form();
            obj.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_add_car_form obj = new Admin_add_car_form();
            obj.Show();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
