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
    public partial class Rent_form : MetroFramework.Forms.MetroForm
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

        public Rent_form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void Rent_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_vehicle_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_car_detail_form obj = new user_car_detail_form();
            obj.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_form obj = new Return_form();
            obj.Show();
        }

        private void btn_about_us_Click(object sender, EventArgs e)
        {
            this.Show();
            about_us obj = new about_us();
            obj.Show();
        }
    }
}
