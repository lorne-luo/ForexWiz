using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace LeoStudio
{
    public class Win32
    {
        //internal const int EWX_SHUTDOWN = 0x00000001;//关机
        //internal const int EWX_FORCE = 0x00000004;
        //internal const int EWX_POWEROFF = 0x00000008;
        //internal const int EWX_FORCEIFHUNG = 0x00000010;

        //private const int SW_HIDE = 0;
        //private const int SW_SHOWNORMAL = 1;
        //private const int SW_SHOWMINIMIZED = 2;
        //private const int SW_SHOWMAXIMIZED = 3;
        //private const int SW_SHOWNOACTIVATE = 4;
        //private const int SW_RESTORE = 9;
        //private const int SW_SHOWDEFAULT = 10;

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        internal static bool ShutDown()
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);

            return ExitWindowsEx(EWX_POWEROFF | EWX_FORCEIFHUNG | EWX_POWEROFF, 0);
            //return ExitWindowsEx(EWX_SHUTDOWN | EWX_FORCE | EWX_POWEROFF, 0);
        }

        //播放wav
        //[DllImport("winmm.dll")]
        //public static extern int PlaySound(
        //                string lpstrCommand,
        //                string lpstrReturnString,
        //                long uReturnLength,
        //                int hwndCallback
        //        );
        [DllImport("WinMM.dll")]
        public static extern bool PlaySound(string szSound, IntPtr hMod, PlaySoundFlags flags);

        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,    /* play synchronously (default) */ //同步 
            SND_ASYNC = 0x0001,    /* play asynchronously */ //异步 
            SND_NODEFAULT = 0x0002,    /* silence (!default) if sound not found */
            SND_MEMORY = 0x0004,    /* pszSound points to a memory file */
            SND_LOOP = 0x0008,    /* loop the sound until next sndPlaySound */
            SND_NOSTOP = 0x0010,    /* don't stop any currently playing sound */
            SND_NOWAIT = 0x00002000, /* don't wait if the driver is busy */
            SND_ALIAS = 0x00010000, /* name is a registry alias */
            SND_ALIAS_ID = 0x00110000, /* alias is a predefined ID */
            SND_FILENAME = 0x00020000, /* name is file name */
            SND_RESOURCE = 0x00040004    /* name is resource name or atom */
        }
        public static void PlayWav2(string strPath)
        {
            PlaySound(strPath, IntPtr.Zero, PlaySoundFlags.SND_ASYNC);
        }


        //蜂鸣器 int freq 频率 int dura 时长
        [DllImport("kernel32")]
        public static extern bool Beep(int freq, int dura);


        private static System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
        private static bool isPlaying;
        public static void PlayWav()
        {
            if (!isPlaying)
            {
                string path = Application.StartupPath + "\\alert.wav";
                if (File.Exists(path))
                {
                    sp.SoundLocation = path;
                    sp.PlayLooping();
                    isPlaying = true;
                }
            }
        }
        public static void StopWav()
        {
            if (isPlaying)
            {
                sp.Stop();
                isPlaying = false;
            }
        }

    }

    public interface IPersistStreamInit
    {
        void GetClassID([In, Out] ref Guid pClassID);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int IsDirty();

        void Load([In, MarshalAs(UnmanagedType.Interface)] UCOMIStream pstm);
        void Save([In, MarshalAs(UnmanagedType.Interface)] UCOMIStream pstm,
                  [In, MarshalAs(UnmanagedType.I4)] int fClearDirty);
        void GetSizeMax([Out, MarshalAs(UnmanagedType.LPArray)] long pcbSize);
        void InitNew();
    }



}
