using System;
using System.IO;
using System.Linq;

namespace FileTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine($"源文件夹 {args[0]}");
            Console.Out.WriteLine($"目标文件夹为 /当前目录/Out/");

            // Loop to get all file's path in all folders including subfolders
            var files = Directory.GetFiles(args[0], "*.*", SearchOption.AllDirectories);
            Directory.CreateDirectory($"{args[0]}/Out");

            
            foreach (var file in files)
            {
                if (file.Split("/").Last().StartsWith("."))
                {
                    continue;
                }
                Console.Out.WriteLine($"{file}");
                File.Copy(file, $"{args[0]}/Out/{file.Split("/").Last()}");
            }
        }
    }
}