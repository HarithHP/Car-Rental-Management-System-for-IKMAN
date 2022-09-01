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
using System.Data.SqlClient;

namespace IKMAN_APP
{
    public partial class Admin_add_car_form : MetroFramework.Forms.MetroForm
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

        public Admin_add_car_form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;


        private void Admin_add_car_form_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=DESKTOP-H79V446\\MSSQLSERVER01;Initial Catalog=ikman_app;Integrated Security=True");
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_add_customer_form obj = new admin_add_customer_form();
            obj.Show();
        }

        private void btn_view_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_view obj = new admin_view();
            obj.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into car_details values('" + txt_car_reg_number.Text + "','" + cmb_type.SelectedItem + "','" + cmb_brand.SelectedItem + "','" + txt_model.Text + "','" + txt_price.Text + "','" + txt_color.Text + "','" + cmb_avilable.SelectedItem + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MetroFramework.MetroMessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
                
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_car_reg_number.Clear();
            txt_color.Clear();
            txt_model.Clear();
            txt_price.Clear();
            cmb_avilable.SelectedIndex = -1;
            cmb_brand.SelectedIndex = -1;
            cmb_type.SelectedIndex = -1;
        }
    }
}
