using System;
using System.Collections.Generic;
using System.Text;

namespace WpfRavRobot.Common
{
    public static class CommonDefine
    {
        //Ezi IO
        public const ushort TCP = 1;
        public const ushort UDP = 0;
        public const ushort ID = 0;

        //Pinout map
        public const ushort OUT_CAMERA = 0;
        public const ushort OUT_SELECT_PROGRAM_ROBOT = 1;
        public const ushort OUT_ENABLE_ROBOT = 2;
        public const ushort OUT_3 = 3;
        public const ushort OUT_4 = 4;
        public const ushort OUT_5 = 5;
        public const ushort OUT_FEEDER = 6;
        public const ushort OUT_BOWL = 7;

        //Output register map
        public const int EZ_OUT_CAMERA = 256; //Trigger
        public const int EZ_OUT_SELECT_PROGRAM_ROBOT = 512;
        public const int EZ_OUT_ENABLE_ROBOT = 1024;
        public const int EZ_OUT_3 = 2048;
        public const int EZ_OUT_4 = 4096; //on all time the first
        public const int EZ_OUT_5 = 8192; //Trigger
        public const int EZ_OUT_FEEDER = 16384; //Trigger
        public const int EZ_OUT_BOWL = 32768; // Press 

        public const int EZ_OFF_ALL = 0x00000000;
        public const int EZ_ON_ALL = 0x0000F000;


        //HIWIN
        public const string HOME = "(HOME)";
        public const string DONE = "(DONE)";
        public const string PING = "(113)";
        public const string WAITING = "(OKAY)";
        public const string END_PRO = "(END)";


        //ERRORS
        public const int ERROR_CAMERA = 1;

        //CAMERA
        public const int OFFSET_X = 640;
        public const int OFFSET_Y = 240;
        public const int WIDTH = 2500;
        public const int HEIGHT = 2000;

        //TIMER
        public const int TIME_CHECK_BOWL = 5; // THOI GIAN KIEM TRA SO LUONG HANG DE BAT BOWL
        public const int TIME_ON_BOWL = 7000; // THOI GIAN ON BOWL
        public const int TIME_AFTER_OFF_BOWL = 500;// THOI GIAN DUNG SAU KHI OFF BOWL
        public const int TIME_LOAD_PRO_ROBOT = 15000; // YHOI GIAN LOAD PROGRAM KHI KHOI DONG ROBOT

        //bowl
        public const int UNDER_NUM_OBJ = 2;// KIEM TRA SO LUONG CON HANG DE BAT BOWL
    }
}
