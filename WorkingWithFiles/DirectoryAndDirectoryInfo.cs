//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace WorkingWithFiles
//{
//    internal class DirectoryAndDirectoryInfo
//    {
//        public static void Main(string[] args)
//        {
//            Directory.CreateDirectory(@"c:\temp\folder1");

//            //var files = Directory.GetFiles(@"C:\Users\tuna_\source\repos", "*.sln", SearchOption.AllDirectories );
//            //foreach ( var file in files )
//            //{
//            //    Console.WriteLine( file );
//            //}

//            var directories = Directory.GetDirectories(@"C:\Users\tuna_\source\repos", "*.*", SearchOption.AllDirectories);

//            foreach ( var directory in directories )
//            {
//                Console.WriteLine( directory );
//            }

//            Directory.Exists("...");

//            var directoryInfo = new DirectoryInfo("...");
//            directoryInfo.GetFiles();
//            directoryInfo.GetDirectories();

//        }
//    }
//}
