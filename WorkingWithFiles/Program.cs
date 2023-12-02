//namespace CSharpFundamentals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            var path = @"c:\somefile.jpg";

//            //File provides static methods
//            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
//            File.Delete(path);

//            if (File.Exists(path))
//            {
//                //
//            }
//            var content = File.ReadAllText(path);

//            //FileInfo provides instance methods
//            var fileInfo = new FileInfo(path);
//            fileInfo.CopyTo("...");
//            fileInfo.Delete();
//            if (fileInfo.Exists)
//            {
//                //
//            }


//        }
//    }
//}