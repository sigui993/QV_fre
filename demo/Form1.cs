using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using ZJ_Common_control_system;

namespace demo
{
    public partial class 中久防务_Demo : Form
    {
        //类型
        delegate void send_delegate();
        //通用
        IPEndPoint point_to_up = new IPEndPoint(IPAddress.Any, 0);
        IPEndPoint point_from;

        //单设备资源
        bool net_leisure = true;
        Socket aimSocket;
        Thread receive_thReceive = null;
        Thread send_thReceive = null;
        bool com_link = false;
        bool net_link = false;
        bool send_thReceive_signal_light = false;//询问指令信号灯
        bool receive_thReceive_signal_light = false;//询问指令信号灯
        int receive_xh = 0;
        protocol_ZJ_sigui protocol = new protocol_ZJ_sigui();
        public 中久防务_Demo()
        {
            InitializeComponent();
        }

        private void checkBox3_Paint(object sender, PaintEventArgs e)
        {
            CheckBox_Slide.slide_Paint(sender, e);
        }
        private void link_UP_check_CheckedChanged(object sender, EventArgs e)//dwadf
        {
            if (link_UP_check.Checked == false)
            {
                link_UP_check.Text = "连接";
                cobProtocol.Enabled = true;
                txtIP.Enabled = true;
                txtPort.Enabled = true;
                groupBox1.Enabled = false;
                if (receive_thReceive != null)
                {
                    try
                    {
                        send_thReceive_signal_light = false;
                        receive_thReceive_signal_light = false;
                        aimSocket.Shutdown(SocketShutdown.Both);
                        aimSocket.Close();
                        aimSocket = null;
                    }
                    catch (Exception e1)
                    {
                    }
                }
                if (cobProtocol.Text == "UDP") selfPort.Enabled = true;
            }
            else
            {

                try
                {
                    switch (cobProtocol.Text)
                    {
                        case "UDP":
                            {
                                aimSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                                //aimSocket.Bind(new IPEndPoint(IPAddress.Any, Convert.ToInt32(selfPort.Text)));//绑定所有端口      
                                point_from = new IPEndPoint(IPAddress.Any, Convert.ToInt32(selfPort.Text));//绑定所有端口      
                                aimSocket.Bind(point_from);
                                point_to_up = new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtPort.Text));//目标端口                                            
                                receive_thReceive = new Thread(USReceive);
                            }
                            break;
                        case "TCP Server":
                            {
                            }
                            break;
                        case "TCP Client":
                            {
                                point_to_up = new IPEndPoint(IPAddress.Parse(txtIP.Text), Convert.ToInt32(txtPort.Text));//目标IP+端口     
                                aimSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                                aimSocket.Connect(point_to_up);//连接服务器
                                receive_thReceive = new Thread(TCReceive);
                            }
                            break;
                    }
                    txtIP.Enabled = false;
                    txtPort.Enabled = false;
                    selfPort.Enabled = false;
                    receive_thReceive.IsBackground = true;
                    receive_thReceive_signal_light = true;
                    receive_thReceive.Start();
                    send_thReceive = new Thread(get_state);
                    send_thReceive_signal_light = true;
                    send_thReceive.Start();
                    while (!net_leisure) ;
                    net_leisure = false;
                    //询问设备名
                    aimSocket.SendTo(protocol.get_CMD_byte(1, 2, 1, 0), point_to_up);
                    net_leisure = true;
                    //////////////////
                    //连接后各项功能使能     
                    cobProtocol.Enabled = false;
                    groupBox1.Enabled = true;
                    link_UP_check.Text = "断开";

                }
                catch (Exception e1)
                {
                    MessageBox.Show("连接失败");
                    link_UP_check.Checked = false;
                    //Link_Flag = false;
                }
            }//连接开关
        }
        int get_CMD_arr = 0;
        int get_CMD_num = 0;
        int get_CMD_length = 0;
        int get_CMD_he = 0;
        byte[] get_CMD = new byte[256];
        void USReceive()
        {
            while (receive_thReceive_signal_light)
            {
                byte[] buffer = new byte[2048];
                int data_length = 0;
                try
                {
                    //data_length = aimSocket.Receive(buffer);
                    EndPoint point = point_to_up;//用来保存发送
                    data_length = aimSocket.ReceiveFrom(buffer, ref point);
                }
                catch (Exception e1)
                {
                    if (receive_thReceive_signal_light == true)
                    {
                        MessageBox.Show("被控设备异常离线");
                        link_UP_check.Checked = false;
                    }
                }

                for (int xh = 0; xh < data_length; xh++)
                {
                    bool OK = true;
                    switch (receive_xh)
                    {
                        case -1://-1为校验和分支
                            {
                                if ((get_CMD_he & 0xff) == buffer[xh])
                                {
                                    //命令生效
                                    CMD_run_UP(get_CMD_arr, get_CMD_num, get_CMD);
                                }
                                OK = false;
                            }
                            break;
                        case 0: if (buffer[xh] != 0xA5) OK = false; break;
                        case 1: if (buffer[xh] != 0x5A) OK = false; break;
                        case 2: if (buffer[xh] != 0x11) { OK = false; MessageBox.Show("协议版本错误,设备协议版本" + (buffer[xh] >> 4) + "." + (buffer[xh] & 0xf) + ",上位机协议版本:1.1"); } break;
                        case 3:
                        case 4:
                        case 7:
                        case 8: if (buffer[xh] != 0x00) OK = false; break;
                        case 5: get_CMD_arr = buffer[xh]; break;
                        case 6: get_CMD_num = buffer[xh]; break;
                        case 9: get_CMD_length = buffer[xh]; get_CMD_he = buffer[xh]; break;
                        default://数据域
                            {
                                get_CMD_he += buffer[xh];
                                get_CMD[receive_xh - 10] = buffer[xh];
                                if (receive_xh - 9 >= get_CMD_length) receive_xh = -2;
                            }
                            break;
                    }
                    if (OK) receive_xh++;
                    else receive_xh = 0;
                }

            }
        }//UDP Server接收线程

        void TCReceive()
        {
        }//TCP Client接收线程
        public void get_state()
        {
            while (send_thReceive_signal_light)
            {
                try
                {
                    while (!net_leisure) ;
                    net_leisure = false;
                    aimSocket.SendTo(protocol.get_CMD_byte(1, 1, 1, 0), point_to_up);
                    net_leisure = true;
                }
                catch (Exception e1)
                {
                    MessageBox.Show("设备断开");
                    link_UP_check.Checked = false;
                }

                Thread.Sleep(1000);
            }
        }//卍

        /// <summary>上变频查询状态</summary>
        private void CMD_run_UP(int arr, int num, byte[] CMD)
        {
            switch (arr)
            {
                case 0xf1://状态回复
                    {
                        switch (num)
                        {
                            case 0xf1://综合状态回复
                                {
                                }
                                break;
                            case 0xf2://设备名回复
                                {
                                    byte[] temp = new byte[7];
                                    for (int xh = 0; xh < 7; xh++)
                                    {
                                        temp[xh] = CMD[xh];
                                    }
                                    device_name.Text = System.Text.Encoding.UTF8.GetString(temp);
                                }
                                break;
                        }
                    }
                    break;
            }
        }
        /// <summary>下变频查询状态</summary>
        private void CMD_run_Down(int arr, int num, byte[] CMD)
        {
            switch (arr)
            {
                case 0xf1://状态回复
                    {
                        switch (num)
                        {
                            case 0xf1://综合状态回复
                                {
                                }
                                break;
                            case 0xf2://设备名回复
                                {
                                    byte[] temp = new byte[7];
                                    for (int xh = 0; xh < 7; xh++)
                                    {
                                        temp[xh] = CMD[xh];
                                    }
                                    device_name_down.Text = System.Text.Encoding.UTF8.GetString(temp);
                                }
                                break;
                        }
                    }
                    break;
            }
        }
        private void link_down_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>选协议</summary>
        private void cobProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobProtocol.SelectedItem.ToString())
            {
                case "UDP":
                    {
                        lblIP.Text = "目标IP：";
                        lblPort.Text = "目标端口号:";
                        selfPort.Enabled = true;
                    }
                    break;
                case "UDP Client":
                    {
                        lblIP.Text = "服务器IP：";
                        lblPort.Text = "服务器端口：";
                        selfPort.Enabled = false;
                    }
                    break;
                case "TCP Server":
                    {
                        lblIP.Text = "本地IP：";
                        lblPort.Text = "本地端口号：";
                        selfPort.Enabled = false;
                    }
                    break;
                case "TCP Client":
                    {
                        lblIP.Text = "服务器IP：";
                        lblPort.Text = "服务器端口：";
                        selfPort.Enabled = false;
                    }
                    break;
            }
        }

        private void 中久防务_Demo_Load(object sender, EventArgs e)
        {
            cobProtocol.SelectedIndex = 0;
            cobProtocol_down.SelectedIndex = 0;

            up_form.up_form_init("192.168.1.80", "4000", "4000", true);
            down_form.up_form_init("192.168.1.81", "4001", "4001", false);
        }
    }
    class CheckBox_Slide
    {
        static public void slide_Paint(object sender, PaintEventArgs e)
        {
            CheckBox rButton = (CheckBox)sender;
            Graphics g = e.Graphics;
            g.Clear(rButton.Parent.BackColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (rButton.Checked)
            {
                FillRoundRectangle(g, Brushes.LawnGreen, new Rectangle(0, 2, (int)rButton.Font.Size * 2, (int)rButton.Font.Size - 4));
                FillRoundRectangle(g, Brushes.White, new Rectangle((int)(rButton.Font.Size * 1) + 3, 4, (int)(rButton.Font.Size - 8), (int)rButton.Font.Size - 8));   //卍
            }
            else
            {
                FillRoundRectangle(g, Brushes.Silver, new Rectangle(0, 2, (int)rButton.Font.Size * 2, (int)rButton.Font.Size - 4));
                FillRoundRectangle(g, Brushes.White, new Rectangle(3, 4, (int)(rButton.Font.Size - 8), (int)rButton.Font.Size - 8));      //卍   
            }
            Brush color = null;
            if (rButton.Enabled == false)
            {
                color = Brushes.Gray;
            }
            else
            {
                color = Brushes.Black;
            }
            g.DrawString(rButton.Text, rButton.Font, color, new PointF((int)rButton.Font.Size * 2, 0));
            rButton.Height = rButton.Font.Height;
            rButton.Width = (int)(rButton.Font.Size * (rButton.Text.Length + 2.3));
        }//checkbox外观改变
        public static void FillRoundRectangle(Graphics g, Brush brush, Rectangle rect)//画圆
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, rect.Height, rect.Height, 90, 180);
            roundedRect.AddArc(rect.X + rect.Width - rect.Height, rect.Y, rect.Height, rect.Height, 270, 180);
            roundedRect.CloseFigure();
            g.FillPath(brush, roundedRect);
        }/// 填充圆角矩形
    }//用于改变选择控件图形样式(自适应字体大小及字数)
}
