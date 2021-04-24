using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class up_form : UserControl
    {
        public up_form()
        {
            InitializeComponent();
        }
        public void up_form_init(string ip,string d_port, string s_port,bool is_up)
        {
            cobProtocol.SelectedIndex = 0;
            txtIP.Text = ip;
            txtPort.Text = d_port;
            selfPort.Text = s_port;
            if(is_up)
            {
                groupBox2.Text = "上变频网络连接";
                groupBox_check.Text = "V上变频";
                label6.Visible = false;
                WAG_check.Visible = false;
            }
            else
            {
                label16.Visible = false;
                label17.Visible = false;
            }

        }
        /// <summary>控件图像改变</summary>
        private void check_slide_Paint(object sender, PaintEventArgs e)
        {
            CheckBox_Slide.slide_Paint(sender, e);
        }
    }
}
