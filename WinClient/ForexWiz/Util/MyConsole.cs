using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LeoStudio
{
    public class MyConsole
    {
        private static bool isDebug = true;
        private static RichTextBox typeWriter;

        public bool IsDebug
        {
            get { return isDebug; }
            set { isDebug = value; }
        }

        public MyConsole(RichTextBox rtb)
        {
            typeWriter = rtb;
        }

        public static void Write(string msg, ConMsgType type)
        {
            if (typeWriter == null) return;
            if (!isDebug && type == ConMsgType.Debug)
            {
                return;
            }
            typeWriter.AppendText(msg + "\n");
        }




    }

    public enum ConMsgType
    {
        Debug,//调试时才输出的信息
        Normal,//一般输出信息
    }

}
