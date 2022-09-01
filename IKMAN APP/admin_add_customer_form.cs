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
    public partial class admin_add_customer_form : MetroFramework.Forms.MetroForm
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

        public admin_add_customer_form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void btn_add_vehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_add_car_form obj = new Admin_add_car_form();
            obj.Show();
        }

        private void btn_view_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view obj = new admin_view();
            obj.Show();
        }
    }
}
