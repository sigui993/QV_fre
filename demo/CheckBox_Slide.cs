using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace sigui.control
{
    class CheckBox_Slide
    {
        /// <summary>checkbox外观改变</summary>
        static public void slide_Paint(object sender, PaintEventArgs e)
        {
            CheckBox rButton = (CheckBox)sender;
            Graphics g = e.Graphics;
            g.Clear(rButton.Parent.BackColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (rButton.Checked)
            {                                                                                
                FillRoundRectangle(g, Brushes.LawnGreen, new Rectangle(0, 2, (int)rButton.Font.Size*2, (int)rButton.Font.Size-4));
                FillRoundRectangle(g, Brushes.White, new Rectangle((int)(rButton.Font.Size * 1)+3, 4, (int)(rButton.Font.Size-8), (int)rButton.Font.Size - 8));   //卍
            }
            else
            {                                                                              
                FillRoundRectangle(g, Brushes.Silver, new Rectangle(0, 2, (int)rButton.Font.Size * 2, (int)rButton.Font.Size - 4));
                FillRoundRectangle(g, Brushes.White, new Rectangle(3, 4, (int)(rButton.Font.Size -8), (int)rButton.Font.Size - 8));      //卍   
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
            g.DrawString(rButton.Text, rButton.Font, color, new PointF((int)rButton.Font.Size*2, 0));
            rButton.Height=rButton.Font.Height;
            rButton.Width = (int)(rButton.Font.Size* (rButton.Text.Length+2.3));
        }
        /// <summary>填充圆角矩形</summary>
        public static void FillRoundRectangle(Graphics g, Brush brush, Rectangle rect)//画圆
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, rect.Height, rect.Height, 90, 180);
            roundedRect.AddArc(rect.X + rect.Width - rect.Height, rect.Y, rect.Height, rect.Height, 270, 180);
            roundedRect.CloseFigure();
            g.FillPath(brush, roundedRect);
        }/// 
    }//用于改变选择控件图形样式(自适应字体大小及字数)
}
