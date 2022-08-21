using System.Runtime.InteropServices;

namespace YuzuhaVirus
{
    public static class DLL
    {
        [DllImport( "Monoxide" )]
        public static extern void MonoxideStart();
        // by Mist
    }
}
