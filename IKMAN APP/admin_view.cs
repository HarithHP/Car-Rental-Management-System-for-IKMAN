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
    public partial class admin_view : MetroFramework.Forms.MetroForm
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

        public admin_view()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void admin_view_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_vehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_add_car_form obj = new Admin_add_car_form();
            obj.Show();
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_customer_form obj = new admin_add_customer_form();
            obj.Show();
        }
    }
}
