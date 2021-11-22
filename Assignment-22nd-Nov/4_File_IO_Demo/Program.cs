using System;
using System.IO;

namespace _4_File_IO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("D:\\Utsav\\Benchmark\\C#\\Assignment-22nd-Nov\\4_File_IO_Demo");

            if (di.Exists)
            {
                Console.WriteLine("Full Name: "+di.FullName);
                Console.WriteLine("Created at: "+di.CreationTime);
                Console.WriteLine("Parent Directory: "+di.Parent);
                Console.WriteLine("Last Edited: "+di.LastWriteTime);

                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo f in fi)
                {
                    Console.WriteLine("************");
                    Console.WriteLine("Full name: "+f.FullName);
                    Console.WriteLine("Extension: "+f.Extension);
                    Console.WriteLine("Created at: "+f.CreationTime);
                    Console.WriteLine("Length: "+f.Length);
                    Console.WriteLine("************");
                }
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory Created");

            }

        }
    }
}
