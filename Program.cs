using System;
using System.IO;

namespace DirectoryDirectoryInfo {
    class Program {
        static void Main (string[] args) {
            string path = @"D:\Users\Matheus\Desktop\Curso - C# - Udemy\Projetos\myfolder";

            try {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(@"D:\Users\Matheus\Desktop\Curso - C# - Udemy\Projetos\myfolder\newfolder");
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}