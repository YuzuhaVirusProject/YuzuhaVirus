using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NotMuch
{
    static class YuzuMuch
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
