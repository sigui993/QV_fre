
namespace demo
{
    partial class up_form
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selfPort = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.link_down_check = new System.Windows.Forms.CheckBox();
            this.cobProtocol = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox_check = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.device_name_down = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.WAG_check = new System.Windows.Forms.CheckBox();
            this.panel_att = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.down_att_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.check_rf_oprn = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox_check.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_att.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.down_att_num)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selfPort);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.link_down_check);
            this.groupBox2.Controls.Add(this.cobProtocol);
            this.groupBox2.Controls.Add(this.txtIP);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 16F);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 200);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下变频网络连接";
            // 
            // selfPort
            // 
            this.selfPort.Font = new System.Drawing.Font("宋体", 15F);
            this.selfPort.Location = new System.Drawing.Point(129, 133);
            this.selfPort.Name = "selfPort";
            this.selfPort.Size = new System.Drawing.Size(60, 30);
            this.selfPort.TabIndex = 73;
            this.selfPort.Text = "4001";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 15F);
            this.label21.Location = new System.Drawing.Point(10, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 20);
            this.label21.TabIndex = 72;
            this.label21.Text = "本地端口号:";
            // 
            // link_down_check
            // 
            this.link_down_check.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.link_down_check.Location = new System.Drawing.Point(13, 169);
            this.link_down_check.Name = "link_down_check";
            this.link_down_check.Size = new System.Drawing.Size(82, 25);
            this.link_down_check.TabIndex = 51;
            this.link_down_check.Text = "连接";
            this.link_down_check.UseVisualStyleBackColor = true;
            this.link_down_check.Paint += new System.Windows.Forms.PaintEventHandler(this.check_slide_Paint);
            // 
            // cobProtocol
            // 
            this.cobProtocol.Font = new System.Drawing.Font("宋体", 15F);
            this.cobProtocol.FormattingEnabled = true;
            this.cobProtocol.Items.AddRange(new object[] {
            "UDP",
            "TCP Server",
            "TCP Client"});
            this.cobProtocol.Location = new System.Drawing.Point(111, 28);
            this.cobProtocol.Name = "cobProtocol";
            this.cobProtocol.Size = new System.Drawing.Size(121, 28);
            this.cobProtocol.TabIndex = 1;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("宋体", 15F);
            this.txtIP.Location = new System.Drawing.Point(96, 63);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(138, 30);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "192.168.1.81";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 15F);
            this.label18.Location = new System.Drawing.Point(10, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "协议类型：";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("宋体", 15F);
            this.txtPort.Location = new System.Drawing.Point(130, 96);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(59, 30);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "4002";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 15F);
            this.label19.Location = new System.Drawing.Point(10, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "设备端口号：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 15F);
            this.label20.Location = new System.Drawing.Point(10, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "设备IP：";
            // 
            // groupBox_check
            // 
            this.groupBox_check.Controls.Add(this.label26);
            this.groupBox_check.Controls.Add(this.device_name_down);
            this.groupBox_check.Controls.Add(this.textBox6);
            this.groupBox_check.Controls.Add(this.label25);
            this.groupBox_check.Controls.Add(this.panel5);
            this.groupBox_check.Controls.Add(this.panel4);
            this.groupBox_check.Controls.Add(this.panel_att);
            this.groupBox_check.Controls.Add(this.panel3);
            this.groupBox_check.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox_check.Location = new System.Drawing.Point(3, 209);
            this.groupBox_check.Name = "groupBox_check";
            this.groupBox_check.Size = new System.Drawing.Size(286, 406);
            this.groupBox_check.TabIndex = 71;
            this.groupBox_check.TabStop = false;
            this.groupBox_check.Text = "Q下变频";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 15F);
            this.label26.Location = new System.Drawing.Point(10, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 20);
            this.label26.TabIndex = 76;
            this.label26.Text = "设备名";
            // 
            // device_name_down
            // 
            this.device_name_down.Font = new System.Drawing.Font("宋体", 15F);
            this.device_name_down.Location = new System.Drawing.Point(85, 41);
            this.device_name_down.Name = "device_name_down";
            this.device_name_down.ReadOnly = true;
            this.device_name_down.Size = new System.Drawing.Size(178, 30);
            this.device_name_down.TabIndex = 71;
            this.device_name_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox6.Location = new System.Drawing.Point(74, 244);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(93, 35);
            this.textBox6.TabIndex = 72;
            this.textBox6.Text = "11.1dBm";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label25.Location = new System.Drawing.Point(10, 247);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 24);
            this.label25.TabIndex = 71;
            this.label25.Text = "温度:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(6, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 115);
            this.panel5.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(103, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "正常";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(4, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "CH2状态:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(102, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "正常";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "CH1状态:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.WAG_check);
            this.panel4.Location = new System.Drawing.Point(6, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 48);
            this.panel4.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "低噪放上电";
            // 
            // WAG_check
            // 
            this.WAG_check.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WAG_check.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WAG_check.Location = new System.Drawing.Point(138, 10);
            this.WAG_check.Name = "WAG_check";
            this.WAG_check.Size = new System.Drawing.Size(90, 24);
            this.WAG_check.TabIndex = 0;
            this.WAG_check.Text = "上电";
            this.WAG_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WAG_check.UseVisualStyleBackColor = false;
            this.WAG_check.Paint += new System.Windows.Forms.PaintEventHandler(this.check_slide_Paint);
            // 
            // panel_att
            // 
            this.panel_att.AutoSize = true;
            this.panel_att.Controls.Add(this.label15);
            this.panel_att.Controls.Add(this.down_att_num);
            this.panel_att.Controls.Add(this.label1);
            this.panel_att.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel_att.Location = new System.Drawing.Point(6, 192);
            this.panel_att.Name = "panel_att";
            this.panel_att.Size = new System.Drawing.Size(274, 42);
            this.panel_att.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(227, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 24);
            this.label15.TabIndex = 42;
            this.label15.Text = "dB";
            // 
            // down_att_num
            // 
            this.down_att_num.DecimalPlaces = 1;
            this.down_att_num.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.down_att_num.Location = new System.Drawing.Point(120, 3);
            this.down_att_num.Name = "down_att_num";
            this.down_att_num.Size = new System.Drawing.Size(97, 35);
            this.down_att_num.TabIndex = 51;
            this.down_att_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.down_att_num.Value = new decimal(new int[] {
            105,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "衰减设置：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.check_rf_oprn);
            this.panel3.Location = new System.Drawing.Point(6, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 48);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "设备上电";
            // 
            // check_rf_oprn
            // 
            this.check_rf_oprn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.check_rf_oprn.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.check_rf_oprn.Location = new System.Drawing.Point(123, 10);
            this.check_rf_oprn.Name = "check_rf_oprn";
            this.check_rf_oprn.Size = new System.Drawing.Size(90, 24);
            this.check_rf_oprn.TabIndex = 0;
            this.check_rf_oprn.Text = "上电";
            this.check_rf_oprn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check_rf_oprn.UseVisualStyleBackColor = false;
            this.check_rf_oprn.Paint += new System.Windows.Forms.PaintEventHandler(this.check_slide_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(169, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 24);
            this.label16.TabIndex = 8;
            this.label16.Text = "正常";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label17.Location = new System.Drawing.Point(4, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 24);
            this.label17.TabIndex = 7;
            this.label17.Text = "共用本振状态:";
            // 
            // up_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_check);
            this.Name = "up_form";
            this.Size = new System.Drawing.Size(295, 643);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_check.ResumeLayout(false);
            this.groupBox_check.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_att.ResumeLayout(false);
            this.panel_att.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.down_att_num)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox selfPort;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox link_down_check;
        private System.Windows.Forms.ComboBox cobProtocol;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox_check;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox device_name_down;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox WAG_check;
        private System.Windows.Forms.Panel panel_att;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown down_att_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_rf_oprn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
