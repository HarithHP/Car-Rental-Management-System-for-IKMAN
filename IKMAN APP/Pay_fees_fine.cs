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
    public partial class Pay_fees_fine : MetroFramework.Forms.MetroForm
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

        public Pay_fees_fine()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return_form obj = new Return_form();
            obj.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }
    }
}
