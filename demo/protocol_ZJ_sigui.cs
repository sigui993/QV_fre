using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZJ_Common_control_system
{
    class protocol_ZJ_sigui
    {
        const int HAND_MAX = 10;
        static bool BUSY = false;
        //协议版本号:V1.0
        byte[] hand = new byte[HAND_MAX]{
            0xA5,0x5A,//头
            0xff,//版本号 ff为临时版本
            0x00,0x00,//预留
            0x00,//命令组
            0x00,//命令号
            0x00,0x00,//保留    
            0x00,//长度
        };
        enum data_addr
        {
            CMD_arr = 5,
            CMD_num = 6,
            Length = 9,
        };



        /// <summary>
        /// 生成命令
        /// </summary>
        /// <param name="cmdarr">命令组</param>
        /// <param name="cmdnum">命令号</param>
        /// <param name="length">数据长度</param>
        /// <param name="parameter">参数</param>
        /// <returns>生成的命令数据流</returns>
        public byte[] get_CMD_byte(int cmdarr,int cmdnum,int length,int parameter)
        {
            while (BUSY) ;//线程卡死等待,用于多线程抢资源
            BUSY = true;
            byte[] data = new byte[HAND_MAX + length+1];
            //头
            hand[(int)data_addr.CMD_arr] = (byte)cmdarr;
            hand[(int)data_addr.CMD_num] = (byte)cmdnum;
            hand[(int)data_addr.Length] = (byte)length;
            hand.CopyTo(data, 0);
            //参数     
            for (int xh=length;xh>0;xh--)
            {                                                                                   
                data[(int)data_addr.Length + xh] = (byte)(parameter & 0xff);
                parameter = parameter >> 8;
            }
            //校验和                                               
            data[HAND_MAX + length] = (byte)length;
            for (int xh=0; xh<length;xh++)
            {
                data[HAND_MAX + length] = (byte)((data[HAND_MAX + length] + data[HAND_MAX+xh])&0xff);
            }
            BUSY = false;
            return data;      
        }//全命令执行
    }
}

