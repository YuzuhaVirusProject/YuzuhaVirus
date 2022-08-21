using System.Reflection;
using System.IO;
using System.Threading;
using System.Text;

namespace YuzuhaVirus
{
    public static class Functions
    {
        public static void Extract( string nameSpace, string outDirectory, string internalFilePath, string resourceName )
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream( nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName ))
            using (BinaryReader r = new BinaryReader( s ))
            using (FileStream fs = new FileStream( outDirectory + "\\" + resourceName, FileMode.OpenOrCreate ))
            using (BinaryWriter w = new BinaryWriter( fs ))
            {
                w.Write( r.ReadBytes( (int)s.Length ) );
            }
        }
        public static void SecSleep( int t )
        {
            Thread.Sleep( t * 1000 );
            return;
            // by mist
        }
        public static void CreateThreadStart( ThreadStart thread )
        {
            new Thread( new ThreadStart( thread ) ).Start();
            // by mist
        }
    }
}
